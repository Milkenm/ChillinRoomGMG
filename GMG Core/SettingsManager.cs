using GMG_Core.Xmrig;

using ScriptsLib.Extensions;

using System;
using System.Collections.Generic;
using System.IO;

using static GMG_Core.Enums;
using static GMG_Core.XMR;

namespace GMG_Core
{
	public class SettingsManager
	{
		public SettingsManager()
		{
			this.LoadSettings();
			this.LoadDefaults();
			this.SetOverrides();
		}

		~SettingsManager()
		{
			this.LoadDefaults();
			this.SetOverrides();
			this.SaveSettings();
		}

		private void SetOverrides()
		{
			this.Settings.XmrigConfig.Colors = false;
			this.Settings.XmrigConfig.PrintTime = 1;
			this.Settings.XmrigConfig.Pools[0].URL = "pool.supportxmr.com:3333";

			List<int> cores = new List<int>();
			for (int i = 0; i < Environment.ProcessorCount; i++)
			{
				cores.Add(i);
			}
			this.Settings.XmrigConfig.CPU.RXWoW = cores.ToArray();
			this.Settings.XmrigConfig.HTTP.Enabled = true;
			this.Settings.XmrigConfig.HTTP.Port = 38486;
		}

		private void LoadDefaults()
		{
			if (this.Settings.XmrigConfig == null) this.Settings.XmrigConfig = new XMRigConfigJSON();
			if (this.Settings.MiningCores == null) this.Settings.MiningCores = new List<int>() { 0 };
			if (this.Settings.AfkMiningCores == null) this.Settings.AfkMiningCores = new List<int>() { 0 };
			if (this.Settings.AfkMiningDelay == 0) this.Settings.AfkMiningDelay = 30;
			if (this.Settings.ValidSharesAmountForNotification == 0) this.Settings.ValidSharesAmountForNotification = 1;
			if (this.Settings.InvalidSharesAmountForNotification == 0) this.Settings.InvalidSharesAmountForNotification = 1;
			if (this.Settings.Statistics == null) this.Settings.Statistics = new Statistics();
		}

		public void LoadSettings()
		{
			if (File.Exists(GData.SettingsPath))
			{
				byte[] bytes = File.ReadAllBytes(GData.SettingsPath);
				this.Settings = bytes.ToObject<Settings>();
			}
			else
			{
				this.SaveSettings(true);
			}
		}

		public void SaveSettings(bool dontUpdateXmrigConfig = false)
		{
			byte[] bytes = this.Settings.ToByteArray();
			File.WriteAllBytes(GData.SettingsPath, bytes);
			if (dontUpdateXmrigConfig == false)
			{
				GData.XMRig.UpdateConfig(this.Settings.XmrigConfig);
			}
		}

		public void LoadXmrigSettings(XmrigSettings settings)
		{
			switch (settings)
			{
				case XmrigSettings.NormalMining:
					if (this.Settings.XmrigConfig.CPU.RX != this.Settings.MiningCores.ToArray())
					{
						AssignNewCores.Assign(this.Settings.MiningCores.ToArray());
					}
					break;
				case XmrigSettings.AfkMining:
					if (this.Settings.XmrigConfig.CPU.RX != this.Settings.AfkMiningCores.ToArray())
					{
						AssignNewCores.Assign(this.Settings.AfkMiningCores.ToArray());
					}
					break;
			}
		}

		public enum XmrigSettings
		{
			NormalMining,
			AfkMining,
		}

		public Settings Settings { get; set; } = new Settings();
	}

	[Serializable]
	public class Settings
	{
		public XMRigConfigJSON XmrigConfig { get; set; } = new XMRigConfigJSON();
		public List<int> MiningCores = new List<int>() { 0 };
		public List<int> AfkMiningCores = new List<int>() { 0 };
		public bool RunOnAppStart = false;
		public bool StopInsteadOfPause = true;
		public bool AfkMiningEnabled = false;
		public int AfkMiningDelay = 30;
		public TimeUnit AfkMiningTimeUnit = TimeUnit.Minute;
		public bool CloseToTray = false;
		public bool MinimizeToTray = true;
		public bool DesktopNotificationOnValidShare = false;
		public bool DesktopNotificationOnInvalidShare = false;
		public int ValidSharesAmountForNotification = 1;
		public int InvalidSharesAmountForNotification = 1;
		public Currency Currency = Currency.EUR;
		public Statistics Statistics = new Statistics();
		public bool MinimizeOnStart = false;
	}

	[Serializable]
	public class Statistics
	{
		public long TotalMinedSeconds = 0;
		public long RecordMinedSeconds = 0;
		public long TotalValidShares = 0;
		public long TotalInvalidShares = 0;
		public decimal RecordHashRate = 0;
	}
}
