using System.Threading;
class Program {
	static void f1() { System.Console.WriteLine("f1"); }
	void f2() {	System.Console.WriteLine("f2"); }
	static void f3(object obj) { System.Console.WriteLine("f3 obj = {0}", obj); }

	static void Main() {
		// Explicitly specify the delegate class 'ThreadStart'.
		Thread t1 = new Thread( new ThreadStart(f1) );

		Program program = new Program();
		// Here, we use the C#2 facility to infer the delegate
		// class 'ThreadStart' from the definition of the 'Thread'
		// class constructor without argument.
		Thread t2 = new Thread(program.f2);

		// Here, the c#2 compiler infer the delegate class
		// 'ParameterizedThreadStart' since the 'f3()' method
		// accept an 'object' parameter.
		Thread t3 = new Thread(f3);

		t1.Start(); t2.Start(); t3.Start("hello");
		t1.Join(); t2.Join(); t3.Join();
	}
}
