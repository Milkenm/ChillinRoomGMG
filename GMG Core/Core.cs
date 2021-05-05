using GMG_Core.Settings;
using GMG_Core.Utils;
using GMG_Core.Xmrig;

using System;
using System.IO;

using static GMG_Core.Utils.FolderManager;

namespace GMG_Core
{
	public class Core
	{
		public Core()
		{
			// ASSIGN FOLDER AND FILE PATHS
			GData.AppDataFolder = new Folder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ChillinRoomGMG", true);
			GData.TempFolder = new Folder(GData.AppDataFolder.Path + @"\Temp", true);
			GData.XMRigFolder = new Folder(GData.AppDataFolder.Path + @"\XMRig", true);
			GData.XMRigConfigPath = GData.XMRigFolder.Path + @"\config.json";
			GData.XMRigExePath = GData.XMRigFolder.Path + @"\xmrig.exe";
			GData.XMRigWinringPath = GData.XMRigFolder.Path + @"\WinRing0x64.sys";
			GData.SettingsPath = GData.AppDataFolder + @"\Settings.bin";

			// INITIALIZE SETTINGS MANAGER
			GData.SettingsManager = new SettingsManager();

			// CHECK IF XMRIG.EXE DOES NOT EXIST OR WINRING DOES NOT EXIST
			if (File.Exists(GData.XMRigExePath) == false || !File.Exists(GData.XMRigWinringPath) == false)
			{
				// DOWNLOAD XMRIG IF IT DOESNT EXIST
				XmrigDownloader.DownloadXmrig();
			}

			// LOAD XMRIG
			GData.XMRig = new XMRig(GData.XMRigFolder.Path);
		}
	}
}
