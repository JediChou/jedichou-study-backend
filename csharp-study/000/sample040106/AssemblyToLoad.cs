// AssemblyToLoad.exe
using System;
using System.Threading;
public class Program {
	public static void Main() {
		Console.WriteLine(
			"Thread:{0} Hi from the domain: {1}",
			Thread.CurrentThread.Name,
			AppDomain.CurrentDomain.FriendlyName
		);
	}
}
