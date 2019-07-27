using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program {
	static void Main() {
		Process proc = Process.GetCurrentProcess();
		Console.WriteLine(proc.PrivateMemorySize64 / (1024 * 1024) );
		Console.ReadLine();
	}
}
