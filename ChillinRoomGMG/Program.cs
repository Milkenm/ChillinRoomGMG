using ChillinRoomGMG.Forms;

using System;
using System.IO;
using System.Windows.Forms;

using static ChillinRoomGMG.Code;
using static ChillinRoomGMG.Static;
using static ScriptsLib.Tools;

namespace ChillinRoomGMG
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			if (IsThisApplicationAlreadyRunning())
			{
				MessageBox.Show("Another instance of ChillinRoom GMG is already running.", "ChillinRoom GMG", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
				Application.ThreadException += (s, e) => GlobalException();
				AppDomain.CurrentDomain.UnhandledException += (s, e) => GlobalException();

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new TrayIcon());
			}
		}

		private static void GlobalException() {
			if (xmrig.IsRunning)
			{
				minerForm.Mine();
				minerForm.Mine();
			}
		}

		private class TrayIcon : ApplicationContext
		{
			public TrayIcon()
			{
				if (!File.Exists(xmrigPath + "xmrig.exe") || !File.Exists(xmrigPath + "WinRing0x64.sys"))
				{
					new Setup().ShowDialog();
				}

				minerForm.Show();

				trayIcon = new NotifyIcon();
				trayIcon.Text = "ChillinRoom GMG";
				trayIcon.Icon = Properties.Resources.ChillinRoom_ICO;
				trayIcon.Visible = true;

				ContextMenu menu = new ContextMenu();

				MenuItem item = new MenuItem()
				{
					Text = "Open",
					DefaultItem = true,
				};
				item.Click += (s, e) =>
			   {
				   if (settings.ChillinRoomMinerId != 0)
				   {
					   minerForm.Show();
				   }
				   else
				   {
					   new Setup().ShowDialog();
				   }
			   };

				menu.MenuItems.Add(item);
				menu.MenuItems.Add("-");
				menu.MenuItems.Add("Settings", (s, e) => new Options().ShowDialog());
				menu.MenuItems.Add("Close", (s, e) => AppClose());

				trayIcon.ContextMenu = menu;

				trayIcon.Click += (s, e) => minerForm.Show();
				trayIcon.DoubleClick += (s, e) => minerForm.Show();
			}
		}
	}
}