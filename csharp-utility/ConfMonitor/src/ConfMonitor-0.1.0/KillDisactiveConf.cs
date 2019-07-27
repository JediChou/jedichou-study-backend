// complie command:
// C:\Windows\Microsoft.NET\Framework\v2.0.50727>csc /out:d:\ConfMonitor.exe d:\temp\Netmeeting\KillDisactiveConf.cs


using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;

class Program {

	static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
	static System.Windows.Forms.Timer timerGetCurrentPid = new System.Windows.Forms.Timer();
	static bool exitFlag = false;
	private static int _firstTimerPid;
	private static int _secondTimePid;
	
	public static int FirstTimerPid { 
		get {return _firstTimerPid;}
		set {_firstTimerPid = value;}
	}
	
	public static int SecondTimePid { 
		get {return _secondTimePid;} 
		set {_secondTimePid = value;} 
	}
	
	/// <summary>
	/// Get process's pid
	/// </summary>
	private static int GetProcessPid(string name) {
		int pid = -1;
		Process[] pp = Process.GetProcessesByName(name);
		
		for (int i = 0; i < pp.Length; i++) {
			if (pp[i].ProcessName == name) {
				pid = pp[i].Id;
				break;
			}
		}
		return pid;
	}

	/// <summary>
	/// Kill process by pid
	/// </summary>
	private static bool KillProcessByPid(int pid) {
		Process[] pp = Process.GetProcesses();
		for (int i = 0; i < pp.Length; i++) {
			if ( pp[i].Id == pid ) {
				pp[i].Kill();
				break;
			}
		}
		return true;
	}


	/// <summary>
	/// Get conf active status
	/// </summary>
	private static bool GetConfStatus()	{
		
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
		foreach(string line in outputList) {
			bool tempCheckResult = Regex.IsMatch(line, @"\s*TCP\s*\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b:\d{1,5}\s*\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b:1503\s*ESTABLISHED");
			netmeetingPortStatus = netmeetingPortStatus || tempCheckResult;
		}

		// return conf status
		return netmeetingPortStatus;
	}

	/// <summary>
	/// timer event delegate
	/// </summary>
	private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs) {
			
		Console.WriteLine("Now is '{0}', ", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
		FirstTimerPid = GetProcessPid("conf");
		
		//if ( SecondTimePid != -1 && FirstTimerPid == SecondTimePid && !currentConfStatus) {
		//	Console.WriteLine("netmeeting disconnected.");
		//	int confPort = GetProcessPid("conf");  // 1868
		//	KillProcessByPid(confPort);
		//}		
		
		if ( SecondTimePid != -1 ) {

			Thread.Sleep(20000);
			
			if ( FirstTimerPid == SecondTimePid && !GetConfStatus()) {
				Console.WriteLine("netmeeting disconnected.");
				int confPort = GetProcessPid("conf");
				KillProcessByPid(confPort);
			}
		} 
	}
	
	/// <summary>
	/// time event
	/// </summary>
	private static void CheckCurrentConfPid(Object myObject, EventArgs myEventArgs) {
		SecondTimePid = GetProcessPid("conf");
	}

	/// <summary>
	/// Program start here!
	/// </summary>
	public static void Main(string[] args) {
		
		timer.Tick += new EventHandler(TimerEventProcessor);
		timer.Interval = 20000;
		timer.Start();
		
		timerGetCurrentPid.Tick += new EventHandler(CheckCurrentConfPid);
		timerGetCurrentPid.Interval = 1000;
		timerGetCurrentPid.Start();
		
		FirstTimerPid = GetProcessPid("conf");
		
		while(exitFlag == false) {
			Application.DoEvents();
		}
	}
}

