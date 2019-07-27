// File name: nsalias.cs
// Description: How to use namespace alias.

using System;
using Becky = JediChou;

namespace JediChou
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine(Becky.Util.getSomething());
		}
	}

	public class Util
	{
		public static string getSomething()
		{
			return "Util.";
		}
	}
}
