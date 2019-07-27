// 文件名：arr1d-demo2.cs
// 文件来自：https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
// 编码格式：Unix(LF) + UTF-8-BOM

using System;

public class Arr1dDemo2
{
	static void Main()
	{
		// 可使用相同方式声明存储字符串元素的数组
		string[] stringArr1 = new string[6];
		
		// Jedi: 使用var进行字符串数组的定义
		// Jedi: 有人喜欢强类型的定义方式
		// Jedi: 但似乎github上很多人都使用自动推导的方式
		var stringArr2 = new string[7];

		// 输出
		Console.WriteLine(stringArr1);
		Console.WriteLine(stringArr2);
	}
}
