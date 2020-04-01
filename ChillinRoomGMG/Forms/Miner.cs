using ChillinRoomGMG.Properties;

using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using static ChillinRoomGMG.Code;
using static ChillinRoomGMG.Static;

namespace ChillinRoomGMG.Forms
{
	public partial class Miner : Form
	{
		private static bool inactivityEnabled;
		private static bool validSettings;

		// INITIALIZE
		public Miner()
		{
			InitializeComponent();
		}

		// LOAD THE MINER AND DISCORD ID LABEL
		private void Main_Load(object sender, EventArgs e)
		{
			if (xmrig == null)
			{
				xmrig = new XMRig(xmrigPath + "xmrig.exe");
				if (settings.InitializeMinerOnStartup)
				{
					xmrig.Initialize();
				}

				if (settings.AutoMine)
				{
					Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
				}
				inactivity = new InputInactivity(settings.AutoMineDelay * 1000);
				inactivity.InactivityTimeReached += Inactivity_InactivityTimeReached;
				inactivity.InputReceived += Inactivity_InputReceived;
			}

			xmrig.ValidShare += () => UpdateShares(true);
			xmrig.InvalidShare += () => UpdateShares(false);
			xmrig.LoggedLine += Xmrig_LoggedLine;

			InitClickEvent(Controls);

			LoadConfig();
		}

		public void LoadConfig()
		{
			if (settings.WalletAddres == null)
			{
				new Message("Wallet address cannot be empty, please check the configs.", false);
			}
			else if (settings.MineForChillinRoom && settings.ChillinRoomMinerId == 0)
			{
				new Message("Discord ID cannot be empty, please check the configs.", false);
			}
			else if (!settings.MineForChillinRoom && settings.MinerName == null)
			{
				new Message("Miner name cannot be empty, please check the configs.", false);
			}
			else
			{
				label_userId.Text = settings.MineForChillinRoom ? "[DISCORD ID]: " + settings.ChillinRoomMinerId.ToString() : settings.MinerName;

				string defaultConfigFile = tempPath + "XMRigConfig.json";

				if (!Directory.Exists(tempPath))
				{
					Directory.CreateDirectory(tempPath);
				}

				byte[] resFile = Resources.XMRigConfig_JSON;
				File.WriteAllBytes(defaultConfigFile, resFile);

				string walletAddress = settings.MineForChillinRoom ? settings.ChillinRoomWalletAddress : settings.WalletAddres;
				string minerName = settings.MineForChillinRoom ? settings.ChillinRoomMinerId.ToString() : settings.MinerName;

				StringBuilder sb = new StringBuilder();
				foreach (string line in File.ReadAllLines(defaultConfigFile))
				{
					if (line.Contains("{WALLET_ADDRESS}"))
					{
						sb.AppendLine(line.Replace("{WALLET_ADDRESS}", walletAddress));
					}
					else if (line.Contains("{MINER_NAME}"))
					{
						sb.AppendLine(line.Replace("{MINER_NAME}", minerName));
					}
					else
					{
						sb.AppendLine(line);
					}
				}
				File.WriteAllText(xmrigPath + "config.json", sb.ToString());
			}

			validSettings = true;
			if (settings.MineForChillinRoom && settings.ChillinRoomMinerId == 0)
			{
				new Message("Don't forget to input your Discord User ID so your progress can be tracked!", false).ShowDialog();
				validSettings = false;
			}
			else if (!settings.MineForChillinRoom && (string.IsNullOrEmpty(settings.WalletAddres) || string.IsNullOrEmpty(settings.MinerName)))
			{
				new Message("Configs for 'Wallet Address' and/or 'Miner name' are not valid. Change those values on the options menu.", false).ShowDialog();
				validSettings = false;
			}
			button_mine.Enabled = validSettings;
		}

		private void Xmrig_LoggedLine(string line)
		{
			if (line.Contains("speed") && xmrig.IsRunning)
			{
				if (xmrig.IsRunning)
				{
					string[] hashRates = line.Remove(0, 44).Replace(" H/s", "").Replace(" max", "").Replace("n/a", "0.0").Split(' ');

					if (Convert.ToDecimal(hashRates[3].Replace(".", ",")) > settings.RecordHashRate)
					{
						settings.RecordHashRate = Convert.ToDecimal(hashRates[3].Replace(".", ","));
					}

					Invoke(new Action(() =>
					{
						label_hashRate.Text = ThousandsSeparator(hashRates[0]) + " H/s";
						label_maxHashRate.Text = "Max : " + ThousandsSeparator(hashRates[3]) + " H/s";
					}));
				}
			}
			else if (!(line.Contains("configuration") || line.Contains("resumed") || line.Contains("paused")))
			{
				Invoke(new Action(() =>
				{
					listBox_log.Items.Add(line);

					listBox_log.SelectedIndex = listBox_log.Items.Count - 1;
					listBox_log.SelectedIndex = -1;
				}));
			}
		}

