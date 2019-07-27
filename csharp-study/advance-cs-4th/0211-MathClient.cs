// File name: MathClient.cs
// Create by Jedi at 2013.4.16 11:41 AM.
// From <<Professional C# programming - ZhCn>>, Page 56
// Compiled command is
//   csc MathClient.cs /r:MathLibrary.dll

using System;

namespace Wrox.ProCSharp.Basics {
	class Client {
		public static void Main()
		{
			MathLib mathObj = new MathLib();
			Console.WriteLine(mathObj.Add(7,8));
		}
	}
}
