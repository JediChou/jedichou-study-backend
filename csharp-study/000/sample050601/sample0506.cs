using System.Threading;
class Program {
	static long counter = 1;
	
	// Program start here
	static void Main() {
		Thread t1 = new Thread(f1);
		Thread t2 = new Thread(f2);
		t1.Start(); t2.Start();
		t1.Join(); t2.Join();
	}

	// f1()
	static void f1() {
		Monitor.Enter( typeof(Program) );
		try {
			counter *= counter;
		}
		finally { Monitor.Exit(typeof(Program)); }
		System.Console.WriteLine("counter^2 {0}", counter);
		Thread.Sleep(10);
	}  // end f1()

	// f2()
	static void f2() {
		for(int i=0; i<5; i++) {
			Monitor.Enter( typeof(Program) );
			try {
				counter *= 2;
			}
			finally { Monitor.Exit(typeof(Program)); }
			System.Console.WriteLine("counter*2 {0}", counter);
			Thread.Sleep(10);
		}
	}  // end f2()

}
