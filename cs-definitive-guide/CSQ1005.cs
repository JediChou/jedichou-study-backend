using System;

namespace ProgramingCSharp4 {
	class BaseClass {public string field = "Base"; }
	class ChildClass : BaseClass {
		new public string field = "Child";
		public void Print() {
			Console.WriteLine(field);
			Console.WriteLine(base.field);
		}
	}

	class Program { public static void Main() {
		var child = new ChildClass();
		child.Print();
	}}
}
