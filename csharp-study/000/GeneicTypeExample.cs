using System;
using System.Collections;
using System.Collections.Generic;

namespace Jedi.DoNet2.Study.DataStruct
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> a = new List<int>();
			a.Add(44);
			a.Add(55);
			
			List<string> second = new List<string>();
			second.Add("Jedi");
			second.Add("Becky");
			
			foreach(int elt in a)
				Console.WriteLine(elt);
			
			foreach(string name in second)
				Console.WriteLine(name);
		}
	}
}