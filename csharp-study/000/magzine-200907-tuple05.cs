// magzine-200907-tuple05.cs
// ͨ��������������Tuple
// Jedi: ��Ϊ���㡢���

using System;
class Program
{
	static void Main()
	{
		var t = Tuple.Create("Hello", 4);
		PrintStringAndInt(t.Item1, t.Item2);
	}

	static void PrintStringAndInt(string s, int i)
	{
		Console.WriteLine("{0} {1}", s, i);
	}
}
