using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.Devices;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerInfo ci = new ComputerInfo();
            Console.WriteLine("系统物理内存(M):" + ci.TotalPhysicalMemory / 1024 / 1024);
            Console.WriteLine("系统虚拟内存(M):" + ci.TotalVirtualMemory / 1024 / 1024);
            Console.WriteLine("可用物理内存(M):" + ci.AvailablePhysicalMemory / 1024 / 1024);
            Console.WriteLine("可用虚拟内存(M):" + ci.AvailableVirtualMemory / 1024 / 1024);
        }
    }
}
