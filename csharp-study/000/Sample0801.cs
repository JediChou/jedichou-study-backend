using System;
using System.Runtime.InteropServices;

class program
{
	[DllImport("Kernel32.dll")]
	public static extern bool Beep(uint iFreq, uint iDuration);

	static void Main() {
		bool b = Beep(100, 100);
		Console.WriteLine(b);
	}
}
