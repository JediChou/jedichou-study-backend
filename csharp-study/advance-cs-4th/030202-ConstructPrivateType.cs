// File name: 030202-ConstructPrivateType.cs
// Create by Jedi at 2013.5.22 9:32 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 84

namespace Wrox.ProfessionalCSharp.ConstructPrivateType
{
	using System;

	public class ConstructPrivateType {
		private string name;
		private ConstructPrivateType(string name) { this.name = name; }
		public string getName() { return this.name; }
	}
	
	public class CallConstructPrivateType {
		public static void Main(string[] args) {
			ConstructPrivateType cpt = new ConstructPrivateType("name");
			Console.WriteLine(cpt.getName());
		}
	}
	
	// Compile error message.
	// 030202-ConstructPrivateType.cs(17, 31): error CS1729
	//     'Wrox.ProfessionalCSharp.ConstructPrivateType.ConstructPrivateType' does
	//     not contain a constructor that take '1' arguments
}
