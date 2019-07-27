// magzine-200907-tuple06.cs
// 创建大的Tuple

using System;
class Program
{
	static void Main()
	{
		var t = Tuple.Create(
			1,2,3,4,5,6,7,
			Tuple.Create(8)
		);
		Console.WriteLine(t);
	}
}
