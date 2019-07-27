// File name: 040202-HideMethod.cs
// Description: Use hide method in inherit.
// Create by Jedi at 2014.7.25 11:34 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 101
// Compile:
//   1. csc 040202-HideMethod.cs
//   2. csc /target:exe /out:a.exe 040202-HideMethod.cs

using System;

namespace Wrox.ProfessionalCSharp.HideMethod
{
	class Father { public int getInteger(){return 1;} }
	class Son : Father
	{
		public new string getInteger() { return "Trek";}
		public static void Main(){
			Console.WriteLine(new Son().getInteger());
		}
	}
}
