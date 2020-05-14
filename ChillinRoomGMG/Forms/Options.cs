using System;
using System.Diagnostics;
using System.Windows.Forms;

using static ChillinRoomGMG.Enums;
using static ChillinRoomGMG.Static;

namespace ChillinRoomGMG.Forms
{
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
		}

		private void Options_Load(object sender, EventArgs e)
		{
			Version v = typeof(Options).Assembly.GetName().Version;
			label_version.Text = $"v{v.Major}.{v.Minor}.{v.Build}";

			textBox_walletAddress.Text = settings.WalletAddress;
			textBox_minerName.Text = settings.MinerName;

			pixelCheckBox_initializeMinerOnStartup.Checked = settings.InitializeMinerOnStartup;

			pixelSlider_autoMine.Slided = settings.AutoMine;
			pixelNumberPicker_minutes.Value = settings.AutoMineDelay;

			pixelCheckBox_initializeMinerOnStartup.Checked = settings.InitializeMinerOnStartup;
			pixelCheckBox_terminateOnPause.Checked = settings.KillMinerOnPause;

			pixelCheckBox_closeToTray.Checked = settings.CloseToTray;
			pixelCheckBox_minimizeToTray.Checked = settings.MinimizeToTray;

			pixelCheckBox_automineEnableNotification.Checked = settings.NotificationAutoStart;
			pixelCheckBox_automineDisableNotification.Checked = settings.NotificationAutoStop;

			pixelCheckBox_validShareNotification.Checked = settings.NotificationValidShare;
			pixelNumberPicker_validShareNotificationCount.Value = settings.ValidShareNotificationCount;
			pixelCheckBox_invalidShareNotification.Checked = settings.NotificationInvalidShare;
			pixelNumberPicker_invalidShareNotificationCount.Value = settings.InvalidShareNotificationCount;

			comboBox_timeUnit.SelectedIndex = settings.AutoMineTimeUnit;

			pixelCheckBox_hideNotifications.Checked = settings.HideNotificationsWhileFocused;

			foreach (Currency currency in Enum.GetValues(typeof(Currency)))
			{
				comboBox_currencies.Items.Add(currency);
			}
			comboBox_currencies.SelectedIndex = settings.Currency;
		}

		private void button_save_Click(object sender, EventArgs e)
		{
			settings.InitializeMinerOnStartup = pixelCheckBox_initializeMinerOnStartup.Checked;

			settings.WalletAddress = textBox_walletAddress.Text;
			settings.MinerName = textBox_minerName.Text;

			settings.InitializeMinerOnStartup = pixelCheckBox_initializeMinerOnStartup.Checked;
			settings.KillMinerOnPause = pixelCheckBox_terminateOnPause.Checked;

			settings.AutoMine = pixelSlider_autoMine.Slided;
			settings.AutoMineDelay = Convert.ToInt32(pixelNumberPicker_minutes.Value);

			settings.CloseToTray = pixelCheckBox_closeToTray.Checked;
			settings.MinimizeToTray = pixelCheckBox_minimizeToTray.Checked;

			settings.NotificationAutoStart = pixelCheckBox_automineEnableNotification.Checked;
			settings.NotificationAutoStop = pixelCheckBox_automineDisableNotification.Checked;

			settings.NotificationValidShare = pixelCheckBox_validShareNotification.Checked;
			settings.ValidShareNotificationCount = (int)pixelNumberPicker_validShareNotificationCount.Value;
			settings.NotificationInvalidShare = pixelCheckBox_invalidShareNotification.Checked;
			settings.InvalidShareNotificationCount = (int)pixelNumberPicker_invalidShareNotificationCount.Value;

			settings.AutoMineTimeUnit = comboBox_timeUnit.SelectedIndex;

			settings.HideNotificationsWhileFocused = pixelCheckBox_hideNotifications.Checked;

			settings.Currency = comboBox_currencies.SelectedIndex;

			settings.Save();

			minerForm.LoadConfig();
			Close();
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void numberPicker_minutes_ValueChanged()
		{
			int previousIndex = comboBox_timeUnit.SelectedIndex;
			bool s = pixelNumberPicker_minutes.Value != 1;

			comboBox_timeUnit.Items.Clear();

			foreach (string unit in new string[] { "second", "minute", "hour" })
			{
				comboBox_timeUnit.Items.Add(unit + (s ? "s" : null));
			}

			comboBox_timeUnit.SelectedIndex = previousIndex;
		}

		private void linkLabel_theWhatLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://support.discordapp.com/hc/en-us/articles/206346498-Where-can-I-find-my-User-Server-Message-ID-");
		}

		private void pixelNumberPicker_validShareNotificationCount_ValueChanged()
		{
			label_validShareNotification.Text = pixelNumberPicker_validShareNotificationCount.Value == 1 ? "valid share" : "valid shares";
		}

		private void pixelNumberPicker_invalidShareNotificationCount_ValueChanged()
		{
			label_invalidShareNotification.Text = pixelNumberPicker_invalidShareNotificationCount.Value == 1 ? "invalid share" : "invalid shares";
		}
	}
}