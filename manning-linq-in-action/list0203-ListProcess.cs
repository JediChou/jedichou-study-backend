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
		public String Name;

		public ProcessData(Int32 id, Int64 memory, string name)
		{
			this.Id = id;
			this.Memory = memory;
			this.Name = name;
		}
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

			// 使用新特性再次增強
			// TODO: 需要重新編寫構造函數嗎？居然還編譯不通過！？
			processes.Add( new ProcessData(process.Id, process.ProcessName, process.WorkingSet64));
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
