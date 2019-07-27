// magzine-200907-tuple03.cs
// 使用Tuple，即一开始就进行绑定

using System;
class Program
{
	static void Main()
	{
		Tuple<string, int> t = new Tuple<string, int>("Hello", 4);
		PrintStringAndInt(t.Item1, t.Item2);
	}

	static void PrintStringAndInt(string s, int i)
	{
		Console.WriteLine("{0} {1}", s, i);
	}
}
