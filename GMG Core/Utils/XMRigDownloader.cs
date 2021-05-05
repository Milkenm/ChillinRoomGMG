using System.IO;
using System.IO.Compression;
using System.Net;

using static ScriptsLib.Unsorted.Unsorted;

namespace GMG_Core.Utils
{
	public class XmrigDownloader
	{
		public static void DownloadXmrig()
		{
			// DELETE EXISTING XMRIG DIRECTORY IF IT EXISTS
			if (Directory.Exists(GData.XMRigFolder.Path))
			{
				ForceDirectoryDelete(GData.XMRigFolder.Path);
				GData.XMRigFolder.CreateFolder();
			}

			// XMRIG DOWNLOAD URL FROM GITHUB
			string releaseUrl = $"https://github.com/xmrig/xmrig/releases/download/v{GData.XMRigVersion}/xmrig-{GData.XMRigVersion}-msvc-win64.zip";
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
			File.Move(zipExtractedPath + $@"\xmrig-{GData.XMRigVersion}\config.json", GData.XMRigConfigPath);
			File.Move(zipExtractedPath + $@"\xmrig-{GData.XMRigVersion}\xmrig.exe", GData.XMRigExePath);
			File.Move(zipExtractedPath + $@"\xmrig-{GData.XMRigVersion}\WinRing0x64.sys", GData.XMRigWinringPath);

			// CLEANUP
			ForceDirectoryDelete(zipExtractedPath);
			File.Delete(zipPath);
		}
	}
}
