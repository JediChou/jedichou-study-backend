using System;
using System.Management;

class Program
{
	public static void Main(string[] args)
	{
		var query = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
	}
}