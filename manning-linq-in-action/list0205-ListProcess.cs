// 改進後的列出當前進程的代碼示例
// Jedi Chou, 我用4.0改寫了

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
			// var data = new ProcessData();
			// data.Id = process.Id;
			// data.Name = process.ProcessName;
			// data.Memory = process.WorkingSet64;
			// processes.Add(data);
			
			processes.Add(new ProcessData {Id=process.Id, Name=process.ProcessName, Memory=process.WorkingSet64});
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
