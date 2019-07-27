// sample0507
// Practical C# 2.0 and platform 4th, page 131
//   How to use lock keyword?
using System.Threading;

class Program {
	static long counter = 1;
	
	// Program start here!
	static void Main() {
		Thread t1 = new Thread(f1);
		Thread t2 = new Thread(f2);
		t1.Start(); t2.Start();
		t1.Join(); t2.Join();
	}  // End start

	// f1() method
	static void f1() {
		for(int i = 0; i < 5; i++) {
			lock( typeof(Program) ) { counter *= counter; }
			System.Console.WriteLine("f1() counter^2 {0}", counter);
			Thread.Sleep(10);
		}
	}  // end f1()

	// f2() method
	static void f2() {
		for(int i = 0; i < 5; i++) { counter *= 2; }
		System.Console.WriteLine("f2() counter*2 {0}", counter);
		Thread.Sleep(10);
	} // end f2()

}
