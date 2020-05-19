using ChillinRoomGMG.Properties;

using Newtonsoft.Json;

using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static ChillinRoomGMG.Code;
using static ChillinRoomGMG.Enums;
using static ChillinRoomGMG.Static;

using static ScriptsLib.Network.Requests;

namespace ChillinRoomGMG.Forms
{
	public partial class Miner : Form
	{
		internal long totalMinedSeconds = settings.TotalMinedSeconds;
		internal decimal recordHashRate = settings.RecordHashRate;
		internal long totalValidShares = settings.TotalValidShares;
		internal long totalInvalidShares = settings.TotalInvalidShares;
		internal long sessionValidSharesRecord = settings.SessionValidSharesRecord;
		internal DateTime sessionValidSharesRecordDate = settings.SessionValidSharesRecordDate;
		internal long sessionInvalidSharesRecord = settings.SessionInvalidSharesRecord;
		internal DateTime sessionInvalidSharesRecordDate = settings.SessionInvalidSharesRecordDate;
		internal DateTime recordHashRateDate = settings.HashRateRecordDate;
		internal long longestTimeMining = settings.LongestTimeMining;
		internal DateTime longestTimeMiningDate = settings.LongestTimeMiningDate;

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
			}

			xmrig.ValidShare += () => UpdateShares(true);
			xmrig.InvalidShare += () => UpdateShares(false);
			xmrig.LoggedLine += Xmrig_LoggedLine;

			InitClickEvent(Controls);

			inactivity = new InputInactivity();
			inactivity.InactivityTimeReached += Inactivity_InactivityTimeReached;
			inactivity.InputReceived += Inactivity_InputReceived;

