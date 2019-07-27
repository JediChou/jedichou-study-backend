// sample0514.cs
// how to use event.
using System;
using System.Threading;
class Program {
	static EventWaitHandle[] events;
	static void Main() {
		events = new EventWaitHandle[2];
		// Initial event state : false
		events[0] = new EventWaitHandle(false, EventResetMode.AutoReset);
		events[1] = new EventWaitHandle(false, EventResetMode.AutoReset);
		Thread t0 = new Thread(ThreadProc0);
		Thread t1 = new Thread(ThreadProc1);
		t0.Start(); t1.Start();
		AutoResetEvent.WaitAll(events);
		Console.WriteLine("MainThread: Thread0 reached 2" +
						  " and Thread1 reached 3.");
		t0.Join(); t1.Join();
	}
	static void ThreadProc0() {
		for(int i=0; i<5; i++) {
			Console.WriteLine("Thread0: {0}", i);
			if (i==2) events[0].Set();
			Thread.Sleep(100);
		}
	}
	static void ThreadProc1() {
		for(int i=0; i<5; i++) {
			Console.WriteLine("Thread1: {0}", i);
			if(i==3) events[1].Set();
			Thread.Sleep(60);
		}
	}
}
