using System;
using System.Reflection;

[assembly: AssemblyCompany("ParadoxalPress")]
namespace Foo {
	class Program {
		public static void Main(string[] argv) {
			Console.WriteLine("Hi from Foo1");
			Bar b = new Bar();
			Console.WriteLine( b );
		}
	}
}