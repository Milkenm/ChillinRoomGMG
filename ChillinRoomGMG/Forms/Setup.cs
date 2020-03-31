using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

using static ChillinRoomGMG.Static;

namespace ChillinRoomGMG.Forms
{
	public partial class Setup : Form
	{
		public Setup()
		{
			InitializeComponent();
		}

		private void linkLabel_info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/xmrig/xmrig/releases/latest");
		}

		private void button_search_Click(object sender, EventArgs e)
		{
			fileDialog.ShowDialog();
		}

		private void fileDialog_FileOk(object sender, CancelEventArgs e)
		{
			string zipFile = fileDialog.FileName;

			if (!string.IsNullOrEmpty(zipFile))
			{
				Directory.CreateDirectory(tempPath);
				ClearDir(tempPath);
				Directory.CreateDirectory(xmrigPath);
				ClearDir(xmrigPath);

				ZipFile.ExtractToDirectory(zipFile, tempPath);

				foreach (FileInfo fileInfo in new DirectoryInfo(tempPath).GetFiles("*", SearchOption.AllDirectories))
				{
					if (fileInfo.Name == "xmrig.exe")
					{
						CopyFile(fileInfo);
						pixelCheckBox_xmrig.Checked = true;
					}
					else if (fileInfo.Name == "WinRing0x64.sys")
					{
						CopyFile(fileInfo);
						pixelCheckBox_winring.Checked = true;
					}
				}

				if (pixelCheckBox_xmrig.Checked && pixelCheckBox_winring.Checked)
				{
					textBox_path.Text = zipFile;

					setupComplete = true;
					Close();
				}
				else
				{
					new Message("There was a problem finding the files.", false).ShowDialog();
				}

				ClearDir(tempPath);
			}
		}

		private void CopyFile(FileInfo fileInfo)
		{
			File.Copy(fileInfo.FullName, xmrigPath + @"\" + fileInfo.Name);
		}

		private void ClearDir(string dir)
		{
			DirectoryInfo di = new DirectoryInfo(dir);
			foreach (FileInfo file in di.GetFiles())
			{
				file.Delete();
			}
			foreach (DirectoryInfo folder in di.GetDirectories())
			{
				folder.Delete(true);
			}
		}

		private bool setupComplete;

		private void Setup_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!setupComplete)
			{
				Environment.Exit(0);
			}
		}
	}
}