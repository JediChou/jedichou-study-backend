namespace ServerConnector
{
    using System;
    using System.IO;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using NetVerifyLibrary;

    enum ScanMode { SINGLE, MULTI };

    /// <summary>
    /// Program start here. Cross this program you can get server
    /// connected status.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program start here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Define variable
            var ip_file = "";
            var ip_list = new string[] { };
            var ip_arry = new ArrayList();

            // Get ip file path and check it exists
            if (args.Length > 0)
                if (File.Exists(args[0]))
                    ip_file = args[0].ToString();
            else if (File.Exists(Environment.CurrentDirectory + "/iplist.txt"))
                ip_file = "iplist.txt";
            else
            {    
                Console.WriteLine("IP list does not exists. Program quit...");
                // TODO : exit program.
            }

            Console.WriteLine("adfasdf");

            // write ip information to ip_arry.
            //using (FileStream fs = new FileStream(ip_file, FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string sLine = sr.ReadLine();
            //            if (sLine.Length < 1)
            //            {
            //                continue;
            //            }
            //        }
            //    }
            //}

            // Define variables
            //var iplist = new string[] {
            //    "10.130.2.57", "10.130.2.241", "10.130.2.83",
            //    "10.130.2.65", "10.130.2.49", "10.130.2.238", "10.130.2.115",
            //    "10.130.2.190", "10.130.2.195", "10.130.2.244", "10.130.2.79",
            //    "10.130.2.197", "10.130.2.11", "10.130.2.162",
            //    "10.130.6.1", "10.130.2.120", "10.130.2.45", "10.130.2.152",
            //    "10.130.2.102", "10.130.2.59", "10.130.2.182", "11.130.65.22",
            //    "10.134.33.84"
            //};

            //ScanPort(iplist, ScanMode.MULTI);
        }

        /// <summary> 
        /// A help method for port scan
        /// </summary>
        /// <param name="iplist">IP list of remote host</param>
        /// <param name="Mode">Use single thread or multithread</param>
        public static void ScanPort(string[] iplist, ScanMode Mode)
        {
            if (Mode == ScanMode.SINGLE)
                SingleThreadScan(iplist);
            else if (Mode == ScanMode.MULTI)
                MultiThreadScan(iplist);
        }

        /// <summary>
        /// Use single thread to execue port scan
        /// </summary>
        /// <param name="iplist">IP list of remote host</param>
        public static void SingleThreadScan(string[] iplist)
        {
            foreach (var ip in iplist)
            {
                var ports = new int[] { 21, 80, 1033, 1034, 3000 };
                foreach (var port in ports)
                {
                    var result = util.CheckTcpPortConnect(ip.ToString(), port);
                    Console.WriteLine("{0}:{1} ->\t{2}",
                        ip,                             // host's ip address
                        port,                           // host's port
                        result ? "Active" : "Timeout"   // scan result
                    );
                }
            }
        }

        /// <summary>
        /// Use multi-thread to execute port scan
        /// </summary>
        /// <param name="iplist">IP list of remote host</param>
        public static void MultiThreadScan(string[] iplist)
        {
            Parallel.ForEach(iplist, ip =>
            {
                var ports = new int[] { 21, 80, 1033, 1034, 3000 };
                foreach (var port in ports)
                {
                    var result = util.CheckTcpPortConnect(ip, port);
                    Console.WriteLine("{0}:{1} ->\t{2}",
                        ip,                             // host's ip address
                        port,                           // host's port
                        result ? "Active" : "Timeout"   // scan result
                    );
                }
            });
        }

    }
}
