using System;
class ProgramP102_1
{
	static void Main()
	{
		Int32 i = 5; 			// Int32->Int32
		Int64 l = i;			// Int32->Int64
		Single s = i;			// Int32->Single
		Byte b = (Byte) i;		// Int32->Byte
		Int16 v = (Int16) s;	// Single->Int16
		
		Console.WriteLine(i);
		Console.WriteLine(l);
		Console.WriteLine(s);
		Console.WriteLine(b);
		Console.WriteLine(v);
	}
}
