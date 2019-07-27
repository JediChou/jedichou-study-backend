using System;
using System.Threading;
using System.Reflection;
public class Program {
	public static void Main() {
		Thread.CurrentThread.Name = "MyThread";
		AppDomain newDomain = AppDomain.CreateDomain("NewDomain");
		CrossAppDomainDelegate deleg = new CrossAppDomainDelegate(Fct);
		newDomain.DoCallBack(deleg);
		AppDomain.Unload(newDomain);
	}
	public static void Fct() {
		Console.WriteLine(
			"Thread:{0} execute Fct() inside the appdomain {1}",
			Thread.CurrentThread.Name,
			AppDomain.CurrentDomain.FriendlyName
		);
	}
}
