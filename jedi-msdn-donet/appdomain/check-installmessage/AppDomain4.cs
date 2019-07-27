// From AppDomain to get installation informations
// reference url:
//   http://msdn.microsoft.com/zh-cn/library/dxh1dy9h(v=vs.80).aspx

using System;
using System.Reflection;

class Program {
	static void Main() {
		// Application domain setup information
		AppDomainSetup domaininfo = new AppDomainSetup();
		domaininfo.ApplicationBase = Environment.CurrentDirectory;
		domaininfo.ConfigurationFile = Environment.CurrentDirectory + "\\AppDomain5.exe.config";

		// Create the applicaton domain.
		AppDomain domain = AppDomain.CreateDomain("MyDomain", null, domaininfo);

		// Write the application domain information to the console
		Console.WriteLine("Host domain:" + AppDomain.CurrentDomain.FriendlyName);
		Console.WriteLine("child domain:" + domain.FriendlyName);
		Console.WriteLine();
		Console.WriteLine("Application base is:" + domain.SetupInformation.ApplicationBase);
		Console.WriteLine("Configuration file is:" + domain.SetupInformation.ConfigurationFile);

		// Unloads the application domain
		AppDomain.Unload(domain);
	}
}
