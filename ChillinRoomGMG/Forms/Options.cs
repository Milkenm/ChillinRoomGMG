using System;
using System.Diagnostics;
using System.Windows.Forms;

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

			CheckMinutePlural();

			textBox_walletAddress.GotFocus += TextBox_walletAddress_GotFocus;
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
				textBox_walletAddress.Text = settings.WalletAddres;

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
				settings.WalletAddres = textBox_walletAddress.Text;
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

			minerForm.LoadConfig();
			Close();
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void numberPicker_minutes_ValueChanged()
		{
			CheckMinutePlural();
		}

		private void CheckMinutePlural()
		{
			label_minutes.Text = pixelNumberPicker_minutes.Value == 1 ? "minute" : "minutes";
			label_minutes.Text += " of system inactivity";
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
	}
}