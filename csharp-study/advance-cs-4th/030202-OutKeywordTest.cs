// File name: 030202-OutKeywordTest.cs
// Create by Jedi at 2013-4-16 17:14 PM.
// From <<Professional CSharp programming>>, zhcn-4th, Page 79.

namespace Wrox.ProCSharp.OutKeywordTest
{
	using System;

	class OutKeywordTestSample
	{
		/// I think this is a important skill.
		/// We can use this skill to create many 'initialior'
		///   for dynamic languages that write by DoNet
		///   framework.
		static void SomeFunction(out int i) { i=100; }
		
		public static void Main() {
			int i;  // note how i is decleared but not initialized
			SomeFunction(out i);
			Console.WriteLine(i);
		}
	}
}
