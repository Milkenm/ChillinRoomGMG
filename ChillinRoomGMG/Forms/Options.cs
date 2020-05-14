﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

using static ChillinRoomGMG.Enums;
using static ChillinRoomGMG.Static;
using static ChillinRoomGMG.WinAPI;

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

			MineForChillinRoomToggle(settings.MineForChillinRoom);

			pixelCheckBox_mineForChillinroom.Checked = settings.MineForChillinRoom;
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

			textBox_walletAddress.GotFocus += TextBox_walletAddress_GotFocus;

			foreach (Currency currency in Enum.GetValues(typeof(Currency)))
			{
				comboBox_currencies.Items.Add(currency);
			}
			comboBox_currencies.SelectedIndex = settings.Currency;
		}

		private void TextBox_walletAddress_GotFocus(object sender, EventArgs e)
		{
			if (pixelCheckBox_mineForChillinroom.Checked)
			{
				HideCaret(textBox_walletAddress.Handle);
			}
		}

		private void MineForChillinRoomToggle(bool mineForChillinroom)
		{
			if (mineForChillinroom)
			{
				label_walletAddress.Text = "ChillinRoom XMR wallet address";
				textBox_walletAddress.ReadOnly = true;
				textBox_walletAddress.Text = settings.ChillinRoomWalletAddress;

				label_minerName.Text = "Discord User ID";
				textBox_minerName.Text = settings.ChillinRoomMinerId.ToString();
				textBox_minerName.MaxLength = 20;

				linkLabel_theWhatLink.Visible = true;
			}
			else
			{
				label_walletAddress.Text = "XMR wallet address";
				textBox_walletAddress.ReadOnly = false;
				textBox_walletAddress.Text = settings.WalletAddress;

				label_minerName.Text = "Miner name";
				textBox_minerName.Text = settings.MinerName;
				textBox_minerName.MaxLength = 50;

				linkLabel_theWhatLink.Visible = false;
			}
		}

		private void button_save_Click(object sender, EventArgs e)
		{
			settings.MineForChillinRoom = pixelCheckBox_mineForChillinroom.Checked;
			settings.InitializeMinerOnStartup = pixelCheckBox_initializeMinerOnStartup.Checked;

			if (!pixelCheckBox_mineForChillinroom.Checked)
			{
				settings.WalletAddress = textBox_walletAddress.Text;
				settings.MinerName = textBox_minerName.Text;
			}
			else
			{
				settings.ChillinRoomMinerId = Convert.ToUInt64(textBox_minerName.Text);
			}

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

		private void pixelCheckBox_mineForChillinroom_CheckedChanged()
		{
			MineForChillinRoomToggle(pixelCheckBox_mineForChillinroom.Checked);
		}

		private void textBox_minerName_KeyDown(object sender, KeyEventArgs e)
		{
			// [CheckBox] && ![Keyboard 0-9] && ![Numpad 0-9] && ![Backspace] && ![CTRL-C|V|Z|A]
			if (pixelCheckBox_mineForChillinroom.Checked && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && e.KeyCode != Keys.Back && !(e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.Z || e.KeyCode == Keys.A)))
			{
				e.SuppressKeyPress = true;
			}
		}

		private void textBox_minerName_TextChanged(object sender, EventArgs e)
		{
			int caretPos = textBox_minerName.SelectionStart - 1;

			if (pixelCheckBox_mineForChillinroom.Checked)
			{
				int loop = 0;
				foreach (char c in textBox_minerName.Text)
				{
					if (!char.IsDigit(c))
					{
						textBox_minerName.Text = textBox_minerName.Text.Remove(loop, 1);

						if (caretPos >= 0)
						{
							textBox_minerName.SelectionStart = caretPos;
						}

						textBox_minerName.SelectionLength = 0;
					}
					loop++;
				}
			}
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