/*
 * File name : NumCalCshp-Sample-0105.cs
 * Description : Basic type cannot not implement reference pass.
 */

namespace CSharpAlgorithm.Sample
{
	using System;
	
	class Sample0105
	{
		/// <summary>
		/// Swap first number and second number.
		/// </summary>
		/// <param name="a">First number</param>
		/// <param name="b">Second number</param>
		public static void swap(int a, int b)
		{
			int c = a;
			a = b;
			b = c;
			
			Console.WriteLine("\nInside swap function : ");
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
		}
		
		[STAThread]
		static void Main(string[] args)
		{
			int a = 2;
			int b = 100;
			
			// Before swap
			Console.WriteLine("Before swap");
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			
			// call swap()
			swap(a, b);
			
			// After swap
			Console.WriteLine("\nAfter swap");
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			
			Console.WriteLine("\nPress any key to exit.");
			Console.ReadLine();
		}
	}
}
