using System;
class Program {
	public static void Main() {
		int? c = null;
		if(c.HasValue)
			Console.WriteLine(c.HasValue);
		else
			Console.WriteLine("Without value");
	}
}
