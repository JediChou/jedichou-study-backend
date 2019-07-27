// 文件名：arr1d-demo01.cs
// 文件来自：https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
// 编码格式：Unix(LF) + UTF-8-BOM

using System;

public class Arr1dDemo01
{
	// 声明五个整数的一维数组
	static void Main()
	{
		// 初始化并打印初始值
		int[] arr = new int[5];

		// Notice: 初始值都是零，这和C/C++是不同的
		foreach (int i in arr)
			Console.Write(i + ", ");
		Console.WriteLine();

		// 给数组元素进行手动赋值
		arr[0] = 100;
		arr[1] = 101;
		arr[2] = 102;
		arr[3] = 103;
		arr[4] = 104;

		////////////////////////////////////////////////////////////////////////
		// Notice: 
		//   如果有arr[5]，则后面运行时候会出现以下错误。
		//   1. 显然在C#中数组也是不检查边界的；
		//   2. 可以编译，但会出现运行时错误；
		////////////////////////////////////////////////////////////////////////
		//     未经处理的异常:  System.IndexOutOfRangeException: 索引超出了数组界限。
   		//     在 Arr1dDemo01.Main()
		// arr[5] = 105;
		/////////////////////////////////////////////////////////////////////////

		// 手动赋值后再进行打印
		foreach (int i in arr)
			Console.Write(i + ", ");
		Console.WriteLine();
	}
}
