using System;

using static ChillinRoomGMG.Static;

namespace ChillinRoomGMG
{
	internal static partial class Code
	{
		internal static void AppClose()
		{
			minerForm.SaveSettings();

			trayIcon.Visible = false;

			xmrig.Kill();

			Environment.Exit(0);
		}
	}
}