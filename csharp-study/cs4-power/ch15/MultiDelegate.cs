// File name: MultiDelegate.cs
// Descritpion: Multi delegate in a C# class or file
// Reference: C# 4.0 The definitive guide

namespace ProgrammingCSharp4
{
	public delegate void DoProcess(string msg);
	
	class MultiDelegateSample
	{
		void Process1(string msg)
		{
			System.Console.WriteLine("Do Process 1st: {0}", msg);
		}
		
		void Process2(string msg)
		{
			System.Console.WriteLine("Do Process 2nd: {0}", msg);
		}
		
		public static void Main()
		{
			var sample = new MultiDelegateSample();
			DoProcess p1, p2, p3, p4;
			p1 = sample.Process1;
			p2 = sample.Process2;
			p3 = p1 + p2;
			p4 = p3 - p2;
			
			p1("Call p1");	// call p1
			p2("Call p2");	// call p2
			p3("Call p3");	// call p3
			p4("Call p4");	// call p4
		}
	}
}