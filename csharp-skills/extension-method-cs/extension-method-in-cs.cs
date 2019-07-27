// extension-method-in-cs.cs
// url: http://www.c-sharpcorner.com/UploadFile/219d4d/extension-method-in-C-Sharp/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethod
{
	class Program {
		public static void Main(string[] args) {		
			string name = "Aiden Pearce";
			Console.WriteLine(name.ChangeCase());
		}
	}

	public static class MyExtension {
		public static string ChangeCase(this string Input) {
			var c = Input.ToCharArray(); 
			if (Input.Length > 0) {
				c[0] = char.IsUpper(c[0]) ? char.ToLower(c[0]) : char.ToUpper(c[0]);			
				return new string(c);
			} else 
				return Input;
		}
	}
}
