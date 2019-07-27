// File name: 030202-ConstructCompileTheOne.cs
// Create by Jedi at 2013.5.22 9:32 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 84

namespace Wrox.ProfessionalCSharp.CompileTheOne
{
	using System;

	public class CompileTheOne {
		
		// Define a field and constructor.
		private string name;
		public CompileTheOne(string name) {
			this.name = name;
		}

		// Program execute from this.
		// Target, You will get a compile error.
		public static void Main(string[] args) {
			CompileTheOne cto = new CompileTheOne();
		}
		
		/* 
		 * *************** Compile error message ***************
		 * 030202-ConstructCompileTheOne.cs(20, 24): error CS1729:
		 *     'Wrox.ProfessionalCSharp.CompileTheOne.CompileTheOne' does not contain a
		 *     constructor that takes '0' arguments
		 * 030202-ConstructCompileTheOne.cs(13, 10): (Location of symbol related to
		 *     previous error)
		 */
	}
}
