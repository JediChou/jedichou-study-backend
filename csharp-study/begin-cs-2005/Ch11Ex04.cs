// File name: Ch11Ex04.cs

namespace Ch11Ex04
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Text;

	// Class checker
	class Checker
	{
		public void Check(object param1)
		{
			// The first decide.
			if (param1 is ClassA)
				Console.WriteLine("Variable can be converted to ClassA.");
			else
				Console.WriteLine("Variable can't be converted to ClassA.");
			
			// The second decide.
			if (param1 is IMyInterface)
				Console.WriteLine("Variable can be converted to IMyInterface.");
			else
				Console.WriteLine("Variable can't be converted to IMyInterface.");
			
			// The third decide
			if (param1 is MyStruct)
				Console.WriteLine("Variable can be converted to MyStruct.");
			else
				Console.WriteLine("Variale can't be converted to MyStruct.");
		}	
	}

	
	// Interface IMyInterface
	interface IMyInterface {}

	// Define other class
	class ClassA : IMyInterface {}
	class ClassB : IMyInterface {}
	class ClassC {}
	class ClassD : ClassA {}
	struct MyStruct : IMyInterface {}

	// Program start here
	class Program
	{
		static void Main(string[] args)
		{
			// Define some instances.
			var try1 = new ClassA();
			var try2 = new ClassB();
			var try3 = new ClassC();
			var try4 = new ClassD();
			var try5 = new MyStruct();
			object try6 = try5;

			// Execute check process
			checkVariable(try1);
			checkVariable(try2);
			checkVariable(try3);
			checkVariable(try4);
			checkVariable(try5);
			checkVariable(try6);
		}

		static void checkVariable(object param)
		{
			var checker = new Checker();

			Console.WriteLine("==========");
			Console.WriteLine("Check " + param + " ...");
			checker.Check(param);
			Console.WriteLine("==========\n");
		}
	}

}

