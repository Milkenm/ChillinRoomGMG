using GMG_Core;
using GMG_Core.APIs;
using GMG_Core.Utils;

using GMG_WPF.Utils;

using System;
using System.Windows;
using System.Windows.Threading;

namespace GMG_WPF
{
	/// <summary>
	/// Interaction logic for StatisticsWindow.xaml
	/// </summary>
	public partial class StatisticsWindow : Window
	{
		private readonly string TotalMiningTimeLabelPlaceholder = "{0} day{1} {2}h:{3}m:{4}s";
		private readonly string RecordMiningTimeLabelPlaceholder = "{0} day{1} {2}h:{3}m:{4}s";
		private readonly string TotalValidSharesLabelPlaceholder = "{0} share{1}";
		private readonly string TotalInvalidSharesLabelPlaceholder = "{0} share{1}";
		private readonly string RecordHashrateLabelPlaceholder = "{0} H/s";
		private readonly string TotalHashesLabelPlaceholder = "{0} hash{1}";
		private readonly string TotalXmrPaidLabelPlaceholder = "{0} XMR";
		private readonly string XmrPriceLabelPlaceholder = "{0} {1}";

		private readonly DispatcherTimer Timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 1, 0), IsEnabled = true };

		private readonly SupportXmrAPI SupportXmrAPI = new SupportXmrAPI(GData.SettingsManager.Settings.XmrigConfig.Pools[0].User);
		private AddressStats AddressStats;

		public StatisticsWindow()
		{
			this.InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			WindowUtils.FixWindow(this);

			AddressStats = SupportXmrAPI.GetAddressStats();
			Timer.Tick += this.Timer_Tick;
			this.UpdateLabels();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			this.UpdateMiningTimes();
		}

		private void button_close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void UpdateLabels()
		{
			this.UpdateMiningTimes();
			textBlock_totalValidShares.Text = string.Format(TotalValidSharesLabelPlaceholder, NumberFormating.AbbreviateNumber(AddressStats.ValidShares), this.GetPlural(AddressStats.ValidShares));
			textBlock_totalInvalidShares.Text = string.Format(TotalInvalidSharesLabelPlaceholder, NumberFormating.AbbreviateNumber(AddressStats.InvalidShares), this.GetPlural(AddressStats.InvalidShares));
			textBlock_recordHashrate.Text = string.Format(RecordHashrateLabelPlaceholder, string.Format(RecordHashrateLabelPlaceholder, NumberFormating.AbbreviateNumber(GData.SettingsManager.Settings.Statistics.RecordHashRate, true, true)));
			textBlock_totalHashes.Text = string.Format(TotalHashesLabelPlaceholder, NumberFormating.AbbreviateNumber(AddressStats.TotalHashes), this.GetPlural(AddressStats.TotalHashes, true));
			textBlock_totalXmrPaid.Text = string.Format(TotalXmrPaidLabelPlaceholder, AddressStats.AmountPaid / 12);
			textBlock_xmrPrice.Text = string.Format(XmrPriceLabelPlaceholder, this.GetCurrencyChar(), XMR.GetPrice().ToString("0.00"));
		}

		private void UpdateMiningTimes()
		{
			Tuple<long, long, long, long> totalMiningTime = this.ConvertSecondsToDate(GData.SettingsManager.Settings.Statistics.TotalMinedSeconds);
			Tuple<long, long, long, long> recordMiningTime = this.ConvertSecondsToDate(GData.SettingsManager.Settings.Statistics.RecordMinedSeconds);

			textBlock_totalMiningTime.Text = string.Format(TotalMiningTimeLabelPlaceholder, totalMiningTime.Item1.ToString(), this.GetPlural(0), totalMiningTime.Item2.ToString("00"), totalMiningTime.Item3.ToString("00"), totalMiningTime.Item4.ToString("00"));
			textBlock_recordMiningTime.Text = string.Format(RecordMiningTimeLabelPlaceholder, recordMiningTime.Item1.ToString(), this.GetPlural(0), recordMiningTime.Item2.ToString("00"), recordMiningTime.Item3.ToString("00"), recordMiningTime.Item4.ToString("00"));
		}

		private string GetPlural(long amount, bool addE = false)
		{
			string plural = "";
			if (amount != 1 && amount != -1)
			{
				if (addE == false)
				{
					plural = "s";
				}
				else
				{
					plural = "es";
				}
			}
			return plural;
		}

		private char GetCurrencyChar()
		{
			if (GData.SettingsManager.Settings.Currency == CryptonatorAPI.Currency.EUR)
			{
				return '€';
			}
			else
			{
				return '$';
			}
		}

		private Tuple<long, long, long, long> ConvertSecondsToDate(long totalSeconds)
		{
			long days = totalSeconds / 60 / 60 / 24;
			long hours = (totalSeconds / 60 / 60) - (days * 24);
			long minutes = (totalSeconds / 60) - ((hours + (days * 24)) * 60);
			long seconds = totalSeconds - ((minutes + ((hours + (days * 24)) * 60)) * 60);

			return new Tuple<long, long, long, long>(days, hours, minutes, seconds);
		}
	}
}
