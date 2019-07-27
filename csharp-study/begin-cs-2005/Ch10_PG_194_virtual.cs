// Filename: Ch10_PG_194_virtual.cs
// Description: how to use virtual methods.

using System;

namespace programming
{
	public class BaseClass
	{
		public virtual int plusOne(int i) { return i+1; }
		public virtual int addNum(int i, int j) { return i+j; }
	}

	public class DerivedClass : BaseClass
	{
		public override int plusOne(int i) { return i+2; }
		public override int addNum(int i, int j) { return i+j+2; }

		public static void Main(string[] args)
		{
			DerivedClass myobj = new DerivedClass();
			Console.WriteLine(myobj.plusOne(0));
			Console.WriteLine(myobj.addNum(0,0));
		}
	}
}
