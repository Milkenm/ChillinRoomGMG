
using Newtonsoft.Json;

using RestSharp;

using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using static GMG_Core.APIs.XMRigAPI;

namespace GMG_Core.Xmrig
{
	public class XMRig
	{
		private static string APILocalhost => "http://localhost:38486";
		private static string APISummary => APILocalhost + "/1/summary";
		private static string APIJsonRPC => APILocalhost + "/json_rpc";

		public delegate void ShareEvent();
		public event ShareEvent OnValidShare;
		public event ShareEvent OnInvalidShare;
		public delegate void LoggedHashRateEvent(decimal hashrate);
		public event LoggedHashRateEvent OnLoggedHashRate;
		public delegate void MinerStateChangeEvent(MinerState newState);
		public event MinerStateChangeEvent OnMinerStateChange;

		private Process XmrigProcess { get; set; }
		private RestClient APIClient => new RestClient();

		private string MinerExePath { get; }
		private string ConfigPath { get; }

		public bool IsInitialized { get; private set; }
		public bool IsReady { get; private set; }
		public bool IsRunning { get; private set; }

		public int ValidShares { get; private set; }
		public int InvalidShares { get; private set; }

		public XMRig(string xmrigFolder)
		{
			this.MinerExePath = xmrigFolder + @"\xmrig.exe";
			this.ConfigPath = xmrigFolder + @"\config.json";

			this.UpdateConfig(GData.SettingsManager.Settings.XmrigConfig);
		}

		~XMRig()
		{
			if (this.GetMinerState() != MinerState.Stopped)
			{
				this.StopMiner();
			}
		}

		#region Miner Actions
		public void InitializeMiner(bool run = false)
		{
			if (this.IsInitialized == false)
			{
				Process p = new Process()
				{
					StartInfo = new ProcessStartInfo()
					{
						FileName = this.MinerExePath,
						UseShellExecute = false,
						CreateNoWindow = true,
						Verb = "runas",
					},
				};
				p.Exited += this.P_Exited;
				p.Start();

				p.PriorityClass = (ProcessPriorityClass)GData.SettingsManager.Settings.XmrigPriority;

				this.XmrigProcess = p;

				if (run == false)
				{
					this.SetState(MinerState.PausedInitializing);
					this.PauseMiner();
				}
				else
				{
					this.SetState(MinerState.Initializing);
				}

				Task.Run(() =>
				{
					while (p.HasExited == false)
					{
						this.GetAPI();
					}
				});
			}
			else
			{
				throw new Exception(Lang.Miner_AlreadyInitialized);
			}
		}

		private void P_Exited(object sender, EventArgs e)
		{
			throw new Exception("Process exited.");
		}

		public void PauseMiner()
		{
			if (this.IsInitialized && this.IsRunning)
			{
				this.MinerRPC("pause");
				if (this.IsInitialized)
				{
					this.SetState(MinerState.Paused);
				}
				else
				{
					this.SetState(MinerState.PausedInitializing);
				}
			}
			else
			{
				if (this.IsInitialized)
				{
					throw new Exception(Lang.Miner_AlreadyPaused);
				}
				else
				{
					throw new Exception(Lang.Miner_NotInitialized);
				}
			}
		}

		public void ResumeMiner()
		{
			if (this.IsInitialized && this.IsRunning == false)
			{
				this.MinerRPC("resume");
				if (this.IsInitialized)
				{
					this.SetState(MinerState.Running);
				}
				else
				{
					this.SetState(MinerState.Initializing);
				}
			}
			else
			{
				if (this.IsInitialized)
				{
					throw new Exception(Lang.Miner_AlreadyRunning);
				}
				else
				{
					throw new Exception(Lang.Miner_NotInitialized);
				}
			}
		}

		public void StopMiner()
		{
			if (this.IsInitialized && this.XmrigProcess.HasExited == false)
			{
				this.XmrigProcess.Kill();
				this.XmrigProcess = null;

				this.SetState(MinerState.Stopped);
			}
			else
			{
				throw new Exception(Lang.Miner_AlreadyStopped);
			}
		}
		#endregion Miner Actions

