using System;
using System.Collections.Generic;

class Program 
{
	static void Main(string[] args) 
	{
		// create a new linked list object instance
		var linked = new LinkedList<string>();

		// use AddLast method to add elements at the end.
		// Use AddFirst method to add element at start.
		linked.AddLast("Sarah");
		linked.AddLast("Xin");
		linked.AddLast("Sammi");
		linked.AddFirst("Stephen");

		// Loop throuhg the linked list with foreach-loop
		foreach (var item in linked)
			Console.WriteLine(item);
	}
}
