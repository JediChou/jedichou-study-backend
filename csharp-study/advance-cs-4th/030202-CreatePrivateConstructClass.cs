// File name: 030202-CreatePrivateConstructClass.cs
// Create by Jedi at 2013.5.22 10:53 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 84
// Compile:
//   1. csc 030202-CreatePrivateConstructClass.cs
//   2. csc /target:exe /out:a.exe 030202-CreatePrivateConstructClass.cs

namespace Wrox.ProfessionalCSharp.CreatePrivateConstructClass
{
	// Why use private or protected constructor method ?
	// 1. As a container for some property and fields, never instances.
	// 2. Create instances cross by a static method.

	using System;
	
	// ConstructPrivateType contains a private constructor method.
	public class ConstructPrivateType {
		private string name;
		private ConstructPrivateType(string name) { this.name = name; }
		public string getName() { return this.name; }
		
		public static ConstructPrivateType getInstance() {
			return new ConstructPrivateType("Archimedes");
		}
	}
	
	// ConstructProtectedType contains a protected constructor method.
	public class ConstructProtectedType {
		private string name;
		protected ConstructProtectedType(string name) { this.name = name; }
		public string getName() { return this.name; }
		
		public static ConstructProtectedType getInstance() {
			return new ConstructProtectedType("Leonhard Euler");
		}
	}
	
	// Execute from this line.
	public class CallConstructProtectedType {
		public static void Main(string[] args) {
			// Can't create instance.
			// ConstructPrivateType cpt1 = new ConstructPrivateType("Archimedes");
			// ConstructProtectedType cpt2 = new ConstructProtectedType("Leonhard Euler");
			
			// Pls use this.
			ConstructPrivateType cpt1 = ConstructPrivateType.getInstance();
			ConstructProtectedType cpt2 = ConstructProtectedType.getInstance();
			Console.WriteLine(cpt1.getName());
			Console.WriteLine(cpt2.getName());
		}
	}
}
