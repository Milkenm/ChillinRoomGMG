using GMG_Core.Xmrig;

using System;
using System.IO;

using static GMG_Core.FolderManager;

namespace GMG_Core
{
	public class Core
	{
		public Core()
		{
			// ASSIGN FOLDER AND FILE PATHS
			GData.AppDataFolder = new Folder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ChillinRoomGMG", true);
			GData.TempFolder = new Folder(GData.AppDataFolder.Path + @"\Temp", true);
			GData.XmrigFolder = new Folder(GData.AppDataFolder.Path + @"\XMRig", true);
			GData.XmrigConfigPath = GData.XmrigFolder.Path + @"\config.json";
			GData.XmrigExePath = GData.XmrigFolder.Path + @"\xmrig.exe";
			GData.XmrigWinringPath = GData.XmrigFolder.Path + @"\WinRing0x64.sys";
			GData.SettingsPath = GData.AppDataFolder + @"\Settings.bin";

			// INITIALIZE SETTINGS MANAGER
			GData.SettingsManager = new SettingsManager();

			// CHECK IF XMRIG.EXE DOES NOT EXIST OR WINRING DOES NOT EXIST
			if (File.Exists(GData.XmrigExePath) == false || !File.Exists(GData.XmrigWinringPath) == false)
			{
				// DOWNLOAD XMRIG IF IT DOESNT EXIST
				XmrigDownloader.DownloadXmrig();
			}

			// LOAD XMRIG
			GData.XMRig = new XMRig(GData.XmrigFolder.Path);
		}
	}
}
