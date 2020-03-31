using System;
using System.Windows.Forms;

using static ChillinRoomGMG.Code;
using static ChillinRoomGMG.Static;

namespace ChillinRoomGMG.Forms
{
	public partial class Statistics : Form
	{
		public Statistics()
		{
			InitializeComponent();
		}

		private void Statistics_Load(object sender, EventArgs e)
		{
			RefreshStatistics();
		}

		private void timer_refresh_Tick(object sender, EventArgs e)
		{
			RefreshStatistics();
		}

		private void RefreshStatistics()
		{
			label_totalShares.Text = $"{ThousandsSeparator(settings.TotalValidShares)} / {ThousandsSeparator(settings.TotalInvalidShares)}";
			label_hashRateRecord.Text = ThousandsSeparator(settings.RecordHashRate) + " H/s";

			long days = settings.TotalMinedSeconds / 60 / 60 / 24;
			long hours = (settings.TotalMinedSeconds / 60 / 60) - (days * 24);
			long minutes = (settings.TotalMinedSeconds / 60) - ((hours + (days * 24)) * 60);
			long seconds = settings.TotalMinedSeconds - ((minutes + ((hours + (days * 24)) * 60)) * 60);

			label_timeMined.Text = $"{days.ToString("000")} - {hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}";
		}
	}
}