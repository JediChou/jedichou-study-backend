// File name: list0306.cs
// Reference by Linq in Action zh-cn

using System;
using System.Linq;
using System.Diagnostics;
using System.Collections;

class List0306
{
	public static void Main()
	{
		// query 1 - classic linq query
		var processes1 = 
			Process.GetProcesses()
			.Where(process => process.WorkingSet64 > 20*1024*1024)
			.OrderByDescending(process => process.WorkingSet64)
			.Select(process => new {
				process.Id,
				Name = process.ProcessName
			});
			
		// query 2 - use enumerator
		// todo: something wrong, need fix
		var processes2 =
			Enumberable.Select(
				Enumberable.OrderByDescending(
					Enumberable.Where(
						Process.GetProcesses(),
						process => process.WorkingSet64 > 20 * 1024 * 1024),
					process => process.WorkingSet64),
				process => new { process.Id, Name = process.ProcessName});
	}
}