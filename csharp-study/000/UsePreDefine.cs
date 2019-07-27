// File name: UsePreDefine.cs
// Description: How to use predefined in C#
// Result: failed
// Date: 2016.7.15 14:34

namespace UsePreDefine
{
	using System;
	using System.Threading;


	class Program
	{
		static void Main(string[] args)
		{
#if v2_0 || v3_5
			Console.WriteLine("v2_0 or v3_5 output...");
			Console.WriteLine("Something in trouble");
#endif

#if v4_0 || v4_5 || v4_6
			Console.WriteLine("v4_0 or v4_5, v4_6 output...");
			Console.WriteLine("Something in trouble");
#endif
		}
	}
}

