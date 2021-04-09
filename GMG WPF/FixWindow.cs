using System.Windows;

namespace GMG_WPF
{
	public static class FixWindow
	{
		public static void Fix(Window w, double width, double height)
		{
			DisableMaximizeBox.Disable(w);
			w.MaxWidth = width;
			w.MaxHeight = height;
			w.MinWidth = width;
			w.MinHeight = height;
		}

		public static void Fix(Window w)
		{
			Fix(w, w.Width, w.Height);
		}
	}
}
