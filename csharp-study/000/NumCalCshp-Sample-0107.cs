/*
 * File name : NumCalCshp-Sample-0107.cs
 * Description : Do not Use reference pass, use array.
 */

namespace CSharpAlgorithm.Sample
{
	using System;
	
	class Sample0107
	{
		/// <summary>
		/// Swap first array and second array. Successful.
		/// </summary>
		/// <param name="a">First array</param>
		/// <param name="b">Second array</param>
		public static void swap(int[] a, int[] b)
		{
			int c = a[0];
			a[0] = b[0];
			b[0] = c;
			
			Console.WriteLine("\nInside swap function : ");
			Console.WriteLine("a = {0}", a[0]);
			Console.WriteLine("b = {0}", b[0]);
		}
		
		/// <summary>
		/// Swap first number and second number. Failed.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static void swap2(int[] a, int[] b)
		{
			int[] c = new int[1];
			c = a;
			a = b;
			b = c;
			
			Console.WriteLine("\nInside swap2 function : ");
			Console.WriteLine("a = {0}", a[0]);
			Console.WriteLine("b = {0}", b[0]);
		}
		
		[STAThread]
		static void Main(string[] args)
		{
			int[] a = { 2 };
			int[] b = { 100 };
			
			// Before swap
			Console.WriteLine("Before swap");
			Console.WriteLine("a = {0}", a[0]);
			Console.WriteLine("b = {0}", b[0]);
			
			// call swap()
			swap(a, b);
			
			Console.WriteLine("\nAfter swap() call");
			Console.WriteLine("a = {0}", a[0]);
			Console.WriteLine("b = {0}", b[0]);
			
			// call swap2()
			swap2(a, b);
			
			// After swap
			Console.WriteLine("\nAfter swap2 call");
			Console.WriteLine("a = {0}", a[0]);
			Console.WriteLine("b = {0}", b[0]);
			
			Console.WriteLine("\nPress any key to exit.");
			Console.ReadLine();
		}
	}
}
