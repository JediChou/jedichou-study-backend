// magzine-200907-tuple02.cs
// �ɱ��룬��ִ�лᱨ��������ϢΪ��
// Unhandled Exception: 
//   System.InvalidCastException: Specified cast is not valid.

using System;
class Program
{
	static void Main()
	{
		object[] t = new object[2];
		t[0] = "Hello";
		t[1] = "World";
		PrintStringAndInt((string) t[0], (int) t[1]);
	}

	static void PrintStringAndInt(string s, int i)
	{
		Console.WriteLine("{0} {1}", s, i);
	}
}
