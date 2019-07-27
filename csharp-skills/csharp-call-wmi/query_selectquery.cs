// reference url:
// https://msdn.microsoft.com/zh-cn/library/ms186146(VS.80).aspx

using System;
using System.Management;

class Query_SelectQuery
{
	public static int Main(string[] args)
	{
		var selectQuery = new SelectQuery("Win32_LogicalDisk");
		var searcher = new ManagementObjectSearcher(selectQuery);
		foreach(var disk in searcher.Get())
			Console.WriteLine(disk.ToString());
		return 0;
	}
}
