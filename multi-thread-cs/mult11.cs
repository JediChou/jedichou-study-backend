// ¸ø¾€³ÌÃüÃû
using System;
using System.Threading;
class Mult11 {
	static void Main() {
		Thread.CurrentThread.Name = "main";
		Thread worker = new Thread(Go);
		worker.Name = "worker";
		worker.Start();
		Go();
	}
	static void Go() {
		Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
	}
}
