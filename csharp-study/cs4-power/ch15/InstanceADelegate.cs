// File name: InstanceADelegate.cs
// Description: Instance a delegate
// Reference: C# 4.0 The Definitive Guide CN

namespace ProgrammingCSharp4
{
	public delegate void DoProcess(string msg);
	
	class DelegateSample
	{
		void Process(string msg)
		{
			System.Console.WriteLine("Proces Flow: {0}", msg);
		}
		
		public static void Main()
		{
			var sample = new DelegateSample();
			var process = new DoProcess(sample.Process);
			process("Test data for create a delegate method.");
		}
	}
}