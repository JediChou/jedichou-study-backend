// reference url:
// http://stackoverflow.com/questions/412632/how-do-i-retrieve-disk-information-in-c
// Title: how do i retrieve disk information

using System;
using System.IO;
using System.Management;

public class DiskInfo
{
	public static void Main(string[] args)
	{
		/*
		var drives = DriveInfo.GetDrives();
		foreach (var drive in drives) {
			Console.WriteLine(drive.Name);
			if (drive.IsReady) Console.WriteLine(drive.TotalSize);
		}*/

		foreach( ManagementObject volume in new ManagementObjectSearcher("Select * from Win32_Volume" ).Get())
		{
		  	if ( volume["FreeSpace"] != null )
  		  	{
    			Console.WriteLine("{0} = {1} out of {2}",
                  volume["Name"],
                  ulong.Parse(volume["FreeSpace"].ToString()).ToString("#,##0"),
                  ulong.Parse(volume["Capacity"].ToString()).ToString("#,##0"));
  			}
		}
	}
}
