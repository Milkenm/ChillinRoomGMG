using System.Windows;

namespace GMG_WPF.Utils
{
	public static partial class WindowUtils
	{
		public static void FixWindow(Window w, double width, double height)
		{
			WindowUtils.DisableMaximizeBox(w);
			w.MaxWidth = width;
			w.MaxHeight = height;
			w.MinWidth = width;
			w.MinHeight = height;
		}

		public static void FixWindow(Window w)
		{
			FixWindow(w, w.Width, w.Height);
		}
	}
}
