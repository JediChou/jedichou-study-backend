using System;

namespace ProCSharp.String
{
	class ProcSharpString
	{
		static void Main()
		{
			Console.WriteLine("string Compare result: {0}",testStringCompare());
			Console.WriteLine("string CompareOrdinal result: {0}", testStringCompareOrdinal());
			Console.WriteLine("string Concat result: {0}", testStringConcat());
		}

		private static int testStringCompare()
		{
			var str1 = "This is a string";
			var str2 = "this is a string";
			return string.Compare(str1, str2);
		}

		private static int testStringCompareOrdinal()
		{
			var str1 = "This is a string";
			var str2 = "this is a string";
			return string.CompareOrdinal(str1, str2);
		}

		private static string testStringConcat()
		{
			string[] str = { "Jedi", " ", "Chou" };
			return string.Concat(str);
		}

		
	}
}
