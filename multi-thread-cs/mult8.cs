// Without ThreadStart only with delegate
using System;
using System.Threading;
class Mult8 {
	static void Main() {
		var t1 = new Thread(delegate() {
			Console.WriteLine("Hello! t1.thread " + DateTime.Now);
		});
		var t2 = new Thread(delegate() {
			Console.WriteLine("Hello! t2.thread " + DateTime.Now);
		});
		t1.Start();
		t2.Start();
	}
}
