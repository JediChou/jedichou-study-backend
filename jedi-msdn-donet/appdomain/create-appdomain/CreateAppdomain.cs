// How to: Create application domain
// Reference url:
//   http://msdn.microsoft.com/zh-cn/library/6s0z09xw(v=vs.80).aspx

using System;
using System.Reflection;

class Program
{
	public static void Main()
	{
		// Use CreateDomain to get an AppDomain instance.
		Console.WriteLine("Creating new AppDomain.");
		AppDomain domain = AppDomain.CreateDomain("MyDomain");

		// Output AppDomain information.
		Console.WriteLine("Host domain:" + AppDomain.CurrentDomain.FriendlyName);
		Console.WriteLine("Child domain:" + domain.FriendlyName);
	}
}
