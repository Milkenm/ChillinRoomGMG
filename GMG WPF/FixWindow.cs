using System.Windows;

namespace GMG_WPF
{
	public static class FixWindow
	{
		public static void Fix(Window w)
		{
			DisableMaximizeBox.Disable(w);
			w.MaxWidth = w.Width;
			w.MaxHeight = w.Height;
			w.MinWidth = w.Width;
			w.MinHeight = w.Height;
		}
	}
}
