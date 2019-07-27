using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace connSqlite
{
    class Program
    {
        /// <summary>
        /// Get path for mapped folder
		/// Book ISBN, 978-7-115-20108-9
		/// Page at 330.
        /// </summary>
        static void Main(string[] args)
        {
            // Define
			SelectQuery selectQuery = new SelectQuery("SELECT * FROM win32_logicaldisk");
			ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);
			int i = 0;
			
			// use Get method of ManagementObjectSearcher to get path.
			// TODO: Why? Has no output.
			foreach(ManagementObject disk in searcher.Get()) {
				string DriveType;
				DriveType = disk["DriveType"].ToString();
				if(DriveType == "4") {
					Console.WriteLine(disk["Name"].ToString());
				}
				i++;
			}
        }
    }
}
