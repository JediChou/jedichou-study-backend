namespace Wrox.ProCSharp.SizeofOperator {
	using System;
	// class TestObj {}
	class Program {
		static void Main() {
			unsafe {
				Console.WriteLine(sizeof(int));
				// Console.WriteLine(sizeof(TestObj));
			}
		}
	}
}
