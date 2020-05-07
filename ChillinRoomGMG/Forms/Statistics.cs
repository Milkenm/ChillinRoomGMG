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

		private void RefreshStatistics(object sender, EventArgs e)
		{
			label_totalShares.Text = $"{ThousandsSeparator(minerForm.totalValidShares)} / {ThousandsSeparator(minerForm.totalInvalidShares)}";
			label_hashRateRecord.Text = ThousandsSeparator(minerForm.recordHashRate) + " H/s";

			long days = minerForm.totalMinedSeconds / 60 / 60 / 24;
			long hours = (minerForm.totalMinedSeconds / 60 / 60) - (days * 24);
			long minutes = (minerForm.totalMinedSeconds / 60) - ((hours + (days * 24)) * 60);
			long seconds = minerForm.totalMinedSeconds - ((minutes + ((hours + (days * 24)) * 60)) * 60);

			label_timeMined.Text = $"{days.ToString("000")} - {hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}";
		}

		private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
		{
			statisticsForm = null;
		}
	}
}