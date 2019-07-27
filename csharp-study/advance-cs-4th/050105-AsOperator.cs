namespace Wrox.ProCSharp.AsOperator {
	using System;
	class Program {
		static void Main() {
			object o1 = "Some String", o2 = 5;
			var s1 = o1 as string;
			var s2 = o2 as string;
			Console.WriteLine("{0}{1}", s1, s2);
		}
	}
}
