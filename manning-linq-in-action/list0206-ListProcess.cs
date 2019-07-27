using System;
using System.Collections.Generic;
using System.Diagnostics;

static class LanaugeFeature
{
	class ProcessData
	{
		public Int32 Id;
		public Int64 Memory;
		public string Name;
	}

	static void DisplayProcesses()
	{
		var processes = new List<ProcessData>();
		foreach(var process in Process.GetProcesses())
		{
			// ×öÒ»‚€º††ÎµÄß^žV
			if (process.WorkingSet64 >= 20*1024*1024)		
				processes.Add(
					new ProcessData {
						Id=process.Id, 
						Name=process.ProcessName, 
						Memory=process.WorkingSet64}
				);
		}

		// Third party method
		// ObjectDumper.Write(processes);

		foreach(var process in processes)
			Console.WriteLine(
				"Process ID:{0}, Process Name:{1}, Process Memory:{2}", 
				process.Id, process.Name, process.Memory
			);
	}

	static void Main()
	{
		DisplayProcesses();
	}
}
