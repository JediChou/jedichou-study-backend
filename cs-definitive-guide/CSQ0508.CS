using System; class Program { public static void Main() {
	try { int myint = int.MaxValue; byte mybyte = (byte)myint;
		Console.WriteLine(mybyte);
	} catch (OverflowException) {throw;}
}}
