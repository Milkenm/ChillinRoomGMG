using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using static ChillinRoomGMG.WinAPI;

namespace ChillinRoomGMG
{
	internal class XMRig
	{
		public delegate void ShareEvent();

		public event ShareEvent ValidShare;

		public event ShareEvent InvalidShare;

		public delegate void LoggedLineEvent(string line);

		public event LoggedLineEvent LoggedLine;

		private static IntPtr xmrigHandle = new IntPtr();
		private static Process xmrigProcess;
		private static Process startedProcess;

		public bool IsInitialized { get; private set; }
		public bool IsRunning { get; private set; }

		private readonly string minerExePath;

		public XMRig(string minerExePath)
		{
			LoggedLine += XMRig_LoggedLine;

			this.minerExePath = minerExePath;
		}

		private void XMRig_LoggedLine(string line)
		{
			if (line.Contains("accepted"))
			{
				ValidShare?.Invoke();
			}
			else if (line.Contains("rejected"))
			{
				InvalidShare?.Invoke();
			}
		}

		~XMRig()
		{
			if (IsInitialized)
			{
				Kill();
			}
		}

		public void Initialize()
		{
			if (!IsInitialized)
			{
				Process p = new Process();
				p.StartInfo.FileName = minerExePath;
				p.StartInfo.Verb = "runas";
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.UseShellExecute = false;
				p.Start();

				startedProcess = p;

				while (xmrigHandle == new IntPtr())
				{
					foreach (Process process in Process.GetProcessesByName("xmrig"))
					{
						if (process.ProcessName == "xmrig" && process.MainWindowHandle != new IntPtr())
						{
							xmrigProcess = process;
							xmrigHandle = process.MainWindowHandle;

							SetWindowState(WindowState.Hidden);
							PostMessage(xmrigHandle, 0x0100, (int)Keys.P, 0);

							break;
						}
					}
				}

				new Task(new Action(() =>
				{
					try
					{
						while (!p.StandardOutput.EndOfStream)
						{
							string line = p.StandardOutput.ReadLine();

							if (!string.IsNullOrEmpty(line))
							{
								LoggedLine?.Invoke(line);
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				})).Start();

				IsInitialized = true;
				IsRunning = false;
			}
		}

		public enum WindowState
		{
			Shown,
			Hidden,
		}

		public void SetWindowState(WindowState state)
		{
			if (state == WindowState.Shown)
			{
				ShowWindow(xmrigHandle, WindowShowStyle.ShowNoActivate);
			}
			else
			{
				ShowWindow(xmrigHandle, WindowShowStyle.Hide);
			}
		}

		public void Resume()
		{
			if (!IsRunning && IsInitialized)
			{
				PostMessage(xmrigHandle, 0x0100, (int)Keys.R, 0);

				IsRunning = true;
			}
			else if (!IsInitialized)
			{
				Initialize();
				IsInitialized = true;
			}
		}

		public void Pause()
		{
			if (IsRunning && IsInitialized)
			{
				PostMessage(xmrigHandle, 0x0100, (int)Keys.P, 0);

				IsRunning = false;
			}
		}

		public void Kill()
		{
			if (IsInitialized)
			{
				xmrigProcess.Kill();

				IsInitialized = false;
				IsRunning = false;

				xmrigHandle = new IntPtr();
				xmrigProcess = null;
			}
		}
	}
}