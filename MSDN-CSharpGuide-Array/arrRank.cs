// 文件名：arrRank.cs
// 文件来自：https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/arrays/arrays-as-objects
// 编码格式：Unix(LF) + UTF-8-BOM

using System;

public class GetArrRank
{
	static void Main()
	{
		///////////////////////////////////////////////////
		// 高能预警：在C#中array实际上为对象，而不是内存中
		// 连续的可寻址区域。
	 	///////////////////////////////////////////////////

		// 定义多维数组
		int[,] arr1 = new int[5, 10];
		int[,,] arr2 = new int[5,10,10];
		
		// 输出数组的维度
		// Jedi: Rank显然是面向对象的产物（即属性）
		Console.WriteLine(arr1.Rank);
		Console.WriteLine(arr2.Rank);
	}
}
