using System;
using System.Collections.Generic;
using System.Text;
// using System.Management;
using System.IO;

namespace connSqlite
{
    class Program
    {
        /// <summary>
        /// Get type of driver.
		/// Book ISBN, 978-7-115-20108-9
		/// Page at 331.
        /// </summary>
        static void Main(string[] args)
        {
            // Define
			// SelectQuery selectQuery = new SelectQuery("SELECT * FROM win32_logicaldisk");
			// ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);
			
			string DriveType;
			DriveInfo dinfo = new DriveInfo("D:");

			// Process
			try {
				DriveType = dinfo.DriveType.ToString();
				switch(DriveType)
				{
					case "Unknown":
						Console.WriteLine("This is a Unknown device.");
						break;
					case "NoRootDirectory":
						Console.WriteLine("This disk can not split.");
						break;
					case "Removable":
						Console.WriteLine("This is U-Disk");
						break;
					case "Fixed":
						Console.WriteLine("This is Hard-Disk");
						break;
					case "Network":
						Console.WriteLine("This is Network driver");
						break;
					case "CDRom":
						Console.WriteLine("This is a CD-ROM");
						break;
					default:
						Console.WriteLine("You put a big shit.");
						break;
				}
			} catch {
				Console.WriteLine("The process is not correct !");
			}
        }
    }
}
