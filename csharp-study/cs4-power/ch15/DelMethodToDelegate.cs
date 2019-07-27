// File name: DelMethodToDelegate.cs
// Description: Del a method to delegate instance
// Reference: C# 4.0 The definetive guide

namespace ProgrammingCSharp
{
	using System;
	
	public delegate void Process(string msg);
	
	class MoreMethodDelegate
	{
		void DoProcess1(string msg)
		{
			Console.WriteLine("Method DoProcess1: {0}", msg);
		}
		
		void DoProcess2(string msg)
		{
			Console.WriteLine("Method DoProcess1: {0}", msg);
		}
		
		public static void Main()
		{
			var mmdel = new MoreMethodDelegate();
			Process process = mmdel.DoProcess1;
			process += mmdel.DoProcess2;
			process -= mmdel.DoProcess1;
			
			process("Test for delegate with multi-method");
		}
	}
}