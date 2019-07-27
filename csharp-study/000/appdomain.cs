using System;
using System.Reflection;
using System.Collections;
class Program {
	static void Main() {
		ArrayList al = new ArrayList();
		AppDomain curAppDomain = AppDomain.CurrentDomain;
		foreach( Assembly assembly in curAppDomain.GetAssemblies())
			Console.WriteLine(assembly.FullName);
		Console.WriteLine(Environment.CurrentDirectory);
	}
}