		#region Miner State
		private void SetState(MinerState state)
		{
			switch (state)
			{
				case MinerState.Stopped:
					this.SetStateVariables(false, false, false);
					break;
				case MinerState.Paused:
					this.SetStateVariables(true, true, false);
					break;
				case MinerState.PausedInitializing:
					this.SetStateVariables(true, false, false);
					break;
				case MinerState.Initializing:
					this.SetStateVariables(true, false, true);
					break;
				case MinerState.Running:
					this.SetStateVariables(true, true, true);
					break;
			}

			OnMinerStateChange?.Invoke(state);
		}

		private void SetStateVariables(bool isInitialized, bool isReady, bool isRunning)
		{
			this.IsInitialized = isInitialized;
			this.IsReady = isReady;
			this.IsRunning = isRunning;
		}

		public enum MinerState
		{
			Stopped,
			Paused,
			PausedInitializing,
			Initializing,
			Running,
		}

		public MinerState GetMinerState()
		{
			if (this.IsInitialized == false)
			{
				return MinerState.Stopped;
			}
			else if (this.IsInitialized && this.IsReady == false && this.IsRunning)
			{
				return MinerState.Initializing;
			}
			else if (this.IsInitialized && this.IsReady == false && this.IsRunning == false)
			{
				return MinerState.PausedInitializing;
			}
			else if (this.IsInitialized && this.IsReady && this.IsRunning == false)
			{
				return MinerState.Paused;
			}
			else // if (this.IsInitialized && this.IsRunning)
			{
				return MinerState.Running;
			}
		}
		#endregion Miner State

		public void GetAPI()
		{
			while (true)
			{
				var request = new RestRequest(APISummary);
				request.AddHeader("Authorization", $"Bearer {GData.SettingsManager.Settings.AccessToken}");
				IRestResponse response = this.APIClient.Get(request);

				XMRigHTTPAPI xmrigApi = JsonConvert.DeserializeObject<XMRigHTTPAPI>(response.Content);

				int minerValidShares = xmrigApi.Results.SharesGood;
				int minerInvalidShares = xmrigApi.Results.SharesTotal - xmrigApi.Results.SharesGood;

				if (xmrigApi.Hashrate.Total[0] != null && this.IsRunning)
				{
					if (this.IsInitialized && this.IsRunning && this.GetMinerState() == MinerState.Initializing)
					{
						this.SetState(MinerState.Running);
					}
					OnLoggedHashRate?.Invoke((decimal)xmrigApi.Hashrate.Total[0]);
				}
				else
				{
					OnLoggedHashRate?.Invoke(0);
				}

				if (minerValidShares > this.ValidShares)
				{
					for (int i = 0; i < minerValidShares - this.ValidShares; i++)
					{
						OnValidShare?.Invoke();
					}
					this.ValidShares = minerValidShares;
				}
				if (xmrigApi.Connection.Rejected > this.InvalidShares)
				{
					for (int i = 0; i < xmrigApi.Connection.Rejected - this.InvalidShares; i++)
					{
						OnInvalidShare?.Invoke();
					}
					this.InvalidShares = xmrigApi.Connection.Rejected;
				}

				Thread.Sleep(1000);
			}
		}

		public void UpdateConfig(XMRigConfigJSON newConfig)
		{
			string json = JsonConvert.SerializeObject(newConfig);
			File.WriteAllText(this.ConfigPath, json);
		}

		private void MinerRPC(string param)
		{
			Task.Run(() =>
			{
				var request = new RestRequest(APIJsonRPC);
				request.AddHeader("Authorization", $"Bearer {GData.SettingsManager.Settings.AccessToken}");
				request.AddHeader("Content-Type", "application/json");
				request.AddJsonBody("{\"method\":\"" + param + "\",\"id\":1}");

				this.APIClient.Post(request);
			});
		}
	}
}