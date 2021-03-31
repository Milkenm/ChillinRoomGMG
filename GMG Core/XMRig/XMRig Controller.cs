using Newtonsoft.Json;

using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using static ScriptsLib.PInvoke.User32;

namespace GMG_Core.Xmrig
{
	public class XMRig
	{
		public delegate void ShareEvent();
		public event ShareEvent OnValidShare;
		public event ShareEvent OnInvalidShare;

		public delegate void LoggedLineEvent(string line);
		public event LoggedLineEvent OnLoggedLine;
		public delegate void LoggedHashRateEvent(decimal hashrate);
		public event LoggedHashRateEvent OnLoggedHashRate;

		public delegate void MinerStateChangeEvent(MinerState newState);
		public event MinerStateChangeEvent OnMinerStateChange;

		private IntPtr XmrigHandle { get; set; } = new IntPtr();
		private Process XmrigProcess { get; set; }

		private string MinerExePath { get; }
		private string ConfigPath { get; }

		public bool IsInitialized { get; private set; }
		public bool IsReady { get; private set; }
		public bool IsRunning { get; private set; }

		public decimal HashRate { get; private set; }
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
			this.Kill();
		}

		public void Initialize(bool run = false)
		{
			if (this.IsInitialized == false)
			{
				Process p = new Process();
				p.StartInfo.FileName = this.MinerExePath;
				p.StartInfo.Verb = "runas";
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.UseShellExecute = false;
				p.Start();

				while (this.XmrigHandle == new IntPtr())
				{
					foreach (Process process in Process.GetProcessesByName("xmrig"))
					{
						if (process.ProcessName == "xmrig" && process.MainWindowHandle != new IntPtr())
						{
							this.XmrigProcess = process;
							this.XmrigHandle = process.MainWindowHandle;

							this.SetWindowState(WindowState.Hidden);
							if (run == false)
							{
								this.SendKey(Keys.P);
							}

							break;
						}
					}
				}

				new Task(new Action(() =>
				{
					while (!p.StandardOutput.EndOfStream)
					{
						string line = p.StandardOutput.ReadLine();

						if (!string.IsNullOrEmpty(line))
						{
							this.LogLine(line);
						}
					}
				})).Start();

				if (run == false)
				{
					this.SetState(MinerState.PausedInitializing);
				}
				else
				{
					this.SetState(MinerState.Initializing);
				}
			}
		}

		public void Resume()
		{
			if (this.GetMinerState() == MinerState.Paused)
			{
				this.SendKey(Keys.R);
				this.SetState(MinerState.Running);
			}
			else if (this.GetMinerState() == MinerState.PausedInitializing)
			{
				this.SetState(MinerState.Initializing);
			}
			else if (this.GetMinerState() == MinerState.Stopped)
			{
				this.Initialize(true);
				this.SetState(MinerState.Initializing);
			}
		}

		public void Pause()
		{
			if (this.IsRunning && this.IsInitialized)
			{
				this.SetState(MinerState.Paused);
				this.SendKey(Keys.P);
			}
		}

		public void Kill()
		{
			if (this.IsInitialized && this.XmrigProcess.HasExited == false)
			{
				this.XmrigProcess.Kill();
				this.XmrigProcess = null;
				this.XmrigHandle = new IntPtr();

				this.SetState(MinerState.Stopped);
			}
		}

		public enum WindowState
		{
			Shown,
			Hidden,
		}

		public void SetWindowState(WindowState state)
		{
			if (state == WindowState.Shown)
			{
				ShowWindow(this.XmrigHandle, WindowShowStyle.ShowNoActivate);
			}
			else
			{
				ShowWindow(this.XmrigHandle, WindowShowStyle.Hide);
			}
		}

		private void LogLine(string line)
		{
			// if (Unsorted.IsDebugMode()) Console.WriteLine(line);

			if (line.Contains("accepted"))
			{
				this.ValidShares++;
				OnValidShare?.Invoke();
			}
			else if (line.Contains("rejected"))
			{
				this.InvalidShares++;
				OnInvalidShare?.Invoke();
			}
			else if (line.Contains("speed") && this.IsRunning)
			{
				string[] lineSplit = line.Split(new string[] { "10s/60s/15m " }, StringSplitOptions.None);
				lineSplit = lineSplit[1].Split(' ');

				if (lineSplit[0] != "n/a")
				{
					decimal.TryParse(lineSplit[0].Replace('.', ','), out decimal hashrate);
					this.HashRate = hashrate;
				}
				else
				{
					this.HashRate = 0;
				}

				OnLoggedHashRate?.Invoke(this.HashRate);
			}
			else if (line.Contains("READY"))
			{
				if (this.GetMinerState() == MinerState.Initializing)
				{
					this.SetState(MinerState.Running);
				}
				else if (this.GetMinerState() == MinerState.PausedInitializing)
				{
					this.SetState(MinerState.Paused);
				}
			}
			else if (!(line.Contains("configuration") || line.Contains("resumed") || line.Contains("paused")))
			{
				OnLoggedLine?.Invoke(line);
			}
		}

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

		public void UpdateConfig(XMRigConfigJSON newConfig)
		{
			string json = JsonConvert.SerializeObject(newConfig);
			File.WriteAllText(this.ConfigPath, json);
		}

		private void SendKey(Keys key)
		{
			PostMessage(this.XmrigHandle, 0x0100, (int)key, 0);
		}
	}
}