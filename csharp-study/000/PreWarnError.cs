// File name: PreWarnError.cs
// Description: Use pre-command (#warning, #error)
//   Message display when you complie it.
//   But in this scenario, it is normal.
// Date & time: 2014-7-22 14:07

namespace Wrox.ProCSharp.Basics
{
	public class PreWarnError
	{
		public static void Main()
		{
			#warning "This is a <warning> message !"
			#error "This is a <error> message !"
			Console.WriteLine("Use Warning and Error !");
		}
	}
}
