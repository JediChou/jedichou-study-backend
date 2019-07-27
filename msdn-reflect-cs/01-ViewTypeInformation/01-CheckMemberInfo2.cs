// File: 01-CheckMemberInfo2.cs
// Description:
//	This code displays information about the GetValue method of FileInfo.

using System;
using System.Reflection;

class MyMethodInfo
{
	public static void Main()
	{
		Console.WriteLine("Reflection.MethodInfo");
		
		// Gets and displays the type.
		var MyType = Type.GetType("System.Reflection.FieldInfo");
		
		// Specifies the member for which you want type information.
		var MyMethodInfo = MyType.GetMethod("GetValue");
		Console.WriteLine(MyType.FullName + "." + MyMethodInfo.Name);
		
		// Gets and displays the Membertype property
		var MyMemberTypes = MyMethodInfo.MemberType;
		
		if (MemberTypes.Constructor == MyMemberTypes)
		{
			Console.WriteLine("MemberType is of type all");
		}
		else if (MemberTypes.Custom == MyMemberTypes)	
		{
			Console.WriteLine("MemberType is of type Custom");
		}
		else if (MemberTypes.Event == MyMemberTypes)
		{
			Console.WriteLine("MemberType is of type Event");
		}	
	}
}