/*
 * File name : NumCalCshp-Sample-0102.cs
 * Description : 精度不足導致違反代數結合律的糾正
 */

namespace CSharpAlgorithm.Sample
{
	using System;
	
	class Sample0102
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("精度不足導致違反代數結合律的糾正\n");
			
			float a = 1.0f;
			float b = 7.842357E-10f;
			float c = 3.170807E-09f;
			
			Console.WriteLine("a = " + a);
			Console.WriteLine("b = " + b);
			Console.WriteLine("c = " + c);
			Console.WriteLine("(a+b)+c = " + (a+b)+c);
			Console.WriteLine("a+(b+c) = " + a+(b+c));
			
			float eps = 1.0E-05f;
			if( ((a+c)+c) - (a+(b+c)) < eps)
				Console.WriteLine(" ==> 滿足要求");
			else
				Console.WriteLine(" ==> 精度不足");
			
			Console.WriteLine("\nPress any key to exit.");
			Console.ReadLine();
		}
	}
}