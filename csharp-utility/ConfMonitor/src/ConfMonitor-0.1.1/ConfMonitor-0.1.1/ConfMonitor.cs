using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;

namespace ConfMonitor
{
    public partial class ConfMonitor : ServiceBase
    {
        #region ConfMonitor Service fields

        /// <summary>
        /// 初始Timer
        /// </summary>
        static System.Timers.Timer timer = new System.Timers.Timer();

        /// <summary>
        /// 獲得當前Conf信息的Timer
        /// </summary>
        static System.Timers.Timer timerGetCurrentPid = new System.Timers.Timer();

        private static int _firstTimerPid;
        private static int _secondTimePid;

        /// <summary>
        /// 輪詢時獲得的第一個Pid
        /// </summary>
        public static int FirstTimerPid
        {
            get { return _firstTimerPid; }
            set { _firstTimerPid = value; }
        }

        /// <summary>
        ///  輪詢時獲得的第二個Pid
        /// </summary>
        public static int SecondTimePid
        {
            get { return _secondTimePid; }
            set { _secondTimePid = value; }
        }

        #endregion

        #region ConfMonitor Service Helper method

        /// <summary>
        /// 獲得指定進程的系統Pid
        /// </summary>
        private static int GetProcessPid(string name)
        {
            int pid = -1;
            Process[] pp = Process.GetProcessesByName(name);

            for (int i = 0; i < pp.Length; i++)
            {
                if (pp[i].ProcessName == name)
                {
                    pid = pp[i].Id;
                    break;
                }
            }
            return pid;
        }

        /// <summary>
        /// 殺死指定Pid的進程
        /// </summary>
        private static bool KillProcessByPid(int pid)
        {
            Process[] pp = Process.GetProcesses();
            for (int i = 0; i < pp.Length; i++)
            {
                if (pp[i].Id == pid)
                {
                    pp[i].Kill();
                    break;
                }
            }
            return true;
        }

        // <summary>
        // 獲得Conf當前是否處於連接狀態
        // </summary>
        private static bool GetConfStatus()
        {
            // assume conf is dis-alive
            bool netmeetingPortStatus = false;

            // get 'netstat -an -p tcp' ouput text
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "netstat";
            p.StartInfo.Arguments = " -an -p tcp";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            // save output text to a list<string> object
            List<string> outputList = new List<string>(output.Split('\n'));
            foreach (string line in outputList)
            {
                bool tempCheckResult = Regex.IsMatch(line, @"\s*TCP\s*\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b:\d{1,5}\s*\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b:1503\s*ESTABLISHED");
                netmeetingPortStatus = netmeetingPortStatus || tempCheckResult;
            }

            // return conf status
            return netmeetingPortStatus;
        }

        /// <summary>
        /// 輪詢Timer的事件
        /// </summary>
        private static void TimerEventProcessor(Object source, ElapsedEventArgs e)
        {
            FirstTimerPid = GetProcessPid("conf");

            if (SecondTimePid != -1)
            {
                Thread.Sleep(20000);
                if (FirstTimerPid == SecondTimePid && !GetConfStatus())
                {
                    int confPort = GetProcessPid("conf");
                    KillProcessByPid(confPort);
                }
            }
        }

        /// <summary>
        /// 獲得當前Conf進程Pid的Timer事件
        /// </summary>
        private static void CheckCurrentConfPid(Object source, ElapsedEventArgs e)
        {
            SecondTimePid = GetProcessPid("conf");
        }

        #endregion

        #region Windows Service Method

        /// <summary>
        /// ConfMonitor的構造函數
        /// </summary>
        public ConfMonitor()
        {
            InitializeComponent();
            FirstTimerPid = GetProcessPid("conf");
        }

        /// <summary>
        /// 服務啟動後的事件
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            timer.Elapsed += new ElapsedEventHandler(TimerEventProcessor);
            timer.Interval = 20000;
            timer.Start();

            timerGetCurrentPid.Elapsed += new ElapsedEventHandler(CheckCurrentConfPid);
            timerGetCurrentPid.Interval = 1000;
            timerGetCurrentPid.Start();
        }

        /// <summary>
        /// 服務停止後的事件
        /// </summary>
        protected override void OnStop()
        {
            timer.Stop();
            timerGetCurrentPid.Stop();
        }

        #endregion
    }
}