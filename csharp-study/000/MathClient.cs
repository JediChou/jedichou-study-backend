// File name: MathClient.cs
// Description: How to use dll.
// Date & time: 2014-7-22 13:45

using System;
using JC = Wrox.ProCSharp.Basics;

namespace JediUseDLL
{
	public class Program
	{
		public static void Main()
		{
			var ml = new JC.MathLib();
			Console.WriteLine(ml.Add(2, 3));
			Console.WriteLine(ml.Sub(8, 4));
		}
	}
}
