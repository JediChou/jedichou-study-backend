using System;
class Program {
	static void Main() {
		int i = 10;
		SetToFive(out i);
		Console.WriteLine(i);

		int t;
		//AddFive(t);
	}

	//static void AddFive(ref int i) { i + 5;}
	static void SetToFive(out int i) { i = 5; }
}
