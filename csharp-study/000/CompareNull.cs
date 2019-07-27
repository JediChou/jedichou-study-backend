using System;
using System.IO;

class CompareNull {
	static void Main(string[] args) {
		object a = null;
		if (a == null) Console.WriteLine("a is null");
		else Console.WriteLine("can use a==null to compare null reference");
	}
}
