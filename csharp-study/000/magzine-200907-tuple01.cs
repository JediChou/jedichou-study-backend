// magzine-200907-tuple01.cs
// ��һ�ζ�ȡ�鷳����������Ҳ����ȫ�Ĵ���
// Jedi: Ҫװ��Ͳ���

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
