using System;
using System.Collections.Generic;
using System.Diagnostics;

static class LanuageFeature
{
	static void DisplayProcess()
	{
		var processes = new List<string>();
		foreach(var process in Process.GetProcesses())
			processes.Add(process.ProcessName);
		
		// Third party method
		// ObjectDumper.Write(processes);

		foreach(var process in processes)
			Console.WriteLine(process);
	}

	static void Main()
	{
		DisplayProcess();
	}
}
