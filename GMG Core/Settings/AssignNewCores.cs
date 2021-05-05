namespace GMG_Core.Settings
{
	public static class AssignNewCores
	{
		public static void Assign(int[] newCores)
		{
			GData.SettingsManager.Settings.XmrigConfig.CPU.RX = newCores;
			GData.SettingsManager.SaveSettings();
		}
	}
}