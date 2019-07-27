// File name: 040201-OverrideVirtualMethod.cs
// Description: Override virtual method.
// Create by Jedi at 2014.7.25 11:24 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 101
// Compile:
//   1. csc 030602- 040201-OverrideVirtualMethod.cs
//   2. csc /target:exe /out:a.exe 040201-OverrideVirtualMethod.cs

using System;

namespace Wrox.ProfessionalCSharp4th.OverrideVirtualMethod
{
	class Father
	{
		// Complie error message:
		// 1. cannot override inherited member
		// 2. because it is not marked virtual, abstract, or override
		public int getNumber() { return 1;}
	}

	class Son : Father
	{
		public override int getNumber() { return 2; }
		public static void Main() {}
	}
}

