
using System.IO;
using System.IO.Compression;
using System.Net;

using static ScriptsLib.Unsorted.Unsorted;

namespace GMG_Core
{
	public class XmrigDownloader
	{
		public static void DownloadXmrig()
		{
			// DELETE EXISTING XMRIG DIRECTORY IF IT EXISTS
			if (Directory.Exists(GData.XmrigFolder.Path))
			{
				ForceDirectoryDelete(GData.XmrigFolder.Path);
				GData.XmrigFolder.CreateFolder();
			}

			// XMRIG DOWNLOAD URL FROM GITHUB
			string releaseUrl = $"https://github.com/xmrig/xmrig/releases/download/v{GData.XmrigVersion}/xmrig-{GData.XmrigVersion}-msvc-win64.zip";
			// SET DOWNLOAD PATHS
			string zipExtractedPath = GData.TempFolder.Path + @"\XMRig_Download";
			string zipPath = zipExtractedPath + ".zip";

			// DELETE EXISTING FILE IF EXISTS
			if (File.Exists(zipPath))
			{
				File.Delete(zipPath);
			}
			// DELETE EXISTING FOLDER IF EXIST
			if (Directory.Exists(zipExtractedPath))
			{
				ForceDirectoryDelete(zipExtractedPath);
			}

			// DOWNLOAD XMRIG
			new WebClient().DownloadFile(releaseUrl, zipPath);
			// EXTRACT THE DOWNLOADED ZIP
			ZipFile.ExtractToDirectory(zipPath, zipExtractedPath);

			// MOVE THE NECESSARY FILES FROM THE EXTRACTED FOLDER TO THE CORRECT PATH
			File.Move(zipExtractedPath + $@"\xmrig-{GData.XmrigVersion}\config.json", GData.XmrigConfigPath);
			File.Move(zipExtractedPath + $@"\xmrig-{GData.XmrigVersion}\xmrig.exe", GData.XmrigExePath);
			File.Move(zipExtractedPath + $@"\xmrig-{GData.XmrigVersion}\WinRing0x64.sys", GData.XmrigWinringPath);

			// CLEANUP
			ForceDirectoryDelete(zipExtractedPath);
			File.Delete(zipPath);
		}
	}
}
