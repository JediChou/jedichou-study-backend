using System;
using System.Text;
using System.Configuration.Install;
using System.Collections;
using System.Diagnostics;
using System.ServiceProcess;
using System.Reflection;
using Microsoft.Win32;

namespace sample
{
	class SampleInstallerClass : Installer
	{
		static public String SVC_APP_NAME    = "snaplen";
		static public String SVC_SERVICE_KEY = @"SYSTEM\CurrentControlSet\Services\" + SVC_APP_NAME;
		static public String SVC_PARAM_KEY   = @"SYSTEM\CurrentControlSet\Services\" + SVC_APP_NAME + @"\Parameters";

		public SampleInstallerClass()
		{
			ServiceProcessInstaller spi = new ServiceProcessInstaller();
			ServiceInstaller si = new ServiceInstaller();

			spi.Account    = ServiceAccount.LocalSystem;
			si.StartType   = ServiceStartMode.Automatic;
			si.ServiceName = SVC_APP_NAME;

			Installers.Add(spi);
			Installers.Add(si);
		}

		static int install_uninstall( bool uninstall )
		{
			try
			{
				TransactedInstaller ti = new TransactedInstaller();

				if ( uninstall == false )
				{
					ArrayList cmdline = new ArrayList();

					cmdline.Add( String.Format( "/assemblypath={0}", Assembly.GetExecutingAssembly().Location) );
					cmdline.Add( "/logToConsole=false" );
					cmdline.Add( "/showCallStack" );

					InstallContext ctx = new InstallContext("installer_logfile.log", cmdline.ToArray(typeof(string)) as string[] );

					ti.Installers.Add( new SampleInstallerClass() );
					ti.Context = ctx;
					ti.Install( new Hashtable() );

					RegistryKey k = Registry.LocalMachine.OpenSubKey( SVC_SERVICE_KEY, true );
					k.SetValue("Description", "Sample service");
					k.CreateSubKey("Parameters"); // add any configuration parameters in to this sub-key to read back OnStart()
					k.Close();

					Console.WriteLine("Installation successful, starting service '{0}'...", SVC_APP_NAME );

					// attempt to start the service
					ServiceController service = new ServiceController( SVC_APP_NAME );
					TimeSpan timeout = TimeSpan.FromMilliseconds(15000);
					service.Start();
					service.WaitForStatus( ServiceControllerStatus.Running, timeout );
					return 0;
				}
				else
				{
					ti.Uninstall(null);
					return 0;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.InnerException.Message + e.StackTrace);
				return(1);
			}
		}

		static void doSomething()
		{
			Console.WriteLine("anything");
		}

		static int Main(string[] args)
		{
			if ( args.Length > 0 )
			{
				String cmd = args[0];

				if ( cmd.Equals("-i") || cmd.Equals("-u") )
				{
					return install_uninstall( cmd.Equals("-u") );
				}
				else if ( cmd.Equals("-h") )
				{
					Console.Write( SVC_APP_NAME );
					Console.Write("Options:\n");
					Console.Write("  --help\tShow command line switch help\n");
					Console.Write("  -i\t\tInstall Service\n\t\t-u\tUninstall Service\n");
				}
				return (0);
			}
			else
			{
				Console.WriteLine("no arguments!");
			}

			ServiceBase.Run( new SampleServiceClass() );
			return 0;
		}
	}

	class SampleServiceClass : ServiceBase
	{
		public SampleServiceClass()
		{
			this.AutoLog = false;
			this.CanHandlePowerEvent = true;
			this.CanPauseAndContinue = false;
			this.CanShutdown = true;
			this.ServiceName = "snaplen example service";
		}

		protected override bool OnPowerEvent(PowerBroadcastStatus ps)
		{
			return true;
		}

		protected override void OnStart(string[] args)
		{
			// add your code
		}

		protected override void OnStop()
		{
			// add your code
		}

		protected override void OnShutdown()
		{
			// add your code
		}
	}
}
