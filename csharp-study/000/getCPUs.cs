using System;
using System.Management;
using System.Management.Instrumentation; 
using System.Runtime.InteropServices;

class Program {
	static void Main(string[] args) {

		Console.WriteLine("CPUs£º{0}", getLocalCPUs()); 
	}

	// Can not compile
	// [DllImport("kernel32.dll", SetLastError=true)]
	// public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

	public static int getLocalCPUs() {
		var m = new ManagementClass("Win32_Processor"); 
		var mn = m.GetInstances(); 
		return mn.Count;
	}
}

