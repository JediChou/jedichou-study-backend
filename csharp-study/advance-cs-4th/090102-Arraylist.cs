using System;
using System.Collections;

namespace Wrox.ProCSharp.ArrayListDemo
{
	class Program
	{
		static void Main()
		{
			var baseball_Teams = new ArrayList();
			baseball_Teams.Add("St. Louis Cardinals");
			baseball_Teams.Add("Seattle Mariners");
			baseball_Teams.Add("Florida Marlins");

			var myStringArray = new string[2];
			myStringArray[0] = "San Francisco Giants.";
			myStringArray[1] = "Los Angels Dodgers";

			// Add range to baseball_Teams
			baseball_Teams.AddRange(myStringArray);

			// Output
			foreach(var item in baseball_Teams)
				Console.WriteLine(item);

			// After delete action
			Console.WriteLine("\nRemoveRange(2,2)");
			baseball_Teams.RemoveRange(2, 2);
			foreach(var item in baseball_Teams)
				Console.WriteLine(item);
		}
	}
}
