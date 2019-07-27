using System;
using System.Collections;

namespace Jedi.CheckRef
{
	public struct ValPoint
	{
		public int x;
		public ValPoint(int x) { this.x = x; }
	}

	public class Program
	{
		static void Main(string[] args)
		{
			// Notice: the valpoint type is ValueType, not a class.
			ValPoint valpoint;
			Console.WriteLine(valpoint);
		}
	}
}
