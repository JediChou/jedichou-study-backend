using System; class Program { public static void Main() {
	try { int myint = int.MaxValue; byte mybyte = checked((byte)myint);
	} catch (OverflowException) {throw;}
}}
