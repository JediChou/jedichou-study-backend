// File name: 030202-ConstructSimple.cs
// Create by Jedi at 2013.5.22 9:10 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 83

namespace Wrox.ProfessionalCSharp.ConstructSimple
{
	using System;

	public class SimpleClass {
		// Simple constructor		
		public SimpleClass() {
			Console.WriteLine("This is a constructor method.");
		}

		// Program execute from this.
		public static void Main(string[] args) {
			new SimpleClass();
		}
	}
}
