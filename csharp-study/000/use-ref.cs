using System;
class Program {

	static void Main() {
		int a = 3;
		int b = 4;

		int c = add(ref a, ref b);

		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
	}

	static int add( ref int a, ref int b) {
		int c = a + b;
		a = a + 2;
		b = b + 2;
		return c;
	}
}
