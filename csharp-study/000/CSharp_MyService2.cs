// Filename: MyService2.cs
// Description: How to - use programming to write windows service.

using System;
using System.ServiceProcess;

namespace MyService2
{
	public class UserService1 : System.ServiceProcess.ServiceBase
	{
		public UserService1()
		{
			this.ServiceName = "MyService2";
			this.CanStop = true;
			this.CanPauseAndContinue = true;
			this.AutoLog = true;
		}
		
		protected override void OnStart(string[] args)
		{
			// Do nothing
		}

		public static void Main()
		{
			System.ServiceProcess.ServiceBase.Run(new UserService1());
		}
	}
}
