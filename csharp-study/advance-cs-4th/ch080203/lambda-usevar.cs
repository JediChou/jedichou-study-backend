using System;

class Program {
	static void Main() {
		int someVal = 5;
		Func<int, int> f = x => x + someVal;
		
		someVal = 7;
		Console.WriteLine(f(3));
	}
}