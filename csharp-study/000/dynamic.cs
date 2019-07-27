namespace DynamicStudy
{
	using System;
	using System.Collections.Generic;

	public class DynamicIterateTable
	{
		public static void Main(string[] args)
		{
		 	dynamic items = new List<string> {"Fist", "Second", "third"};
			dynamic valueToAdd = 2;

			foreach (dynamic item in items)
			{
				string result = item + valueToAdd;
				Console.WriteLine(result);
			}
		}
	}
}
