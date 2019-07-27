using System;
using System.Text;

class CSRegx_Sample007 {
	static void Main() {
		StringBuilder sb = new StringBuilder("Hot dog!");
		Console.WriteLine(sb.ToString());
		sb.Length = 3;
		Console.WriteLine(sb.ToString());

		// TODO the length change, but content dispear.
		sb.Length = 10;
		Console.Write(sb.ToString());
		Console.WriteLine("(ends)");
	}
}
