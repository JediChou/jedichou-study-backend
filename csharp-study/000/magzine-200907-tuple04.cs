// magzine-200907-tuple04.cs
// 通过弱类型来定义Tuple

using System;
class Program
{
	static void Main()
	{
		var t = new Tuple<string, int>("Hello", 4);
		PrintStringAndInt(t.Item1, t.Item2);
	}

	static void PrintStringAndInt(string s, int i)
	{
		Console.WriteLine("{0} {1}", s, i);
	}
}
