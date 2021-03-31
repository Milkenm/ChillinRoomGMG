using GMG_Core;

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

using static GMG_Core.Enums;

namespace GMG_WPF
{
	/// <summary>
	/// Interaction logic for SettingsWindow.xaml
	/// </summary>
	public partial class SettingsWindow : Window
	{
		private readonly SolidColorBrush UnselectedBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
		private readonly SolidColorBrush SelectedBrush = new SolidColorBrush(Color.FromRgb(50, 50, 50));

		private TimeUnit DelayTimeUnit;

		public SettingsWindow()
		{
			this.InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			FixWindow.Fix(this);

			this.PaintTabHeaders();
			this.LoadSettings();
		}

		private void LoadSettings()
		{
			textBox_minerName.Text = GData.SettingsManager.Settings.XmrigConfig.Pools[0].Pass;
			textBox_walletAddress.Text = GData.SettingsManager.Settings.XmrigConfig.Pools[0].User;
			for (int i = 0; i < Environment.ProcessorCount; i++)
			{
				stackPanel_miningCores.Children.Add(new CheckBox() { Content = $"Core #{i}", Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255)), IsChecked = GData.SettingsManager.Settings.MiningCores.Contains(i) });
				stackPanel_afkMiningCores.Children.Add(new CheckBox() { Content = $"Core #{i}", Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255)), IsChecked = GData.SettingsManager.Settings.AfkMiningCores.Contains(i) });
			}
			checkBox_afkMiningEnabled.IsChecked = GData.SettingsManager.Settings.AfkMiningEnabled;
			slider_timeout.Value = GData.SettingsManager.Settings.AfkMiningDelay;
			checkBox_mineOnStart.IsChecked = GData.SettingsManager.Settings.RunOnAppStart;
			checkBox_replacePauseWithStop.IsChecked = GData.SettingsManager.Settings.StopInsteadOfPause;
			checkBox_closeToTray.IsChecked = GData.SettingsManager.Settings.CloseToTray;
			checkBox_minimizeToTray.IsChecked = GData.SettingsManager.Settings.MinimizeToTray;
			checkBox_desktopNotificationOnValidShare.IsChecked = GData.SettingsManager.Settings.DesktopNotificationOnValidShare;
			checkBox_desktopNotificationOnInvalidShare.IsChecked = GData.SettingsManager.Settings.DesktopNotificationOnInvalidShare;
			textBox_amountOfValidSharesForNotification.Text = GData.SettingsManager.Settings.ValidSharesAmountForNotification.ToString();
			textBox_amountOfInvalidSharesForNotification.Text = GData.SettingsManager.Settings.InvalidSharesAmountForNotification.ToString();
			if (GData.SettingsManager.Settings.Currency == XMR.Currency.EUR)
			{
				radioButton_eur.IsChecked = true;
			}
			else
			{
				radioButton_usd.IsChecked = true;
			}

			this.ChangeTimeUnit(GData.SettingsManager.Settings.AfkMiningTimeUnit);
		}

		private void SaveSettings()
		{
			GData.SettingsManager.Settings.XmrigConfig.Pools[0].Pass = textBox_minerName.Text;
			GData.SettingsManager.Settings.XmrigConfig.Pools[0].User = textBox_walletAddress.Text;
			GData.SettingsManager.Settings.MiningCores = this.GetMiningCores();
			GData.SettingsManager.Settings.AfkMiningCores = this.GetAfkMiningCores();
			GData.SettingsManager.Settings.AfkMiningEnabled = Convert.ToBoolean(checkBox_afkMiningEnabled.IsChecked);
			GData.SettingsManager.Settings.AfkMiningTimeUnit = DelayTimeUnit;
			GData.SettingsManager.Settings.AfkMiningDelay = Convert.ToInt32(slider_timeout.Value);
			GData.SettingsManager.Settings.RunOnAppStart = Convert.ToBoolean(checkBox_mineOnStart.IsChecked);
			GData.SettingsManager.Settings.StopInsteadOfPause = Convert.ToBoolean(checkBox_replacePauseWithStop.IsChecked);
			GData.SettingsManager.Settings.CloseToTray = (bool)checkBox_closeToTray.IsChecked;
			GData.SettingsManager.Settings.MinimizeToTray = (bool)checkBox_minimizeToTray.IsChecked;
			GData.SettingsManager.Settings.DesktopNotificationOnValidShare = Convert.ToBoolean(checkBox_desktopNotificationOnValidShare.IsChecked);
			GData.SettingsManager.Settings.DesktopNotificationOnInvalidShare = Convert.ToBoolean(checkBox_desktopNotificationOnInvalidShare.IsChecked);
			GData.SettingsManager.Settings.ValidSharesAmountForNotification = Convert.ToInt32(textBox_amountOfValidSharesForNotification.Text);
			GData.SettingsManager.Settings.InvalidSharesAmountForNotification = Convert.ToInt32(textBox_amountOfInvalidSharesForNotification.Text);
			if (Convert.ToBoolean(radioButton_eur.IsChecked))
			{
				GData.SettingsManager.Settings.Currency = XMR.Currency.EUR;
			}
			else
			{
				GData.SettingsManager.Settings.Currency = XMR.Currency.USD;
			}

			GData.SettingsManager.SaveSettings();
		}

		private void button_save_Click(object sender, RoutedEventArgs e)
		{
			this.SaveSettings();
			this.Close();
		}

		private List<int> GetMiningCores()
		{
			List<int> cores = new List<int>();
			foreach (CheckBox cb in stackPanel_miningCores.Children)
			{
				if (Convert.ToBoolean(cb.IsChecked))
				{
					int core = Convert.ToInt32(cb.Content.ToString().Replace("Core #", ""));
					cores.Add(core);
				}
			}
			if (cores.Count == 0)
			{
				cores.Add(0);
			}
			return cores;
		}

		private List<int> GetAfkMiningCores()
		{
			List<int> cores = new List<int>();
			foreach (CheckBox cb in stackPanel_afkMiningCores.Children)
			{
				if (Convert.ToBoolean(cb.IsChecked))
				{
					int core = Convert.ToInt32(cb.Content.ToString().Replace("Core #", ""));
					cores.Add(core);
				}
			}
			return cores;
		}

		private void TabItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			this.PaintTabHeaders();
		}

		private void PaintTabHeaders()
		{
			foreach (TabItem tab in tab_settings.Items)
			{
				if (tab.IsSelected)
				{
					tab.Foreground = SelectedBrush;
				}
				else
				{
					tab.Foreground = UnselectedBrush;
				}
			}
		}

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			this.UpdateSliderLabel();
		}

		private void UpdateSliderLabel()
		{
			int value = (int)slider_timeout.Value;

			string unit = DelayTimeUnit.ToString().ToLower();
			if (value > 1)
			{
				unit += "s";
			}

			textBlock_sliderValue.Text = value.ToString() + " ";
			textBlock_sliderUnit.Text = unit;
		}

		private void textBlock_sliderUnit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			switch (DelayTimeUnit)
			{
				case TimeUnit.Second:
					this.ChangeTimeUnit(TimeUnit.Minute);
					break;
				case TimeUnit.Minute:
					this.ChangeTimeUnit(TimeUnit.Hour);
					break;
				case TimeUnit.Hour:
					this.ChangeTimeUnit(TimeUnit.Second);
					break;
			}
		}

		private void ChangeTimeUnit(TimeUnit newTimeUnit)
		{
			DelayTimeUnit = newTimeUnit;
			this.UpdateSliderLabel();
		}

		private void textBox_amountOfSharesForNotification_TextChanged(object sender, TextChangedEventArgs e)
		{
			TextBoxRemoveNumbers.RemoveNumbers((TextBox)sender);
		}
	}
}
