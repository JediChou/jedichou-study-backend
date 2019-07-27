// 文件名：arrCreate.cs
// 文件来自：https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/arrays/
// 编码格式：Unix(LF) + UTF-8-BOM

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// 以下示例创建一维、多维和交错数组.
// Jedi: 并非用来演示linq.
public class LinqQueryExpressions
{
	static void Main()
	{
		// 指定一个数据源
		int[]  scores = new int[] { 97, 92, 81, 60 };

		// 定义linq的查询表达式
		// Jedi: 有linq, 不用for
		IEnumerable<int> scoreQuery =
			from score in scores
			where score > 80
			select score;

		// 输出
		foreach (int i in scoreQuery)
			Console.Write(i + " ");
		Console.WriteLine();
	}
}
