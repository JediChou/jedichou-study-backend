// Filename: 030202-PropertyTest.cs
// Create by Jedi at 2013.4.17 9:42 AM.
// Idea from <<Wrox Professional CSharp>>, zhcn-4th, Page 81

namespace Wrox.ProCSharp.PropertyTest
{
	using System;
		
	class PropertyTestObj1
	{
		// 1st declare
		public string name {
			get { return "This is PropertyTestObj1-name"; }
			set { name = "PropertyTestObj1-name-setAction"; }
		}
	}

	class PropertyTestObj2
	{
		// 2nd declare
		public string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}

	class PropertyTestSample
	{
		public static void Main()
		{
			// Test PropertyTestObj1
			// Notice: if you run this program will be get a error.
			PropertyTestObj1 pto1 = new PropertyTestObj1();
			pto1.name = "Tom";
			Console.WriteLine(pto1.name);

			// Test PropertyTestObj2
			PropertyTestObj2 pto2 = new PropertyTestObj2();
			pto2.Name = "Jerry";
			Console.WriteLine(pto2.Name);
		}
	}
}