		private static int validShares;
		private static int invalidShares;

		private void UpdateShares(bool valid)
		{
			if (valid)
			{
				settings.TotalValidShares++;
				validShares++;

				latestValidShareTime = 0;

				Invoke(new Action(() =>
				{
					SetLastShareText(0);

					if (timer_refreshLatestShareTimer.Enabled)
					{
						timer_refreshLatestShareTimer.Stop();
					}
					timer_refreshLatestShareTimer.Start();
				}));
			}
			else
			{
				settings.TotalInvalidShares++;
				invalidShares++;
			}

			Invoke(new Action(() => label_shares.Text = $"{ThousandsSeparator(validShares)} / {ThousandsSeparator(invalidShares)}"));
		}

		private void Xmrig_ValidShare()
		{
			MessageBox.Show("valid share");
		}

		private void Xmrig_InvalidShare()
		{
			MessageBox.Show("invalid share");
		}

		private void Inactivity_InactivityTimeReached()
		{
			if (settings.AutoMine && button_mine.Text == "START MINING" && validSettings)
			{
				inactivityEnabled = true;
				button_mine.PerformClick();
				trayIcon.ShowBalloonTip(0, "Automatic mining started.", "Automatic mining has started due to system inactivity.", ToolTipIcon.Info);

				button_mine.Text = "AUTO MINING";
				button_mine.Enabled = false;
			}
		}

		private void Inactivity_InputReceived()
		{
			if (inactivityEnabled)
			{
				button_mine.Enabled = true;
				button_mine.Text = "START MINING";

				inactivityEnabled = false;
				button_mine.PerformClick();
				trayIcon.ShowBalloonTip(0, "Mining stopped.", "Automatic mining has stopped.", ToolTipIcon.Info);
			}
		}

		private void button_options_Click(object sender, EventArgs e)
		{
			new Options().ShowDialog();
		}

		private void listBox_log_Click(object sender, EventArgs e)
		{
			listBox_log.Enabled = false;
			listBox_log.Enabled = true;
		}

		private void listBox_log_KeyDown(object sender, KeyEventArgs e)
		{
			StringBuilder selection = new StringBuilder();
			foreach (string item in listBox_log.SelectedItems)
			{
				selection.AppendLine(item);
			}

			if (e.Control && e.KeyCode == Keys.C)
			{
				Clipboard.SetData(DataFormats.StringFormat, selection.ToString());
			}
		}

		private static int latestValidShareTime;

		private void timer_refreshLatestShareTimer_Tick(object sender, EventArgs e)
		{
			latestValidShareTime++;

			SetLastShareText(latestValidShareTime);
		}

		private void SetLastShareText(int seconds)
		{
			label_lastValid.Text = $"Last valid : {seconds} s ago";
		}

		private void button_mine_Click(object sender, EventArgs e)
		{
			// START THE MINER
			if (button_mine.BackColor == Color.FromArgb(74, 57, 63))
			{
				button_mine.Text = "PAUSE";
				timer_miningTimeCounter.Start();

				button_mine.BackColor = Color.FromArgb(54, 77, 63);
				listBox_log.ForeColor = Color.Azure;

				if (validShares > 0)
				{
					timer_refreshLatestShareTimer.Start();
				}

				if (xmrig.IsInitialized)
				{
					xmrig.Resume();
				}
				else
				{
					xmrig.Initialize();
					xmrig.Resume();
				}
			}
			// STOP THE MINER
			else if (button_mine.BackColor == Color.FromArgb(54, 77, 63))
			{
				button_mine.Text = "START MINING";
				button_mine.BackColor = Color.FromArgb(74, 57, 63);
				timer_miningTimeCounter.Stop();
				label_hashRate.Text = "-.- H/s";

				listBox_log.ForeColor = Color.DimGray;

				timer_refreshLatestShareTimer.Stop();

				if (settings.KillMinerOnPause)
				{
					xmrig.Kill();
				}
				else
				{
					xmrig.Pause();
				}
			}
		}

		private void timer_miningTimeCounter_Tick(object sender, EventArgs e)
		{
			settings.TotalMinedSeconds++;
		}

		private void button_statistics_Click(object sender, EventArgs e)
		{
			new Statistics().ShowDialog();
		}

		// # = #
		// https://stackoverflow.com/questions/247946/handling-a-click-for-all-controls-on-a-form
		// # = #
		private void InitClickEvent(Control.ControlCollection controls)
		{
			foreach (Control control in controls)
			{
				if (control.Name != "listBox_log")
				{
					control.MouseClick += (sender, e) => listBox_log.ClearSelected();
				}

				InitClickEvent(control.Controls);
			}
		}
	}
}