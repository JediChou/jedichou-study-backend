// ���M����г���ǰ�M�̵Ĵ��aʾ��
// Jedi Chou, ����4.0�Č���

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

			// ʹ���������ٴ�����
			// TODO: ��Ҫ���¾������캯���᣿��Ȼ߀���g��ͨ�^����
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
