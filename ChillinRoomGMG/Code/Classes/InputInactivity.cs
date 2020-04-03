using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using static ChillinRoomGMG.WinAPI;

namespace ChillinRoomGMG
{
	internal class InputInactivity
	{
		private readonly Timer t = new Timer();

		private long msDelay = 0;

		public long MsDelay
		{
			get { return msDelay; }
			set { msDelay = value < 0 ? 0 : value; }
		}

		public InputInactivity(long msDelay = 0)
		{
			MsDelay = msDelay;

			t.Interval = 1;
			t.Tick += (s, e) => Tick();
			t.Start();
		}

		public delegate void EventDelegate();

		public event EventDelegate InputReceived;

		public event EventDelegate InactivityTimeReached;

		private static bool didRun = false;

		private void Tick()
		{
			DateTime bootTime = DateTime.UtcNow.AddMilliseconds(-Environment.TickCount);

			LASTINPUTINFO lii = new LASTINPUTINFO();
			lii.cbSize = (uint)Marshal.SizeOf(typeof(LASTINPUTINFO));
			GetLastInputInfo(ref lii);

			DateTime lastInputTime = bootTime.AddMilliseconds(lii.dwTime);

			TimeSpan idleTime = DateTime.UtcNow.Subtract(lastInputTime);

			if (MsDelay > 0)
			{
				long msIdle = idleTime.Milliseconds + (idleTime.Seconds * 1000) + (idleTime.Minutes * 60000) + (idleTime.Hours * 3600000) + (idleTime.Days * 86400000);

				if (msIdle == MsDelay)
				{
					didRun = true;
					InactivityTimeReached();
				}
				if (msIdle < MsDelay && didRun)
				{
					didRun = false;
					InputReceived();
				}
			}
		}
	}
}