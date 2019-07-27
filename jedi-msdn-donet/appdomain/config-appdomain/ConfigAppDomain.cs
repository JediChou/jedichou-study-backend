// How to: Config appliction's AppDomain
// Reference url:
//   http://msdn.microsoft.com/zh-cn/library/c8hk0245(v=vs.80).aspx
using System;
using System.Reflection;
class Program
{
	public static void Main()
	{
		// Create application domain setup information
		AppDomainSetup domainInfo = new AppDomainSetup();
		domainInfo.ApplicationBase = Environment.CurrentDirectory;

		// Create the application domain
		AppDomain domain = AppDomain.CreateDomain("MyDomain", null, domainInfo);

		// Write application domain information to the console
		Console.WriteLine("Host domain:" + AppDomain.CurrentDomain.FriendlyName);
		Console.WriteLine("chile domain:" + domain.FriendlyName);
		Console.WriteLine("Application base is:" + domain.SetupInformation.ApplicationBase);

		// Unload the application domain
		AppDomain.Unload(domain);
	}
}
