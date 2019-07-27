// How to: Unload application domain
// Reference url:
//   http://msdn.microsoft.com/zh-cn/library/c5b8a8f9(v=vs.80).aspx
using System;
using System.Reflection;
class Program
{
	static void Main()
	{
		// Use AppDomain.CurrentDomain to get an AppDomain instance
		Console.WriteLine("Creating new AppDomain.");
		AppDomain domain = AppDomain.CreateDomain("MyDomain", null);

		// Output AppDomain information
		Console.WriteLine("Host domain:" + AppDomain.CurrentDomain.FriendlyName);
		Console.WriteLine("child domain:" + domain.FriendlyName);

		// Unload AppDomain
		AppDomain.Unload(domain);

		// Output Appdomain information again!
		try {
			Console.WriteLine();
			Console.WriteLine("Host domain:" + AppDomain.CurrentDomain.FriendlyName);
		Console.WriteLine("Host domain:" + AppDomain.CurrentDomain.FriendlyName);
		Console.WriteLine("child domain:" + domain.FriendlyName);
			// Will get a AppDomainUnloadedException
			Console.WriteLine("child domain:" + domain.FriendlyName);
		} catch(AppDomainUnloadedException e) {
			Console.WriteLine("child domain does not exists!");
			Console.WriteLine(e.Message);
		}
	}
}
