namespace Wrox.ProCSharp.UncheckedOperator
{
	using System;

	class Program {
		static void Main() {
			byte b = 255;
			unchecked { b++; }
			Console.WriteLine(b.ToString());
		}
	}
}
