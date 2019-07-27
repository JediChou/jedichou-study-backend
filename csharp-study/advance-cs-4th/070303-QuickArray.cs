namespace Wrox.ProCSharp.QuickArray
{
	using System;

	class Program
	{
		static unsafe void Main()
		{
			Console.WriteLine("How big an array do you want?\n>");
			string userInput = Console.ReadLine();
			uint size = uint.Parse(userInput);

			// very fast
			long* pArray = stackalloc long[(int)size];
			for(int i=0; i<size; i++)
				pArray[i] = i*i;

			// very fast
			for(int i=0; i<size; i++)
				Console.WriteLine("Element{0}={1}", i, *(pArray+i));
		}
	}
}
