using GMG_Core;

using GMG_WPF.Windows;

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
			this.DispatcherUnhandledException += this.Application_DispatcherUnhandledException;

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

		private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
		}
	}
}
