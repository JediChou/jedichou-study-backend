using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JediLabs {
	public class Program {
		static void Main(string[] args)
	   	{
			Console.WriteLine("Use multi-using");

			using (var b = new List<int>() )
			{
				//Console.WriteLine(a);
				Console.WriteLine("adfadf");
			}
		}
	}
}
