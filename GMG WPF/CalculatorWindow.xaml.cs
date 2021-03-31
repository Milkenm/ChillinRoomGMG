
using GMG_Core;

using System;
using System.Windows;

using static GMG_Core.MoneroInfoAPI;

namespace GMG_WPF
{
	/// <summary>
	/// Interaction logic for CalculatorWindow.xaml
	/// </summary>
	public partial class CalculatorWindow : Window
	{
		private readonly string XmrEarningsPlaceholder = "{0} XMR";
		private readonly string CurrencyEarningsPlaceholder = "{0} {1}";

		private readonly char CurrencyChar = GData.SettingsManager.Settings.Currency == XMR.Currency.EUR ? '€' : '$';
		private readonly float Pow = (float)Math.Pow(10, 12);

		private readonly MoneroInfo MoneroInfo = GetMoneroInfo();

		public CalculatorWindow()
		{
			this.InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			FixWindow.Fix(this);

			comboBox_hashrates.SelectionChanged += this.comboBox_SelectionChanged;
			comboBox_times.SelectionChanged += this.comboBox_SelectionChanged;
			textBox_hashrate.TextChanged += this.textBox_hashrate_TextChanged;

			this.SetCalculations(0, 0);
		}

		private void CalculateEarnings()
		{
			if (MoneroInfo != null)
			{
				float xmrEarnings = 0;
				switch (comboBox_times.SelectedIndex)
				{
					case 0: // Hourly
						xmrEarnings = this.GetEarnings(Times.Hourly);
						break;
					case 1: // Daily
						xmrEarnings = this.GetEarnings(Times.Daily);
						break;
					case 2: // Weekly
						xmrEarnings = this.GetEarnings(Times.Weekly);
						break;
					case 3: // Monthly
						xmrEarnings = this.GetEarnings(Times.Monthly);
						break;
					case 4: // Yearly
						xmrEarnings = this.GetEarnings(Times.Yearly);
						break;
				}

				float currencyEarnings = xmrEarnings * (float)GetXmrPrice.GetPrice();

				this.SetCalculations(xmrEarnings, currencyEarnings);
			}
		}

		private void SetCalculations(float xmrEarnings, float currencyEarnings)
		{
			textBlock_xmrEarnings.Text = string.Format(XmrEarningsPlaceholder, xmrEarnings.ToString("0.000000000000"));
			textBlock_currencyEarnings.Text = string.Format(CurrencyEarningsPlaceholder, CurrencyChar, Math.Round(currencyEarnings, 2, MidpointRounding.ToEven).ToString("0.00"));
		}

		private enum Times
		{
			Hourly,
			Daily,
			Weekly,
			Monthly,
			Yearly,
		}

		private float GetEarnings(Times t)
		{
			int hashrate = Convert.ToInt32(textBox_hashrate.Text);

			float latestBlockReward = MoneroInfo.last_reward;
			float minerHashRate = hashrate * (float)Math.Pow(10, comboBox_hashrates.SelectedIndex * 3);
			float netHashRate = (float)Math.Round(MoneroInfo.hashrate, 0);

			switch (t)
			{
				case Times.Hourly:
					return 30 * latestBlockReward / Pow * minerHashRate / netHashRate;
				case Times.Daily:
					return this.GetEarnings(Times.Hourly) * 24;
				case Times.Weekly:
					return this.GetEarnings(Times.Daily) * 7;
				case Times.Monthly:
					return this.GetEarnings(Times.Daily) * 30;
				case Times.Yearly:
					return this.GetEarnings(Times.Daily) * 365;
				default:
					return 0;
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void textBox_hashrate_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			TextBoxRemoveNumbers.RemoveNumbers(textBox_hashrate);

			this.CalculateEarnings();
		}

		private void textBlock_resetLink_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			textBlock_xmrEarnings.Text = "0";
			comboBox_hashrates.SelectedIndex = 0;
			comboBox_times.SelectedIndex = 0;
		}

		private void comboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			this.CalculateEarnings();
		}
	}
}
