using System;
using System.Threading;
class Mult3 {
	static bool done;
	static void Main() {
		new Thread (Go).Start();
		Go();
	}
	static void Go() {
		if (!done) { Console.WriteLine("Done"); done = true;}
	}
}
