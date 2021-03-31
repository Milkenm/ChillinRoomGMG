using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
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
			this.InitializeComponent();
		}

		private void Statistics_Load(object sender, EventArgs e)
		{
			this.RefreshStatistics(null, null);

			comboBox_hashRates.SelectedIndex = 0;

			new Task(new Action(() =>
			{
				Global workersStats = JsonConvert.DeserializeObject<Global>(GET($"https://supportxmr.com/api/miner/{settings.WalletAddress}/chart/hashrate/allWorkers"));
				MinerStats minerStats = JsonConvert.DeserializeObject<MinerStats>(GET($"https://supportxmr.com/api/miner/{settings.WalletAddress}/stats/{settings.MinerName}"));
				moneroInfo = JsonConvert.DeserializeObject<MoneroInfo>(GET("https://moneroblocks.info/api/get_stats"));
				WalletInfo walletInfo = JsonConvert.DeserializeObject<WalletInfo>(GET($"https://supportxmr.com/api/miner/{settings.WalletAddress}/stats/"));

				this.Invoke(new Action(() =>
				{
					label_totalHashes.Text = (minerStats.totalHash != null ? this.AbbreviateNumber(Convert.ToSingle(minerStats.totalHash), false, true) : "0") + "H";

					string poolValidShares = minerStats.validShares != null ? this.AbbreviateNumber(Convert.ToSingle(minerStats.validShares)) : "0";
					string poolInvalidShares = minerStats.invalidShares != null ? this.AbbreviateNumber(Convert.ToSingle(minerStats.invalidShares)) : "0";
					label_totalPoolShares.Text = poolValidShares + " / " + poolInvalidShares;

					if (workersStats.global.Count > 0)
					{
						long hashSum = 0;
						foreach (PoolHashRateChart chart in workersStats.global)
						{
							hashSum += chart.hs;
						}

						float averageHashRate = hashSum / workersStats.global.Count;

						label_averageHashRate.Text = this.AbbreviateNumber(averageHashRate, addSpaceAtEndIfNotRounded: true) + "H/s";

						int index = 0;
						while (averageHashRate / 1000 >= 1)
						{
							averageHashRate /= 1000;
							index++;
						}
						comboBox_hashRates.SelectedIndex = index;
						numeric_hashRate.Value = (decimal)averageHashRate;
					}

					label_height.Text = "Height: " + ThousandsSeparator(moneroInfo.height);
					label_difficulty.Text = "Difficulty: " + ThousandsSeparator(moneroInfo.difficulty);
					label_pendingXmr.Text = $"Pending XMR: {(walletInfo.amtDue / pow).ToString("F8").Replace(',', '.')} XMR";
				}));
			})).Start();
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
			public BigInteger difficulty;
			public float height;
			public float hashrate;
			public float total_emission;
			public float last_reward;
		}

		public class WalletInfo
		{
			public float amtDue;
		}

		private void RefreshStatistics(object sender, EventArgs e)
		{
			label_totalShares.Text = $"{this.AbbreviateNumber(minerForm.totalValidShares)} / {this.AbbreviateNumber(minerForm.totalInvalidShares)}";
			label_hashRateRecord.Text = this.AbbreviateNumber(Convert.ToSingle(minerForm.recordHashRate)) + "H/s";
			if (minerForm.recordHashRateDate != default)
			{
				DateTime recordDate = minerForm.recordHashRateDate;
				label_hashRateRecordInfo.Text = $"Record H/s (set on: {this.FormatDate(recordDate)})";
			}

			this.FormatTimeLabel(label_timeMined, minerForm.totalMinedSeconds);
			this.FormatTimeLabel(label_longestTimeMining, minerForm.longestTimeMining);

			label_recordValidSharesInOneSession.Text = this.AbbreviateNumber(Convert.ToSingle(minerForm.sessionValidSharesRecord));
			label_recordInvalidSharesInOneSession.Text = this.AbbreviateNumber(Convert.ToSingle(minerForm.sessionInvalidSharesRecord));

			if (minerForm.sessionValidSharesRecordDate != default)
			{
				DateTime recordDate = minerForm.sessionValidSharesRecordDate;
				label_recordValidSharesInOneSessionInfo.Text = $"Valid ({this.FormatDate(recordDate)})";
			}
			if (minerForm.sessionInvalidSharesRecordDate != default)
			{
				DateTime recordDate = minerForm.sessionInvalidSharesRecordDate;
				label_recordInvalidSharesInOneSessionInfo.Text = $"Invalid ({this.FormatDate(recordDate)})";
			}
		}

		private void FormatTimeLabel(Label label, long totalSeconds)
		{
			long days = totalSeconds / 60 / 60 / 24;
			long hours = (totalSeconds / 60 / 60) - (days * 24);
			long minutes = (totalSeconds / 60) - ((hours + (days * 24)) * 60);
			long seconds = totalSeconds - ((minutes + ((hours + (days * 24)) * 60)) * 60);

			label.Text = $"{days:000} - {hours:00}:{minutes:00}:{seconds:00}";
		}

		private string FormatDate(DateTime date)
		{
			return $"{date.Day}/{date.Month}/{date.Year}";
		}

		private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
		{
			statisticsForm = null;
		}

		private float pow = (float)Math.Pow(10, 12);

		private void CalculateEarnings(object sender, EventArgs e)
		{
			if (moneroInfo != null)
			{
				float latestBlockReward = moneroInfo.last_reward;
				float minerHashRate = (float)numeric_hashRate.Value * (float)Math.Pow(10, comboBox_hashRates.SelectedIndex * 3);
				float netHashRate = (float)Math.Round(moneroInfo.hashrate, 0);

				float hourlyEarnings = 30 * latestBlockReward / pow * minerHashRate / netHashRate;
				float dailyEarnings = hourlyEarnings * 24;
				float weeklyEarnings = dailyEarnings * 7;
				float monthlyEarnings = dailyEarnings * 30;
				float yearlyEarnings = dailyEarnings * 365;

				Label[] labels = new Label[] { label_hourlyEarnings, label_dailyEarnings, label_weeklyEarnings, label_monthlyEarnings, label_yearlyEarnings };
				float[] vars = new float[] { hourlyEarnings, dailyEarnings, weeklyEarnings, monthlyEarnings, yearlyEarnings };

				for (int i = 0; i < labels.Length; i++)
				{
					labels[i].Text = Math.Truncate(vars[i]) >= 10 ? this.AbbreviateNumber(vars[i]) : vars[i].ToString("F7");
				}
			}
		}

		private string AbbreviateNumber(float number, bool decimals = true, bool noDecimalsRoundUp = false, bool addSpaceAtEndIfNotRounded = false)
		{
			string[] numSplit = ThousandsSeparator(number.ToString("F4").Split('.')[0]).Split(',');

			if (numSplit.Length > 1)
			{
				StringBuilder numString = new StringBuilder(numSplit[0]);

				if (decimals)
				{
					if (numSplit[1][1] != '0')
					{
						numString.Append('.').Append(numSplit[1][0]).Append(numSplit[1][1]);
					}
				}
				else
				{
					if (noDecimalsRoundUp && Convert.ToInt16(numSplit[1][0]) >= 5)
					{
						numString = new StringBuilder((Convert.ToInt64(numSplit[0]) + 1).ToString());
					}
				}

				numString.Append(' ').Append(new char[] { 'K', 'M', 'B', 'T' }[numSplit.Length - 2]);

				return numString.ToString();
			}
			else
			{
				return numSplit[0].Split('.', ',')[0] + (addSpaceAtEndIfNotRounded ? " " : "");
			}
		}

		private void button_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}