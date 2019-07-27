namespace CLR.pg81
{
	using System;

	class pg81_class1 {}
	class pg81_class2 : System.Object {}

	class ProgramPage81 {
		static void Main() {
			var a = new pg81_class1();
			var b = new pg81_class1();
			var c = a;

			// a same as c
			Console.WriteLine( a == c );
			Console.WriteLine( a.Equals(c));

			// a diff b
			Console.WriteLine(a == b);
			Console.WriteLine(a.Equals(b));
		}
	}
}
