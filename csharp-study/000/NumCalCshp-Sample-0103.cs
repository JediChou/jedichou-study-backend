/*
 * File name : NumCalCshp-Sample-0103.cs
 * Description : 精度不足導致違反代數結合律的糾正
 */

namespace CSharpAlgorithm.Sample
{
	using System;
	
	class Sample0103
	{
		[STAThread]
		static void Main(string[] args)
		{
			//
			// Integer overflow
			//
			int maxInt = 2147483647;
			int minInt = -2147483648;
			int a = maxInt + 1;
			int b = minInt - 1;
			int c = maxInt * 2;
			
			Console.WriteLine("Integer overflow ...");
			Console.WriteLine("maxInt = {0}", maxInt);
			Console.WriteLine("minInt = {0}", minInt);
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.WriteLine("c = {0}", c);
			
			//
			// Float overflow
			//
			float maxFloat = 3.4028235E38f;
			float u = maxFloat * 2;
			Console.WriteLine("\n\nFloat overflow ...");
			Console.WriteLine("maxFloat = {0}", maxFloat);
			Console.WriteLine("u = {0}", u);
			
			Console.WriteLine("\nPress any key to exit.");
			Console.ReadLine();
		}
	}
}
