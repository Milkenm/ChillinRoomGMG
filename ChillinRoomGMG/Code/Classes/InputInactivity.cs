using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChillinRoomGMG
{
	internal class InputInactivity
	{
		[DllImport("user32.dll")]
		private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

		[StructLayout(LayoutKind.Sequential)]
		private struct LASTINPUTINFO
		{
			public uint cbSize;
			public int dwTime;
		}

		private readonly Timer t = new Timer();

		public bool RunTask { get; set; } = true;
		public long msDelay { get; set; }

		public InputInactivity(long msDelay)
		{
			this.msDelay = msDelay;

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

			long ms = idleTime.Milliseconds + (idleTime.Seconds * 1000) + (idleTime.Minutes * 60000) + (idleTime.Hours * 3600000) + (idleTime.Days * 86400000);

			if (ms == msDelay && RunTask)
			{
				didRun = true;
				InactivityTimeReached();
			}
			else if (ms < msDelay && didRun)
			{
				didRun = false;
				InputReceived();
			}
		}
	}
}