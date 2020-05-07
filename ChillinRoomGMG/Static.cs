using ChillinRoomGMG.Forms;
using ChillinRoomGMG.Properties;

using System;
using System.Windows.Forms;

namespace ChillinRoomGMG
{
	internal static class Static
	{
		internal static Settings settings = new Settings();

		internal static readonly string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ChillinRoomGMG\";
		internal static readonly string xmrigPath = appdataPath + @"XMRig\";
		internal static readonly string tempPath = appdataPath + @".temp\";

		internal static NotifyIcon trayIcon = new NotifyIcon();

		internal static Miner minerForm = new Miner();

		internal static Statistics statisticsForm;

		internal static XMRig xmrig;
		internal static InputInactivity inactivity;
	}
}