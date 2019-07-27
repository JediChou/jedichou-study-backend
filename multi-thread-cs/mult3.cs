using System;
using System.Threading;
class Mult3 {
	bool done;
	static void Main() {
		var mul3 = new Mult3();	
		new Thread (mul3.Go).Start();
		mul3.Go();
	}
	void Go() {
		if (!done) { done = true; Console.WriteLine("Done");}
	}
}
