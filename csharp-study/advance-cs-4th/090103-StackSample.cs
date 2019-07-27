using System;
using System.Collections;

namespace Wrox.ProCSharp.StackSample
{
	class Program
	{
		static void Main()
		{
			var alphabet = new Stack();
			alphabet.Push("A");
			alphabet.Push("B");
			alphabet.Push("C");

			foreach(var item in alphabet)
				Console.WriteLine(item);

			// After pop()
			Console.WriteLine("\npop a item, and value is {0}", alphabet.Pop());
			Console.WriteLine("Execute iterate again");
			foreach(var item in alphabet)
				Console.WriteLine(item);
		}
	}
}
