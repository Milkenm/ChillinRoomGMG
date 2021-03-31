using GMG_Core.Xmrig;

using static GMG_Core.FolderManager;

namespace GMG_Core
{
	public static class GData
	{
		// XMRIG VERSION
		public static string XmrigVersion { get { return "6.10.0"; } }

		// FOLDERS
		public static Folder AppDataFolder { get; set; }
		public static Folder TempFolder { get; set; }
		public static Folder XmrigFolder { get; set; }

		// PATH TO THE XMRIG EXE
		public static string XmrigConfigPath { get; set; }
		public static string XmrigExePath { get; set; }
		public static string XmrigWinringPath { get; set; }

		// SETTINGS PATH
		public static string SettingsPath { get; set; }



		// RANDOM STUFF
		public static Core Core { get; set; }
		public static XMRig XMRig { get; set; }
		public static SettingsManager SettingsManager { get; set; }
	}
}
