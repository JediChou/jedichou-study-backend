using System;
using System.Threading;

class ThreadTest {
	static void Main() {
		var t = new Thread(WriteY);
		t.Start();
		while(true) Console.Write("x");
	}

	static void WriteY() {
		while (true) Console.Write("y");
	}
}
