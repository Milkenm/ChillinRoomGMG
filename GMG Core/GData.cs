using GMG_Core.Settings;
using GMG_Core.Xmrig;

using static GMG_Core.Utils.FolderManager;

namespace GMG_Core
{
	public static class GData
	{
		// XMRIG VERSION
		public static string XMRigVersion { get { return "6.10.0"; } }

		// FOLDERS
		public static Folder AppDataFolder { get; set; }
		public static Folder TempFolder { get; set; }
		public static Folder XMRigFolder { get; set; }

		// PATH TO THE XMRIG EXE
		public static string XMRigConfigPath { get; set; }
		public static string XMRigExePath { get; set; }
		public static string XMRigWinringPath { get; set; }

		// SETTINGS PATH
		public static string SettingsPath { get; set; }



		// RANDOM STUFF
		public static Core Core { get; set; }
		public static XMRig XMRig { get; set; }
		public static SettingsManager SettingsManager { get; set; }
	}
}
