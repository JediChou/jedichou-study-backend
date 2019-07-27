// https://docs.microsoft.com/zh-cn/dotnet/api/system.threading.monitor?view=netframework-4.7.2

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class MonitorClassDemo
{
	public static void Main()
	{
		List<Task> tasks = new List<Task>();
		Random rnd = new Random();
		long total = 0;
		int n = 0;

		for (int taskCtr = 0; taskCtr < 10; taskCtr++)
			tasks.Add(Task.Run(()=>{
				int[] values = new int[10000];
				int taskTotal = 0;
				int taskN = 0;
				Monitor.Enter(rnd);
		}));
	}
}
