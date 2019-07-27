using System;
using System.Runtime.InteropServices;
class Program {
	
	[DllImport("Kernel32.dll", EntryPoint="Beep")]
	public static extern bool MyBeep(uint iFreq, uint iDuration);

	static void Main() {
		bool b = MyBeep(100, 100);
	}

	public static bool Beep(uint iFreq, uint iDuration) {
		Console.WriteLine("Program.Beep()");
		return new bool();
	}
}
