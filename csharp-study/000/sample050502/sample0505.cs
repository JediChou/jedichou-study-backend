// Two threads at same time to set a variable.
// The Practical C# 2.0 and Platform, Page 129
// Date: 2015-1-13, 14:48

using System.Threading;
class Program {
	static long counter = 1;

	static void Main() {
		Thread t1 = new Thread(f1);
		Thread t2 = new Thread(f2);
		t1.Start(); t2.Start(); t1.Join(); t2.Join();
	}

	static void f1() {
		for(int i=0; i<5; i++) {
			Interlocked.Increment(ref counter);
			System.Console.WriteLine("counter++ {0}", counter);
			Thread.Sleep(10);
		}
	}

	static void f2() {
		for(int i=0; i<5; i++) {
			Interlocked.Decrement(ref counter);
			System.Console.WriteLine("counter-- {0}", counter);
			Thread.Sleep(10);
		}
	}
}
