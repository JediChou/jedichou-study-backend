using System;

namespace ProgramingCSharp4 {
	class BaseClass {
		public string FieldA = "I'm baseclass";
		public static string StaticFieldB = "I'm static field from baseclass";
		public void SayHi() { Console.WriteLine("Hi! I'm baseclass"); }
	}

	// Hide field, static field, function in the child class.
	class ChildClass : BaseClass {
		new public int FieldA = 100;
		new public static string StaticFieldB = "I'm static field from childclass";
		new public string SayHi() {Console.WriteLine("I'm child"); return null;}
	}

	class Program {
		public static void Main() {
			var child = new ChildClass();
			Console.WriteLine(child.FieldA);
			Console.WriteLine(ChildClass.StaticFieldB);
			child.SayHi();
		}
	}
}
