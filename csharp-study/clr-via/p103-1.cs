// unchecked
using System;
class ProgramP103_1 {
	static void Main() {
		UInt32 invalid = unchecked((UInt32)(-1));  // ok
		Console.WriteLine(invalid);
	}
}
