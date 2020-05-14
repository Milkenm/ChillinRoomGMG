using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using static ChillinRoomGMG.Code;
using static ChillinRoomGMG.Static;

using static ScriptsLib.Network.Requests;

// # = #
// https://monero.stackexchange.com/questions/1388/how-much-cpu-power-to-mine-1-coin-a-day
// https://en.wikipedia.org/wiki/Names_of_large_numbers
// 
// # = #

namespace ChillinRoomGMG.Forms
{
	public partial class Statistics : Form
	{
		private MoneroInfo moneroInfo;

		public Statistics()
		{
			InitializeComponent();
		}

		private void Statistics_Load(object sender, EventArgs e)
		{
			RefreshStatistics(null, null);

			string walletAddress = settings.MineForChillinRoom ? settings.ChillinRoomWalletAddress : settings.WalletAddress;
			string minerName = settings.MineForChillinRoom ? settings.ChillinRoomMinerId.ToString() : settings.MinerName;

			Global workersStats = JsonConvert.DeserializeObject<Global>(GET($"https://supportxmr.com/api/miner/{walletAddress}/chart/hashrate/allWorkers"));
			MinerStats minerStats = JsonConvert.DeserializeObject<MinerStats>(GET($"https://supportxmr.com/api/miner/{walletAddress}/stats/{minerName}"));
			moneroInfo = JsonConvert.DeserializeObject<MoneroInfo>(GET("https://moneroblocks.info/api/get_stats"));

			label_totalHashes.Text = (minerStats.totalHash != null ? ThousandsSeparator(minerStats.totalHash) : "0") + " H";
			label_totalPoolShares.Text = (minerStats.validShares ?? 0) + " / " + (minerStats.invalidShares ?? 0);

			if (workersStats.global.Count > 0)
			{
				long hashSum = 0;
				foreach (PoolHashRateChart chart in workersStats.global)
				{
					hashSum += chart.hs;
				}

				float averageHashRate = hashSum / workersStats.global.Count;

				label_averageHashRate.Text = ThousandsSeparator(averageHashRate) + " H/s";

				int index = 0;
				while (averageHashRate / 1000 >= 1)
				{
					averageHashRate /= 1000;
					index++;
				}
				comboBox_hashRates.SelectedIndex = index;
				numeric_hashRate.Value = (decimal)averageHashRate;
			}
			else
			{
				comboBox_hashRates.SelectedIndex = 0;
			}
		}

		public class Global
		{
			public List<PoolHashRateChart> global;
		}

		public class PoolHashRateChart
		{
			public long ts;
			public long hs;
		}

		public class MinerStats
		{
			public string totalHash;
			public int? validShares;
			public int? invalidShares;
		}

		public class MoneroInfo
		{
			public float difficulty;
			public float hashrate;
			public float total_emission;
			public float last_reward;
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

		private void CalculateEarnings(object sender, EventArgs e)
		{
			float latestBlockReward = moneroInfo.last_reward;
			float minerHashRate = (float)numeric_hashRate.Value * (float)Math.Pow(10, comboBox_hashRates.SelectedIndex * 3);
			float netHashRate = (float)Math.Round(moneroInfo.hashrate, 0);

			float hourlyEarnings = (30 * latestBlockReward / (float)Math.Pow(10, 12) * minerHashRate) / netHashRate;
			float dailyEarnings = hourlyEarnings * 24;
			float weeklyEarnings = dailyEarnings * 7;
			float monthlyEarnings = dailyEarnings * 30;
			float yearlyEarnings = dailyEarnings * 365;

			Label[] labels = new Label[] { label_hourlyEarnings, label_dailyEarnings, label_weeklyEarnings, label_monthlyEarnings, label_yearlyEarnings };
			float[] vars = new float[] { hourlyEarnings, dailyEarnings, weeklyEarnings, monthlyEarnings, yearlyEarnings };

			for (int i = 0; i < labels.Length; i++)
			{
				labels[i].Text = Math.Truncate(vars[i]) >= 10 ? AbbreviateNumber(vars[i]) : vars[i].ToString("F7");
			}
		}

		private string AbbreviateNumber(float number)
		{
			string[] numSplit = ThousandsSeparator(number.ToString("F4").Split('.')[0]).Split(',');

			if (numSplit.Length > 1)
			{
				StringBuilder numString = new StringBuilder(numSplit[0]);

				if (numSplit[1][1] != '0')
				{
					numString.Append('.').Append(numSplit[1][0]).Append(numSplit[1][1]);
				}

				numString.Append(' ').Append("K");

				return numString.ToString();
			}
			else
			{
				return numSplit[0];
			}
		}

		private float Monerofloat(float number)
		{
			float divide = (float)Math.Pow(10, 12);
			float value = number / divide;

			return (float)Math.Round(value, 4, MidpointRounding.AwayFromZero);
		}
	}
}