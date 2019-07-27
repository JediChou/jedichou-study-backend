using System;
using System.Threading;
class Mult12 {
	static void Main(string[] args) {
		Thread worker = new Thread (delegate() {
			Console.ReadLine();
		});
		if (args.Length > 0) worker.IsBackground = true;
		worker.Start();
	}
}
