// thread stack & heap
using System;

class SomeRef { public Int32 x; }
struct SomeVal { public Int32 x; }

class ProgramP107 {
	static void Main() {
		SomeRef r1 = new SomeRef();		// On the heap
		SomeVal v1 = new SomeVal();		// On the thread stack
		r1.x = 5;						// get pointer
		v1.x = 5;						// modify at thread stack
		Console.WriteLine(r1.x);		// echo 5
		Console.WriteLine(v1.x);		// echo 5 too

		SomeRef r2 = r1;				// only copy pointer or reference
		SomeVal v2 = v1;				// full copy at thread stack
		r1.x = 8;						// r1.x, r2.x will be modify
		v1.x = 9;						// v1.x modified, v2.x not change
		Console.WriteLine(r1.x);		// echo 8
		Console.WriteLine(r2.x);		// echo 8
		Console.WriteLine(v1.x);		// echo 9
		Console.WriteLine(v2.x);		// echo 5
	}
}
