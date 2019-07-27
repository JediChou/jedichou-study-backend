// File: 0xc0x3-AccessElt.cs
// Description: Access elements of array

using System;

class AccessArrayElt {
	static void Main() {
		// define
		var arr1 = new int[] {1,2,3};
		var arr2 = new int[,] {{1,2}, {3,4}};
		var arr3 = new object[] {new object(), new object()};

		// access
		Console.WriteLine(arr1[0]);
		Console.WriteLine(arr2[0,0]);
		Console.WriteLine(arr3[0]);
	}
}

// Decompile result
// 1. The class name match source code
// 2. Auto add internal
// 3. Auto add private
// 4. Almost same as souce code

/*
using System;

internal class AccessArrayElt
{
	private static void Main()
	{
		int[] array = new int[]
		{
			1,
			2,
			3
		};
		int[,] array2 = new int[,]
		{
			{
				1,
				2
			},
			{
				3,
				4
			}
		};
		object[] array3 = new object[]
		{
			new object(),
			new object()
		};
		Console.WriteLine(array[0]);
		Console.WriteLine(array2[0, 0]);
		Console.WriteLine(array3[0]);
	}
}
 */
