using System;
struct SomeValue { public Int32 x; }
class ProgramP108 {
	static void Main() {
		SomeValue v1 = new SomeValue();
		v1.x = 20;
		Int32 a = v1.x;
		Console.WriteLine(a);
	}
}
