using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace CallAgent
{
    class Program
    {
        static string agent = @"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\ECSDB-CmdTest\ECSDB-CmdTest\bin\Debug\ECSDB-CmdTest.exe";

        static void Main(string[] args)
        {
            Timer t = new Timer(GetTestProcessNumber, null, 0, 500);
            Console.ReadLine();
        }

        static void GetTestProcessNumber(Object o)
        {
            int counter = 0;
            Process[] procs = Process.GetProcesses();
            foreach (var process in procs)
                if (process.ProcessName == "ECSDB-CmdTest")
                    counter++;
            if (counter < 160) StartTestProcess();
        }

        static void StartTestProcess()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = agent;
            p.Start();
        }
    }
}
