// ref: Pro C# and .NET 4.0 Platform
// page 856
// Jedi Chou, 2016.3.25 23:02

using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllCode
{
	class Program : Application
	{
		[STAThread]
		static void Main(string[] args)
		{
			Program app = new Program();
			app.Startup += AppStartUp;
			app.Exit += AppExit;
			app.Run();
		}

		static void AppExit(object sender, StartupEventArgs e)
		{
			MesssageBox.Show("App has exited");
		}

		static void AppStartUp(object sender, StartupEventArgs e)
		{
			Window mainWindow = new Window();
			mainWindow.Title = "My First WPF App!";
			mainWindow.Height = 200;
			mainWindow.Width = 300;
			mainWindow.WindowsStartupLocation = WindowsStartupLocation.CenterScreen;
			mainWindow.Show();
		}
	}
}
