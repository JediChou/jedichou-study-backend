using System;
using System.Threading;
public class Program {
	public static void Main() {
		// Name current thread, and create an AppDomainSetup instance
		Thread.CurrentThread.Name = "MyThread";
		AppDomainSetup info = new AppDomainSetup();

		// config AppDomainSetup instance's property
		info.ApplicationBase = "file:///" + Environment.CurrentDirectory;

		// Create a new appdomain without security parameters.
		AppDomain newDomain = AppDomain.CreateDomain("NewDomain", null, info);
		Console.WriteLine(
			"Thread:{0} Calling ExecuteAssembly() from appdomain {1}",
			Thread.CurrentThread.Name,
			AppDomain.CurrentDomain.FriendlyName
		);

		// Load the assembly 'AssemblyACharge.ext' inside
		// 'NewDomain' and then execute it.
		newDomain.ExecuteAssembly("AssemblyToLoad.exe");

		AppDomain.Unload(newDomain);
	}
}
