// File name: 030202-ConstructProtectedType.cs
// Create by Jedi at 2013.5.22 10:53 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 84

namespace Wrox.ProfessionalCSharp.ConstructProtectedType
{
	using System;

	public class ConstructProtectedType {
		private string name;
		protected ConstructProtectedType(string name) { this.name = name; }
		public string getName() { return this.name; }
	}
	
	public class CallConstructProtectedType {
		public static void Main(string[] args) {
			ConstructProtectedType cpt = new ConstructProtectedType("name");
			Console.WriteLine(cpt.getName());
		}
	}
	
	// Compile error message.
	// 030202-ConstructPrivateType.cs(17, 33): error CS1729
	//     'Wrox.ProfessionalCSharp.ConstructProtectedType.ConstructProtectedType'
    //     does not contain a constructor that take '1' arguments
}
