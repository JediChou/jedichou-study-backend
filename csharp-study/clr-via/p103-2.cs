// checked
using System;
class ProgramP103_2 {
	static void Main() {
		Byte b = 100;
		b = checked((Byte)(b+200));  // OverflowException
		Console.WriteLine(b);
	}
}
