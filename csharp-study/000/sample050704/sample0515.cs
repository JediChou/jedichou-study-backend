// sample0515.cs
// how to use System.Threading.Semaphore
using System;
using System.Threading;
class Program {
	static Semaphore semaphore;
	static void Main() {
		// Initial number of free slots: 2.
		// Maximal number of slots used simulteanously: 5.
		// Number of slot owned by the main thread: 3 (5-2).
		semaphore = new Semaphore(2, 5);
		for( int i=0; i<3; ++i) {
			Thread t = new Thread(WorkProc);
			t.Name = "Thread" + i;
			t.Start();
			Thread.Sleep(30);
		}
	}
	static void WorkProc() {
		for( int j=0; j<3; j++) {
			semaphore.WaitOne();
			Console.WriteLine(Thread.CurrentThread.Name+": Begin");
			Thread.Sleep(200);  // Simulate a 200 millseconds task.
			Console.WriteLine(Thread.CurrentThread.Name + ": End");
			semaphore.Release();
		}
	}
}
