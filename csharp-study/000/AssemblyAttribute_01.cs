using System;
using System.Reflection; // Line is required!

[assembly: AssemblyCompany("ZXI Online")]
[assembly: AssemblyProduct("Assembly Attribute Sample")]
[assembly: AssemblyTitle("ATT Sample")]
[assembly: AssemblyDescription("屬性定制示例")]

namespace AssemblyAttribute {
	public class AssemblyAttribute_020401 {
		public static void Main(string[] args) {
			Console.WriteLine("Application : Assembly Attribute 020401\n");
		}
	}
}