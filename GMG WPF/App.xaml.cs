using GMG_Core;

using System.Windows;

namespace GMG_WPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			new Core();

			bool startMinimized = GData.SettingsManager.Settings.MinimizeOnStart;
			if (startMinimized == false)
			{
				for (int i = 0; i != e.Args.Length; ++i)
				{
					if (e.Args[i] == "-startMinimized")
					{
						startMinimized = true;
					}
				}
			}
			MainWindow mainWindow = new MainWindow(startMinimized);
		}
	}
}
