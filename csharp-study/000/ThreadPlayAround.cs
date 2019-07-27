using System;
using System.Collections.Generic;
using System.Threading;

namespace Jedi.DoNet2.Study.thread
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Get current thread
			Thread thisThread = Thread.CurrentThread;
			string name = thisThread.Name;
			
			// Output current thread information
			Console.WriteLine("Starting thread: " + name);
			Console.WriteLine(name + ": Current Culture = " + thisThread.CurrentCulture);
			
			// Output
			int interval = 3;
			for(int i = 1; i <= 8 * interval; i++)
				if( i % interval == 0)
					Console.WriteLine(name + ":count has reached " + i);
			
			// Program terminal
			Console.ReadLine();
		}
	}
}
