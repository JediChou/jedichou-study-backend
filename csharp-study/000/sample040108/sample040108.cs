using System;
using System.Reflection;
public class Program {
	public static void Main() {
		AppDomain.CurrentDomain.AssemblyResolve += AssemblyResolve;
		Assembly.Load("AssemblyToLoad.dll");
	}
	public static Assembly AssemblyResolve(object sender,
										   ResolveEventArgs e) {
		Console.WriteLine("Can't find assembly: {0}", e.Name);
		return Assembly.LoadFrom("AssemblyToLoad.dll");
	}
}

// TODO: need to fix
