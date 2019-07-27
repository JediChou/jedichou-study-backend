using System;
class Class1 {}
class Class2 {
	public void Method1(string s) {
		Console.WriteLine("Class2.Method1");
	}
}
class Class3 {
	public void Method(int i) {
		Console.WriteLine("Class3.Method1");
	}
}
class Class4 {
	public void Method(int i) {
		Console.WriteLine("Class4.Method1");
	}
}
static class Extensions {
	static public void Method(this object o, int i) {
		Console.WriteLine("Extensions.Method1");
	}
	static void Main() {
		new Class1().Method1(12);
		new Class2().Method1(12);
		new Class3().Method1(12);
		new Class4().Method1(12);
	}
}
