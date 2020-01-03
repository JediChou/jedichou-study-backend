using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SXLibrary;
using System.Threading;


namespace WriteLog
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i=0; i<10; i++)
            {
                //var strLogMessage = string.Format(
                //    "{0} - Jedi write log message", 
                //    DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                //);
                Log.WriteDebugLog("debug" + i);
                Log.WriteErrorLog("error" + i);
                Log.WriteInfoLog("info" + i);
                //Thread.Sleep(5);
            }
        }
    }
}
