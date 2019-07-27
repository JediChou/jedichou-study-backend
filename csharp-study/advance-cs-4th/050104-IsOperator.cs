namespace Wrox.ProCSharp.IsOperator{
	using System;

	class Tester {}
	class Program {
		static void Main() {
			var b = new object();
			var c = new Tester();
			if (b is object && c is object) {
				Console.WriteLine("b is an object");
				Console.WriteLine("c is an object");
			}
		}
	}
}
