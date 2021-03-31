using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace GMG_WPF
{
	public class DisableMaximizeBox
	{
		[DllImport("user32.dll")]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		public const int GWL_STYLE = -16;
		public const int WS_MAXIMIZEBOX = 0x10000;

		public static void Disable(Window w)
		{
			var hwnd = new WindowInteropHelper(w).Handle;
			var value = GetWindowLong(hwnd, GWL_STYLE);
			SetWindowLong(hwnd, GWL_STYLE, (int)(value & ~WS_MAXIMIZEBOX));
		}
	}
}
