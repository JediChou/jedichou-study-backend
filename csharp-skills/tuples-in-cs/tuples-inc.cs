using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			// Example 1
			var tuple1 = new Tuple<String, Int32>("Jedi", 38);
			Console.WriteLine(tuple1);
			Console.WriteLine(tuple1.Item1);
			Console.WriteLine(tuple1.Item2);

			// Example 2
			var tuple2 = Tuple.Create<string, Int32>("Kivi", 3);
			Console.WriteLine(tuple2);
			Console.WriteLine(tuple1.Item2);
			Console.WriteLine(tuple1.Item2);

			// Example 3
			var _tuple = new Tuple<string , int>("Becky", 33);
			var nestle = new Tuple<int, int, int, Tuple<string, int>>(
				1,2,3, _tuple
			);
			Console.WriteLine(nestle.Item1);
			Console.WriteLine(nestle.Item2);
			Console.WriteLine(nestle.Item3);
			Console.WriteLine(nestle.Item4);
			Console.WriteLine(nestle.Item4.Item1);
			Console.WriteLine(nestle.Item4.Item2);

			// Can not work
			// Console.WriteLine(nestle.Rest.Item1);
			// Console.WriteLine(nestle.Rest.Item2);
		}
	}
}
