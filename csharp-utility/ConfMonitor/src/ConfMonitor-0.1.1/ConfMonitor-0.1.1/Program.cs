using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;
using System.Configuration.Install;
using System.Reflection;
using System.Security.Principal;

namespace ConfMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            #region visual studio generate code

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new ConfMonitor() 
            };
            ServiceBase.Run(ServicesToRun);
           

            #endregion

            # region Current Useable code

            // AppDomain.CurrentDomain.UnhandledException += CurrentDomainUnhandledException;

            //WindowsIdentity identity = WindowsIdentity.GetCurrent();
            //WindowsPrincipal principal = new WindowsPrincipal(identity);

            //if (System.Environment.UserInteractive)
            //{
            //    string parameter = string.Concat(args);
            //    switch (parameter)
            //    {
            //        case "/i":
            //        case "/I":
            //        case "-install":
            //        case "--install":
            //            ManagedInstallerClass.InstallHelper(new string[] { Assembly.GetExecutingAssembly().Location });
            //            break;
            //        case "/u":
            //        case "/U":
            //        case "-uninstall":
            //        case "--uninstall":
            //            ManagedInstallerClass.InstallHelper(new string[] { "/u", Assembly.GetExecutingAssembly().Location });
            //            break;
            //    }
            //}
            //else
            //{
            //    //Console.WriteLine("Pls use administrator to install ConfMonitor Service.");
            //    //Console.WriteLine("Install command:");
            //    //Console.WriteLine("  Install   : ConfMonitor /i");
            //    //Console.WriteLine("  Uninstall : ConfMonitor /i");
            //    //Console.WriteLine("Copyright @ Foxconn-CFA-MIS Team");

            //    ServiceBase[] ServicesToRun;
            //    ServicesToRun = new ServiceBase[] { new ConfMonitor() };
            //    ServiceBase.Run(ServicesToRun);
            //}

            #endregion

        }
    }
}
