// Url: https://msdn.microsoft.com/zh-cn/library/system.object.referenceequals(v=vs.110).aspx
using System;

class MyClass
{
	static void Main()
	{
		object o = null;
		object p = null;
		object q = new Object();
		
		Console.WriteLine(Object.ReferenceEquals(o, p));

		p = q;
		Console.WriteLine(Object.ReferenceEquals(p, q));
		Console.WriteLine(Object.ReferenceEquals(o, q));
	}
}
