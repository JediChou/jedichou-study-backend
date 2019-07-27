// File name: SimpleFactoryPattern
// Description: TODO
//   Simple Factory define an interface to create object.
//   Objects that simple factory created is a sub class
//   instances.

using System;

namespace EFT
{
	// Abstrac process class.
	abstract class EFT
	{
		public abstract void process();
	}
	
	// A class, it will run a vitrual process
	class VitualCheck : EFT
	{
		public override void process()
		{
			Console.WriteLine("Virtual Check in the processing ...");
		}
	}
	
	
}
