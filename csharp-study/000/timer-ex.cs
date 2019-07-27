using System;
using System.Timers;

namespace TimerEx {
	public class Program {
		static void Main(string[] args) {
			var timer = new Timer();
			timer.Enabled = true;
			timer.Interval = 1000;
			timer.Start();
			timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);

			Console.WriteLine("The program started");
		}
		
		private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			  //我是定时执行的方法
		}
	}
}
