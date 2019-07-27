// Url: https://msdn.microsoft.com/zh-cn/library/system.object.referenceequals(v=vs.110).aspx

using System;

public class Example
{
	public static void Main()
	{
		String s1 = "String1";
		String s2 = "String1";
		
		Console.WriteLine("s1 = s2: {0}", object.ReferenceEquals(s1, s2));
		Console.WriteLine("{0} interned: {1}", s1,
					   	  String.IsNullOrEmpty(String.IsInterned(s1)) ? "No" : "Yes");

		String suffix = "A";
		String s3 = "String" + suffix;
		String s4 = "String" + suffix;
		Console.WriteLine("s3 = s4: {0}", Object.ReferenceEquals(s3, s4));
		Console.WriteLine("{0} interned: {1}", s3,
					   	  String.IsNullOrEmpty(String.IsInterned(s4)) ? "No" : "Yes");

		// Jedi: 不太理解String.IsNullOrEmpty(String.IsInterned(s4)
		// TODO: IsInterned()是什麼意思？
	}
}
