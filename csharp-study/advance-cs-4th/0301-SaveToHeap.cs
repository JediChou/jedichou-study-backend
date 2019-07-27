// File name: SaveToHeap.cs
// Create by Jedi at 2013-4-16 13:47 PM.
// Idea from <Wrox - Professional C# Programming>, 4th-zhcn edition, Page 73

namespace AdvancedCSharpTest
{
	using System;

	struct PhoneCustomerStruct
	{
		public const string DayOfSendingBill = "Monday";
		public int CustomerID;
		public string FirstName;
		public string LastName;
	}

	public class SaveToHeap 
	{
		public static void Main(string[] args) 
		{
			Console.WriteLine("The struct will save to heap.\n");

			// TODO, Must be complete it.

			////////////////////////////////////////////////////
			/// OtherStructForLab can not contained in Main
			////////////////////////////////////////////////////
			/// struct OtherStructForLab
			/// {
			/// 	public int Age;
			/// 	public int ID;
			/// 	public string ComponentAge;
			/// 	public string ComponentVersion;
			/// }
			////////////////////////////////////////////////////
		}
	}
}
