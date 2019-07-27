// 增加一個委託來實現過濾

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

	public delegate void 

	static Boolean Filter(Process process)
	{
		return process.WorkingSet64 >= 20*1024*1024;
	}
	
	DisplayProcess(delegae (Process process){ return process.WorkingSet64 >= 20*1024*1024});

	static void DisplayProcesses(Predicate<Process> match)
	{
		var processes = new List<ProcessData>();
		foreach(var process in Process.GetProcesses())
		{
			// 做一個簡單的過濾
			if (match(process))		
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
