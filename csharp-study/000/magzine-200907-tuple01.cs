// magzine-200907-tuple01.cs
// 这一段读取麻烦，而且类型也不安全的代码
// Jedi: 要装箱和拆箱

using System;
class Program
{
	static void Main() {
		object[] t = new object[2];
		t[0] = "Hello";
		t[1] = 4;
		PrintStringAndInt((string) t[0], (int) t[1]);
	}

	static void PrintStringAndInt(string s, int i) {
		Console.WriteLine("{0} {1}", s, i);
	}
}
