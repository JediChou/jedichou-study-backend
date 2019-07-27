using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace connSqlite
{
    class Program
    {
        /// <summary>
        /// Get properties of local hard disk
		/// Book ISBN, 978-7-115-20108-9
		/// Page at 328.
        /// </summary>
        static void Main(string[] args)
        {
            // Define
			ManagementObjectSearcher searcher =	new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
			string strHardDiskID = null;
			
			// Use WMI property to filter
			foreach(ManagementObject mo in searcher.Get()) {
				strHardDiskID = mo["SerialNumber"].ToString().Trim();
				break;
			}
			Console.WriteLine(strHardDiskID);
        }
    }
}
