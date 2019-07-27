// File name: 040206-SubClassConstructor1.cs
// Date: 2014-7-29-11-29
// Description: Add no parameter constructor
// From Professional C# Programming 106/1220

using System;

namespace Wrox.ProfessionalCSharp.SubClassConstructor
{
	public abstract class GenericCustomer
	{
		private string name;
		
		public GenericCustomer()
			: base()
		{
			name = "<no name>";
		}

		// help method
		public string getName() { return name; }
	}

	class Nevermore60Customer : GenericCustomer
	{
		private uint highCostMinutesUsed;

		// help method
		public void setHighCostMinutesUsed() { highCostMinutesUsed = 1; }
		public uint getHighCostMinutesUsed() { return highCostMinutesUsed; }

		public Nevermore60Customer()
		{
			setHighCostMinutesUsed();
		}

		public static void Main(string[] args) {
			var n6c = new Nevermore60Customer();
			Console.WriteLine(n6c.getName());
			Console.WriteLine(n6c.getHighCostMinutesUsed());
		}
	}
}
