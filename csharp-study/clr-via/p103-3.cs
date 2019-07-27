// use checked block
using System;
class ProgramP103_3 {
	static void Main() {
		checked {
			Byte b = 100;
			b = (Byte) (b+200);
			Console.WriteLine(b);
		}
	}
}
