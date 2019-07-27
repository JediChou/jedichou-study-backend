using System;
using System.Threading;

class Mult7 {
	static void Main() {
		// 单个线程的时候不需要ThreadStart
		// 会被自动推断出来
		var t = new Thread(Go);
		t.Start();
	}
	static void Go() {
		Console.WriteLine("This is a test for c# thread.");
	}
}
