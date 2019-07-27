using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		var drivesName = new List<string>();
        foreach (var drive in System.IO.DriveInfo.GetDrives())
        	Console.WriteLine(drive.Name);
	}
}
