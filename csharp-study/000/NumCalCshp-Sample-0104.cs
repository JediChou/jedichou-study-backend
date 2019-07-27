/*
 * File name : NumCalCshp-Sample-0104.cs
 * Description : Avoid integer/float overflow
 */

namespace CSharpAlgorithm.Sample
{
	using System;
	
	class Sample0104
	{
		[STAThread]
		static void Main(string[] args)
		{
			//
			// Avoid integer overflow
			//
			int maxInt = 2147483647;
			int minInt = -2147483648;
			long a = (long)maxInt + 1;
			long b = (long)minInt - 1;
			long c = (long)maxInt * 2;
			
			Console.WriteLine("Avoid upper integer overflow ...");
			Console.WriteLine("maxInt = {0}", maxInt);
			Console.WriteLine("maxInt + 1 = {0}", a);
			Console.WriteLine("maxInt * 2 = {0}", c);
			Console.WriteLine("\n\nAvoid lower integer overflow ...");
			Console.WriteLine("minInt = {0}", minInt);
			Console.WriteLine("minInt - 1 = {0}", b);
			
			//
			// Avoid float overflow
			//
			float maxFloat = 3.4028235E38f;
			double u = (double)maxFloat * 2;
			Console.WriteLine("\n\nAvoid Float overflow ...");
			Console.WriteLine("maxFloat = {0}", maxFloat);
			Console.WriteLine("maxFloat * 2 = {0}", u);
			
			Console.WriteLine("\nPress any key to exit.");
			Console.ReadLine();
		}
	}
}
