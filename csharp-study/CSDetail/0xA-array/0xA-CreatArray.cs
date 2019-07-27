// File: 0xA-CreatArray
// Description: Create an array object
// Jedi Chou, skyzhx@163.com
// 2018.3.7 17:14 PM

class XA_CreateArray
{
	static void Main()
	{
		var arr1 = new int[,] {{0,1}, {2,3}, {4,5}};
		var arr2 = new int[3,2] {{0,1}, {2,3}, {4,5}};
	}
}

// Diff of decompile result
//   Decompiler: ILSpy version 2.4.0.1963
//   Coompiler: Microsoft (R) Visual C# Compiler version 4.7.2556.0 for C# 5
// 1. auto add using.System;
// 2. auto add internal
// 3. auto add private for main method
// 4. new int[3,2] is int[,]
// 5. local variable change to expr_08, expr_1B

/*
using System;

internal class XA_CreateArray
{
	private static void Main()
	{
		int[,] expr_08 = new int[,]
		{
			{
				0,
				1
			},
			{
				2,
				3
			},
			{
				4,
				5
			}
		};
		int[,] expr_1B = new int[,]
		{
			{
				0,
				1
			},
			{
				2,
				3
			},
			{
				4,
				5
			}
		};
	}
}
*/
