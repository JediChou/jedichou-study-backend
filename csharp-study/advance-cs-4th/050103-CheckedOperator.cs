namespace Wrox.ProCSharp.CheckedOperator
{
	using System;
	
	class Program {
		public static void Main(string[] args) {
			byte a = 255;
			checked { a++; }
			Console.WriteLine(a.ToString());
		}
	}
}

