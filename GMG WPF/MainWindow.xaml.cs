using GMG_Core;
using GMG_Core.Xmrig;

using ScriptsLib.Unsorted;

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;

namespace GMG_WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly SolidColorBrush RedBrush = new SolidColorBrush(Color.FromRgb(204, 41, 0));
		private readonly SolidColorBrush YellowBrush = new SolidColorBrush(Color.FromRgb(255, 204, 0));
		private readonly SolidColorBrush GreenBrush = new SolidColorBrush(Color.FromRgb(0, 153, 51));

		private readonly string HashRateLabelPlaceholder = "{0} H/s";
		private readonly string ValidSharesLabelPlaceholder = "Valid Shares: {0}";
		private readonly string InvalidSharesLabelPlaceholder = "Invalid Shares: {0}";
		private readonly string XmrEarningsLabelPlaceholder = "Pending Balance: {0} XMR";

		private readonly DispatcherTimer Timer_Timings = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 1, 0) };
		private readonly DispatcherTimer Timer_ApiUpdate = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 1, 0, 0), IsEnabled = true };

		private CalculatorWindow CalculatorWindow = null;
		private StatisticsWindow StatisticsWindow = null;
		private SettingsWindow SettingsWindow = null;

		private SupportXmrAPI SupportXmrAPI;
		private readonly InputInactivity InputInactivity = new InputInactivity();
		private readonly NotifyIcon NotifyIcon = new NotifyIcon();

		private int StartingValidSharesCount = 0;
		private int SessionValidSharesCount = 0;
		private int StartingInvalidSharesCount = 0;
		private int SessionInvalidSharesCount = 0;

		private int AfkMiningValidShares = 0;
		private int AfkMiningInvalidShares = 0;

		private bool IsClosing = false;
		private bool IsAfkMining = false;

		private long SessionMiningSeconds = 0;

		public MainWindow(bool startMinimized)
		{
			this.InitializeComponent();

			if (startMinimized == false)
			{
				this.Show();
			}
			else
			{
				this.Window_Loaded(null, null);
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			FixWindow.Fix(this, 400, 280);

			this.SetupTrayIcon();

			GData.SettingsManager.LoadXmrigSettings(SettingsManager.XmrigSettings.NormalMining);

			GData.XMRig.OnLoggedHashRate += this.XMRig_OnLoggedHashRate;
			GData.XMRig.OnInvalidShare += this.XMRig_OnInvalidShare;
			GData.XMRig.OnValidShare += this.XMRig_OnValidShare;
			GData.XMRig.OnMinerStateChange += this.XMRig_OnMinerStateChange;
			if (GData.SettingsManager.Settings.RunOnAppStart)
			{
				GData.XMRig.Initialize();
			}

			this.SetControlStates();
			progressBar_mining.Value = progressBar_mining.Maximum;

			this.RefreshApi();
			if (SupportXmrAPI != null)
			{
				StartingValidSharesCount = SupportXmrAPI.GetAddressStats().ValidShares;
				StartingInvalidSharesCount = SupportXmrAPI.GetAddressStats().InvalidShares;
				this.UpdateValidSharesTextBlock();
				this.UpdateInvalidSharesTextBlock();
			}

			Timer_Timings.Tick += this.Timer_Timings_Tick;
			Timer_ApiUpdate.Tick += this.Timer_ApiUpdate_Tick;
			this.Timer_ApiUpdate_Tick(null, null);

			textBlock_withdrawLink.Visibility = Visibility.Hidden;

			InputInactivity.InactivityTimeReached += this.InputInactivity_InactivityTimeReached;
			InputInactivity.InputReceived += this.InputInactivity_InputReceived;
			this.SetInputInactivityDelay();

			NotifyIcon.Icon = new System.Drawing.Icon("GMG_Icon.ico");
			NotifyIcon.Visible = true;
		}

		private void Timer_Timings_Tick(object sender, EventArgs e)
		{
			SessionMiningSeconds++;

			GData.SettingsManager.Settings.Statistics.TotalMinedSeconds++;
			if (SessionMiningSeconds > GData.SettingsManager.Settings.Statistics.RecordMinedSeconds)
			{
				GData.SettingsManager.Settings.Statistics.RecordMinedSeconds = SessionMiningSeconds;
			}
		}

		private void Timer_ApiUpdate_Tick(object sender, EventArgs e)
		{
			this.RefreshApi();
			if (SupportXmrAPI != null)
			{
				AddressStats stats = SupportXmrAPI.GetAddressStats();
				this.Dispatcher.Invoke(() =>
				{
					if (stats.AmountDue >= 0.01m)
					{
						textBlock_withdrawLink.Visibility = Visibility.Visible;
					}
					textBlock_xmrEarnings.Text = string.Format(XmrEarningsLabelPlaceholder, stats.AmountDue);
				});
			}
		}

		private void RefreshApi()
		{
			if (string.IsNullOrEmpty(GData.SettingsManager.Settings.XmrigConfig.Pools[0].User) == false)
			{
				SupportXmrAPI = new SupportXmrAPI(GData.SettingsManager.Settings.XmrigConfig.Pools[0].User);
			}
		}

		private void InputInactivity_InactivityTimeReached()
		{
			if (GData.SettingsManager.Settings.AfkMiningEnabled)
			{
				if (GData.XMRig.GetMinerState() == XMRig.MinerState.Paused || GData.XMRig.GetMinerState() == XMRig.MinerState.Stopped)
				{
					IsAfkMining = true;
					GData.SettingsManager.LoadXmrigSettings(SettingsManager.XmrigSettings.AfkMining);
					this.ToggleMinerState();
					this.ToggleTrayIcon();
				}
			}
		}

		private void InputInactivity_InputReceived()
		{
			if (IsAfkMining)
			{
				IsAfkMining = false;
				this.ToggleMinerState();
				this.ToggleTrayIcon();

				AfkMiningValidShares = 0;
				AfkMiningInvalidShares = 0;
			}
		}

		private void ToggleTrayIcon()
		{
			if (IsAfkMining)
			{
				NotifyIcon.ShowBalloonTip(5000, "AFK Miner Started", "AFK mining has started.", ToolTipIcon.None);
			}
			else
			{
				NotifyIcon.ShowBalloonTip(5000, "AFK Miner Stopped", $"Total Shares: {AfkMiningValidShares} Valid Shares and {AfkMiningInvalidShares} Invalid Shares", ToolTipIcon.None);
			}
		}

		private void XMRig_OnLoggedHashRate(decimal hashrate)
		{
			this.SetLabelHashRate(hashrate);
		}

		private void XMRig_OnValidShare()
		{
			SessionValidSharesCount++;
			GData.SettingsManager.Settings.Statistics.TotalValidShares++;
			this.UpdateValidSharesTextBlock();
			if (SessionValidSharesCount % GData.SettingsManager.Settings.ValidSharesAmountForNotification == 0 && GData.SettingsManager.Settings.DesktopNotificationOnValidShare)
			{
				NotifyIcon.ShowBalloonTip(5000, $"+{GData.SettingsManager.Settings.ValidSharesAmountForNotification} Valid Shares", $"Total: {SessionValidSharesCount}", ToolTipIcon.None);
			}
			if (IsAfkMining)
			{
				AfkMiningValidShares++;
			}
		}

		private void UpdateValidSharesTextBlock()
		{
			this.Dispatcher.Invoke(() =>
			{
				string totalValidShares = NumberFormating.ThousandsSeparator(StartingValidSharesCount + SessionValidSharesCount);
				string sessionValidShares = NumberFormating.ThousandsSeparator(SessionValidSharesCount);
				textBlock_validShares.Text = string.Format(ValidSharesLabelPlaceholder, sessionValidShares);
				textBlock_totalValidShares.Text = totalValidShares;
			});
		}

		private void XMRig_OnInvalidShare()
		{
			SessionInvalidSharesCount++;
			GData.SettingsManager.Settings.Statistics.TotalInvalidShares++;
			this.UpdateInvalidSharesTextBlock();
			if (SessionInvalidSharesCount % GData.SettingsManager.Settings.InvalidSharesAmountForNotification == 0 && GData.SettingsManager.Settings.DesktopNotificationOnInvalidShare)
			{
				NotifyIcon.ShowBalloonTip(5000, $"+{GData.SettingsManager.Settings.InvalidSharesAmountForNotification} Invalid Shares", $"Total: {SessionInvalidSharesCount}", ToolTipIcon.None);
			}
			if (IsAfkMining)
			{
				AfkMiningInvalidShares++;
			}
		}

		private void UpdateInvalidSharesTextBlock()
		{
			this.Dispatcher.Invoke(() =>
			{
				string totalInvalidShares = NumberFormating.ThousandsSeparator(StartingInvalidSharesCount + SessionInvalidSharesCount);
				string sessionInvalidShares = NumberFormating.ThousandsSeparator(SessionInvalidSharesCount);
				textBlock_invalidShares.Text = string.Format(InvalidSharesLabelPlaceholder, sessionInvalidShares);
				textBlock_totalInvalidShares.Text = totalInvalidShares;
			});
		}

		private void XMRig_OnMinerStateChange(XMRig.MinerState newState)
		{
			if (newState == XMRig.MinerState.Running)
			{
				Timer_Timings.Start();
			}
			else
			{
				Timer_Timings.Stop();
			}
			this.SetControlStates();
		}

		private void SetLabelHashRate(decimal hashrate)
		{
			this.Dispatcher.Invoke(() =>
			{
				if (hashrate > GData.SettingsManager.Settings.Statistics.RecordHashRate)
				{
					GData.SettingsManager.Settings.Statistics.RecordHashRate = hashrate;
				}
				textBlock_hashrate.Text = string.Format(HashRateLabelPlaceholder, NumberFormating.ThousandsSeparator(Math.Round(hashrate, 0, MidpointRounding.ToEven)));
			});
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (GData.XMRig.GetMinerState() == XMRig.MinerState.Stopped || GData.XMRig.GetMinerState() == XMRig.MinerState.Paused || GData.XMRig.GetMinerState() == XMRig.MinerState.PausedInitializing)
			{
				GData.SettingsManager.LoadXmrigSettings(SettingsManager.XmrigSettings.NormalMining);
			}
			this.ToggleMinerState();
		}

		private void ToggleMinerState()
		{
			XMRig.MinerState newState = this.ToggleMinerState(GData.SettingsManager.Settings.StopInsteadOfPause);
			if (newState != XMRig.MinerState.Running)
			{
				textBlock_hashrate.Text = string.Format(HashRateLabelPlaceholder, 0);
			}
		}

		public XMRig.MinerState ToggleMinerState(bool stopInsteadOfPause)
		{
			switch (GData.XMRig.GetMinerState())
			{
				case XMRig.MinerState.Running:
					return this.StopOrPauseMiner(stopInsteadOfPause);
				case XMRig.MinerState.Initializing:
					return this.StopOrPauseMiner(stopInsteadOfPause);
				case XMRig.MinerState.PausedInitializing:
					GData.XMRig.Resume();
					return XMRig.MinerState.Running;
				case XMRig.MinerState.Paused:
					GData.XMRig.Resume();
					return XMRig.MinerState.Running;
				case XMRig.MinerState.Stopped:
					GData.XMRig.Initialize(true);
					return XMRig.MinerState.Initializing;
				default:
					return XMRig.MinerState.Stopped;
			}
		}

		private XMRig.MinerState StopOrPauseMiner(bool stopInsteadOfPause)
		{
			if (stopInsteadOfPause)
			{
				GData.XMRig.Kill();
				return XMRig.MinerState.Stopped;
			}
			else
			{
				GData.XMRig.Pause();

				if (GData.XMRig.GetMinerState() == XMRig.MinerState.Initializing)
				{
					return XMRig.MinerState.PausedInitializing;
				}
				else
				{
					return XMRig.MinerState.Paused;
				}
			}
		}

		private void SetControlStates()
		{
			if (IsClosing == false)
			{
				this.SetProgressBarState();
				this.SetButtonState();
				this.SetLabelState();
			}
		}

		private void SetProgressBarState()
		{
			SolidColorBrush brush = default;
			bool indeterminate = false;

			switch (GData.XMRig.GetMinerState())
			{
				case XMRig.MinerState.Stopped:
					brush = RedBrush;
					break;
				case XMRig.MinerState.Initializing:
					brush = GreenBrush;
					indeterminate = true;
					break;
				case XMRig.MinerState.PausedInitializing:
					brush = YellowBrush;
					indeterminate = true;
					break;
				case XMRig.MinerState.Paused:
					brush = YellowBrush;
					break;
				case XMRig.MinerState.Running:
					brush = GreenBrush;
					break;
			}

			this.Dispatcher.Invoke(() =>
			{
				progressBar_mining.Foreground = brush;
				progressBar_mining.IsIndeterminate = indeterminate;
			});
		}

		private void SetButtonState()
		{
			SolidColorBrush borderBrush = default;
			string buttonText = default;

			switch (GData.XMRig.GetMinerState())
			{
				case XMRig.MinerState.Stopped:
					buttonText = "Mine";
					borderBrush = RedBrush;
					break;
				case XMRig.MinerState.Initializing:
					buttonText = this.GetMineButtonRunningText();
					borderBrush = GreenBrush;
					break;
				case XMRig.MinerState.PausedInitializing:
					buttonText = this.GetMineButtonRunningText();
					borderBrush = YellowBrush;
					break;
				case XMRig.MinerState.Paused:
					buttonText = "Resume";
					borderBrush = YellowBrush;
					break;
				case XMRig.MinerState.Running:
					buttonText = this.GetMineButtonRunningText();
					borderBrush = GreenBrush;
					break;
			}

			this.Dispatcher.Invoke(() =>
			{
				button_mine.BorderBrush = borderBrush;
				button_mine.Content = buttonText;
			});
		}

		private string GetMineButtonRunningText()
		{
			if (GData.SettingsManager.Settings.StopInsteadOfPause)
			{
				return "Stop";
			}
			else
			{
				return "Pause";
			}
		}

		private void SetLabelState()
		{
			SolidColorBrush colorBrush = default;
			string text = GData.XMRig.GetMinerState().ToString();

			switch (GData.XMRig.GetMinerState())
			{
				case XMRig.MinerState.Stopped:
					colorBrush = RedBrush;
					break;
				case XMRig.MinerState.Initializing:
					colorBrush = GreenBrush;
					break;
				case XMRig.MinerState.PausedInitializing:
					colorBrush = YellowBrush;
					text = "Initializing (Paused)";
					break;
				case XMRig.MinerState.Paused:
					colorBrush = YellowBrush;
					break;
				case XMRig.MinerState.Running:
					colorBrush = GreenBrush;
					break;
			}

			this.Dispatcher.Invoke(() =>
			{
				textBlock_minerState.Foreground = colorBrush;
				textBlock_minerState.Text = text;
			});
		}

		private void textBlock_settingsLink_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.OpenSettingsWindow();
		}

		private void OpenSettingsWindow()
		{
			if (SettingsWindow == null)
			{
				SettingsWindow = new SettingsWindow();
				SettingsWindow.Closed += new EventHandler((_s, _e) =>
				{
					this.SetInputInactivityDelay();
					this.Dispatcher.Invoke(() =>
					{
						button_mine.Content = this.GetMineButtonRunningText();
					});

					if (IsAfkMining && GData.SettingsManager.Settings.XmrigConfig.CPU.RX != GData.SettingsManager.Settings.AfkMiningCores.ToArray())
					{
						AssignNewCores.Assign(GData.SettingsManager.Settings.AfkMiningCores.ToArray());
					}
					else if (GData.SettingsManager.Settings.XmrigConfig.CPU.RX != GData.SettingsManager.Settings.MiningCores.ToArray())
					{
						AssignNewCores.Assign(GData.SettingsManager.Settings.MiningCores.ToArray());
					}
					SettingsWindow = null;
				});
				SettingsWindow.Show();
			}
			else
			{
				this.BringWindowToFront(SettingsWindow);
			}
		}

		private void textBlock_statisticsLink_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.OpenStatisticsWindow();
		}

		private void OpenStatisticsWindow()
		{
			if (StatisticsWindow == null)
			{
				StatisticsWindow = new StatisticsWindow();
				StatisticsWindow.Closed += new EventHandler((_s, _e) => StatisticsWindow = null);
				StatisticsWindow.Show();
			}
			else
			{
				this.BringWindowToFront(StatisticsWindow);
			}
		}

		private void textBlock_calculatorLink_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.OpenCalculatorWindow();
		}

		private void OpenCalculatorWindow()
		{
			if (CalculatorWindow == null)
			{
				CalculatorWindow = new CalculatorWindow();
				CalculatorWindow.Closed += new EventHandler((_s, _e) => CalculatorWindow = null);
				CalculatorWindow.Show();
			}
			else
			{
				this.BringWindowToFront(CalculatorWindow);
			}
		}

		private void BringWindowToFront(Window window)
		{
			if (window.IsVisible == false)
			{
				window.Show();
			}
			if (window.WindowState == WindowState.Minimized)
			{
				window.WindowState = WindowState.Normal;
			}
			window.Activate();
		}

		private void SetInputInactivityDelay()
		{
			int multiplier = 0;
			switch (GData.SettingsManager.Settings.AfkMiningTimeUnit)
			{
				case Enums.TimeUnit.Second:
					multiplier = 1000;
					break;
				case Enums.TimeUnit.Minute:
					multiplier = 60000;
					break;
				case Enums.TimeUnit.Hour:
					multiplier = 3600000;
					break;
			}

			long delay = GData.SettingsManager.Settings.AfkMiningDelay * multiplier;
			InputInactivity.SetDelay(delay);
		}

		private void Window_StateChanged(object sender, EventArgs e)
		{
			if (this.WindowState == WindowState.Maximized)
			{
				this.WindowState = WindowState.Normal;
			}
			else if (this.WindowState == WindowState.Minimized)
			{
				if (GData.SettingsManager.Settings.MinimizeToTray)
				{
					this.Hide();
				}
			}
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			bool preventClose = GData.SettingsManager.Settings.CloseToTray;
			if (preventClose)
			{
				e.Cancel = true;
				this.Hide();
			}
			else
			{
				this.AppClose();
			}
		}

		private void textBlock_withdrawLink_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			Process.Start("https://supportxmr.com/");
		}

		private void SetupTrayIcon()
		{
			NotifyIcon.Text = "Chillin'Room GMG";
			NotifyIcon.Icon = Properties.Resources.GMG_Icon;
			NotifyIcon.Visible = true;

			ContextMenu menu = new ContextMenu();
			menu.MenuItems.Add(new MenuItem() { Text = "Miner", DefaultItem = true, });
			menu.MenuItems.Add("-");
			menu.MenuItems.Add("Calculator", (s, e) => this.OpenCalculatorWindow());
			menu.MenuItems.Add("Statistics", (s, e) => this.OpenStatisticsWindow());
			menu.MenuItems.Add("Options", (s, e) => this.OpenSettingsWindow());
			menu.MenuItems.Add("-");
			menu.MenuItems.Add("Close", (s, e) => this.AppClose());

			NotifyIcon.ContextMenu = menu;

			NotifyIcon.Click += (s, e) => this.BringWindowToFront(this);
			NotifyIcon.DoubleClick += (s, e) => this.BringWindowToFront(this);
		}

		private void AppClose()
		{
			this.BringWindowToFront(this);
			GData.SettingsManager.SaveSettings();
			IsClosing = true;
			NotifyIcon.Visible = false;
			GData.XMRig.Kill();
			Environment.Exit(0);
		}
	}
}
