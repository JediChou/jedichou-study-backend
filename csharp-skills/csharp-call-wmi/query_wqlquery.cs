// reference url:
// https://msdn.microsoft.com/zh-cn/library/ms186146(VS.80).aspx

using System;
using System.Management;

class Query_Select_FullString
{
	public static int Main(string[] args)
	{
		var wqlquery = new WqlObjectQuery("SELECT * FROM Win32_LogicalDisk");
		var searcher = new ManagementObjectSearcher(wqlquery);
		foreach(var disk in searcher.Get())
			Console.WriteLine(disk.ToString());

		return 0;
	}
}