			LoadConfig();
		}

		internal string GetCurrenyString()
		{
			return ((Currency)settings.Currency).ToString();
		}

		internal void RefreshXmrValue()
		{
			new Task(new Action(() =>
			{
				string request = GET("https://api.cryptonator.com/api/ticker/xmr-" + GetCurrenyString().ToLower());
				XmrRequest response = JsonConvert.DeserializeObject<XmrRequest>(request);

				if (response != latestXmrRequest)
				{
					latestXmrRequest = response;

					Invoke(new Action(() => label_xmrValue.Refresh()));
				}
			})).Start();
		}

		internal XmrRequest latestXmrRequest;

		public class XmrRequest
		{
			public Ticker ticker;
			public bool success;
		}

		public class Ticker
		{
			public string price;
			public string volume;
			public string change;
		}

		public void LoadConfig()
		{
			RefreshXmrValue();

			if (settings.WalletAddress == null)
			{
				new Message("Wallet address cannot be empty, please check the configs.", false);
			}
			else if (settings.MinerName == null)
			{
				new Message("Miner name cannot be empty, please check the configs.", false);
			}
			else
			{
				string defaultConfigFile = tempPath + "XMRigConfig.json";

				if (!Directory.Exists(tempPath))
				{
					Directory.CreateDirectory(tempPath);
				}

				byte[] resFile = Resources.XMRigConfig_JSON;
				File.WriteAllBytes(defaultConfigFile, resFile);

				StringBuilder sb = new StringBuilder();
				foreach (string line in File.ReadAllLines(defaultConfigFile))
				{
					if (line.Contains("{WALLET_ADDRESS}"))
					{
						sb.AppendLine(line.Replace("{WALLET_ADDRESS}", settings.WalletAddress));
					}
					else if (line.Contains("{MINER_NAME}"))
					{
						sb.AppendLine(line.Replace("{MINER_NAME}", settings.MinerName));
					}
					else
					{
						sb.AppendLine(line);
					}
				}
				File.WriteAllText(xmrigPath + "config.json", sb.ToString());
			}

			validSettings = true;
			if (string.IsNullOrEmpty(settings.WalletAddress) || string.IsNullOrEmpty(settings.MinerName))
			{
				new Message("Configs for 'Wallet Address' and/or 'Miner name' are not valid. Change those values on the options menu.", false).ShowDialog();
				validSettings = false;
			}
			button_mine.Enabled = validSettings;

			inactivity.MsDelay = settings.AutoMineDelay * (settings.AutoMineTimeUnit == 0 ? 1000 : settings.AutoMineTimeUnit == 1 ? 60000 : 3600000);
		}

		private void Xmrig_LoggedLine(string line)
		{
			if (line.Contains("speed"))
			{
				if (xmrig.IsRunning)
				{
					string[] hashRates = line.Remove(0, 44).Replace(" H/s", "").Replace(" max", "").Replace("n/a", "0.0").Split(' ');

					if (Convert.ToDecimal(hashRates[3].Replace(".", ",")) > recordHashRate)
					{
						recordHashRate = Convert.ToDecimal(hashRates[3].Replace(".", ","));
						recordHashRateDate = DateTime.Now;
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

		internal static int validShares;
		internal static int invalidShares;

		private void UpdateShares(bool valid)
		{
			if (valid)
			{
				totalValidShares++;
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

				if (validShares > sessionValidSharesRecord)
				{
					sessionValidSharesRecord = validShares;
					sessionValidSharesRecordDate = DateTime.Now;
				}

				if (settings.NotificationValidShare && SendNotification() && validShares % settings.ValidShareNotificationCount == 0)
				{
					trayIcon.ShowBalloonTip(0, $"Valid share [x{settings.ValidShareNotificationCount}]", $"Total: {validShares} valid shares", ToolTipIcon.Info);
				}
			}
			else
			{
				totalInvalidShares++;
				invalidShares++;

				if (invalidShares > sessionInvalidSharesRecord)
				{
					sessionInvalidSharesRecord = invalidShares;
					sessionInvalidSharesRecordDate = DateTime.Now;
				}

				if (settings.NotificationInvalidShare && SendNotification() && invalidShares % settings.InvalidShareNotificationCount == 0)
				{
					trayIcon.ShowBalloonTip(0, $"Invalid share [x{settings.InvalidShareNotificationCount}]", $"Total: { invalidShares} invalid shares", ToolTipIcon.Info);
				}
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
				button_mine.Enabled = false;
				button_mine.Text = "AUTO MINING";

				inactivityEnabled = true;
				Mine();

				if (settings.NotificationAutoStart && SendNotification())
				{
					trayIcon.ShowBalloonTip(0, "Automatic mining started.", "Automatic mining has started due to system inactivity.", ToolTipIcon.Info);
				}
			}
		}

		private void Inactivity_InputReceived()
		{
			if (inactivityEnabled)
			{
				button_mine.Enabled = true;
				button_mine.Text = "START MINING";

				inactivityEnabled = false;
				Mine();

				if (settings.NotificationAutoStop && SendNotification())
				{
					trayIcon.ShowBalloonTip(0, "Mining stopped.", "Automatic mining has stopped.", ToolTipIcon.Info);
				}
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

		private void SetLastShareText(int seconds)
		{
			label_lastValid.Text = $"Last valid : {seconds} s ago";
		}

		private void button_mine_Click(object sender, EventArgs e)
		{
			Mine();
		}

		internal void Mine()
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

		private void button_statistics_Click(object sender, EventArgs e)
		{
			if (statisticsForm == null)
			{
				statisticsForm = new Statistics();
				statisticsForm.Show();
			}
			else
			{
				statisticsForm.BringToFront();
			}
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

		private void Miner_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;

			if (settings.CloseToTray)
			{
				Hide();
			}
			else
			{
				AppClose();
			}
		}

		private bool SendNotification()
		{
			return !(ContainsFocus && settings.HideNotificationsWhileFocused);
		}

		private void timer_refreshLatestShareTimer_Tick(object sender, EventArgs e)
		{
			latestValidShareTime++;

			SetLastShareText(latestValidShareTime);
		}

		private long sessionMinedSeconds;

		private void timer_miningTimeCounter_Tick(object sender, EventArgs e)
		{
			totalMinedSeconds++;
			sessionMinedSeconds++;

			if (sessionMinedSeconds > longestTimeMining)
			{
				longestTimeMining = sessionMinedSeconds;
				longestTimeMiningDate = DateTime.Now;
			}
		}

		private void timer_save_Tick(object sender, EventArgs e)
		{
			SaveSettings();
		}

		internal void SaveSettings()
		{
			settings.TotalMinedSeconds = totalMinedSeconds;
			settings.RecordHashRate = recordHashRate;
			settings.TotalValidShares = totalValidShares;
			settings.TotalInvalidShares = totalInvalidShares;
			settings.SessionValidSharesRecord = sessionValidSharesRecord;
			settings.SessionInvalidSharesRecordDate = sessionValidSharesRecordDate;
			settings.SessionInvalidSharesRecord = sessionInvalidSharesRecord;
			settings.SessionInvalidSharesRecordDate = sessionInvalidSharesRecordDate;
			settings.HashRateRecordDate = recordHashRateDate;
			settings.LongestTimeMining = longestTimeMining;
			settings.LongestTimeMiningDate = longestTimeMiningDate;

			settings.Save();
		}

		private void timer_refreshXmrPrice_Tick(object sender, EventArgs e)
		{
			RefreshXmrValue();
		}

		private void label_xmrValue_Paint(object sender, PaintEventArgs e)
		{
			if (latestXmrRequest != null)
			{
				decimal change = Math.Round(Convert.ToDecimal(latestXmrRequest.ticker.change.Replace('.', ',')), 2);
				bool negative = change < 0;
				string changeString = ((!negative ? "+" : null) + change).Replace(',', '.');

				if (latestXmrRequest.success)
				{
					e.Graphics.Clear(Color.FromArgb(54, 57, 63));

					Font font = new Font("Roboto", 15.75f, FontStyle.Bold);

					SolidBrush brush = new SolidBrush(Color.Snow);
					SolidBrush changeBrush = new SolidBrush(!negative ? Color.Green : Color.Firebrick);

					string print1 = $"XMR Value: {FixAfterDot(Math.Round(Convert.ToDouble(latestXmrRequest.ticker.price.Replace('.', ',')), 2).ToString().Replace(",", "."))} {GetCurrenyString()} (";

					const int preLocFix = 2;
					const int locFix = 16 - preLocFix;

					float point2 = e.Graphics.MeasureString(print1, font).Width - locFix;
					float point3 = e.Graphics.MeasureString(print1 + changeString, font).Width - locFix;

					e.Graphics.DrawString(print1, font, brush, preLocFix, 0);
					e.Graphics.DrawString(FixAfterDot(changeString), font, changeBrush, point2, 0);
					e.Graphics.DrawString(")", font, brush, point3, 0);
				}
			}
		}

		private string FixAfterDot(string number)
		{
			string[] splitNum = number.Split('.');

			return splitNum.Length > 1 ? splitNum[1].Length == 1 ? splitNum[1] + "0" : number : splitNum[0] + ".00";
		}
	}
}

