using System;
using System.Threading;
using System.Diagnostics;

namespace GetCounter
{
	public class Program
	{
		public static void Main(string[] args)
		{
			PerformanceCounter pc1 = new PerformanceCounter("Processor","% Processor Time","_Total"); 
			
			for(int i=0; i<100; i++) {
				Threading
				Console.WriteLine(pc1.NextValue());
			}
			
			Console.ReadLine();
		}
	}
}