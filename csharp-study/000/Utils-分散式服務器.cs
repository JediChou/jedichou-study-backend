using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.IO;
using System.Configuration;

namespace POSign.AsynCommitCommon
{
    public class Utils
    {
        private static void DumpTypeEntries(Array arr)
        {
            foreach (object obj in arr)
            {
                Print("  {0}: {1}", obj.GetType().Name, obj);
            }
        }

        public static void DumpAllInfoAboutRegisteredRemotingTypes()
        {
            Print("ALL REGISTERED TYPES IN REMOTING -(BEGIN)---------");

            DumpTypeEntries(RemotingConfiguration.GetRegisteredActivatedClientTypes());
            DumpTypeEntries(RemotingConfiguration.GetRegisteredActivatedServiceTypes());
            DumpTypeEntries(RemotingConfiguration.GetRegisteredWellKnownClientTypes());
            DumpTypeEntries(RemotingConfiguration.GetRegisteredWellKnownServiceTypes());

            Print("ALL REGISTERED TYPES IN REMOTING -(END)  ---------");
        }

        public static void Print(string text, params object[] args)
        {
            DoLog("", text, args);
        }

        public static void Info(string text, params object[] args)
        {
            DoLog("INFO ", text, args);
        }

        public static void Warning(string text, params object[] args)
        {
            DoLog("WARNING ", text, args);
        }

        public static void Error(string text, params object[] args)
        {
            DoLog("!!!ERROR!!! ", text, args);
        }

        public static void WaitForEnter()
        {
            WaitForEnter("Press ENTER to continue...");
        }

        public static void WaitForEnter(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(prompt);
            string sWait = Console.ReadLine();
            while (sWait != "EXIT")
            {
                sWait = Console.ReadLine();
            }
        }

        private static void DoLog(string prefix, string text, params object[] args)
        {
            // For newer .NET Frameworks you should use 
            // "System.Threading.Thread.CurrentThread.ManagedThreadId()"
            // as "AppDomain.GetCurrentThreadId()" is depreceted
            // there. But unfortunately it is not available in .NET v.1.1
            int threadId = AppDomain.GetCurrentThreadId();
            Console.Write("[{0:D4}] [{1}] ",
                threadId,
                DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            Console.Write(prefix);
            Console.WriteLine(text, args);
        }
        public static void SaveLog(string strError)
        {
            try
            {
                string strCurrentDir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
                if (System.IO.Directory.Exists(strCurrentDir) == false)
                    System.IO.Directory.CreateDirectory(strCurrentDir);
                string strAppend = "";
                string FfileName = string.Format("{0:yyyyMMdd}", System.DateTime.Now) + ".Log";
                StreamWriter strWriter = new StreamWriter(System.IO.Path.Combine(strCurrentDir, FfileName), true);
                strAppend = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": " + strError;
                strWriter.WriteLine(strAppend);
                strWriter.Close();
                return;
            }
            catch (System.Exception r)
            {
                return;
            }
        }
        public static IAsynCommit GetMyBestService(string File_ID)
        {
            try
            {
                string sServers = ConfigurationManager.AppSettings.Get("AsynCommitServers");
                if (string.IsNullOrEmpty(sServers))
                    return null;

                string sServerSelect = allocateByFileID(File_ID, sServers);

                IAsynCommit Service1 = null;

                bool helloOK = false;
                try
                {
                    Service1 = Activator.GetObject(typeof(IAsynCommit), sServerSelect) as IAsynCommit;
                    helloOK = Service1.SayHello().ToLower() == "hello!" ? true : false;
                }
                catch { Service1 = null; }
                while (!helloOK)
                {
                    sServers = sServers.Replace(sServerSelect, "").Replace(",,", ",").TrimStart(',').TrimEnd(',');
                    sServerSelect = allocateByFileID(File_ID, sServers);
                    try
                    {
                        Service1 = Activator.GetObject(typeof(IAsynCommit), sServerSelect) as IAsynCommit;
                        helloOK = Service1.SayHello().ToLower() == "hello!" ? true : false;
                    }
                    catch { Service1 = null; }
                }

                return Service1;
            }
            catch (Exception ex)
            {
                SaveLog(ex.Message);
                return null;
            }
        }
        private static string allocateByFileID(string sFile_ID, string sServers)
        {
            int iServerNo = 0;
            string[] sServerList = sServers.Split(',');
            try
            {
                int iFileIdHashCode = Math.Abs(sFile_ID.GetHashCode());
                iServerNo = Math.Abs(iFileIdHashCode % sServerList.Length);
            }
            catch (Exception ex)
            {
                SaveLog(ex.Message);
            }
            return sServerList[iServerNo];
        }


    }
}
