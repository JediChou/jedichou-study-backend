using System;

namespace csq0301 {
	class Program {
		public static void Main() {
			string first = "this is first varible";
			string second;
			Console.WriteLine(first);
			second = Console.ReadLine();
			Console.WriteLine("The second variable is: {0}", second);
			Console.ReadKey();
		}
	}
}
