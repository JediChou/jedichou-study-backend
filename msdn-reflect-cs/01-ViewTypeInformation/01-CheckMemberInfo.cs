using System;
using System.IO;
using System.Reflection;

class MemberInfo
{
	public static void Main()
	{
		Console.WriteLine("Title: Reflection.MemberInfo");
		
		// Gets the Type and MemberInfo.
		var MyType = Type.GetType("System.IO.File");
		var MyMemberInfoArray = MyType.GetMembers();
		
		// Gets and displays the DeclaringType method.
		Console.WriteLine(
			"There are {0} members in {1}",
			MyMemberInfoArray.Length,
			MyType.FullName
		);
		
		// output type's name
		// output method type (ex, public)
		Console.WriteLine("{0}", MyType.FullName);
		Console.WriteLine("{0} is {1}.", MyType.FullName, MyType.IsPublic ? "public" : "other");
	}
}