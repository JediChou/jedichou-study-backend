using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		// Create a new linked list.
		var linked = new LinkedList<string>();

		// First add three elements to the linked list.
		linked.AddLast("Sarah");
		linked.AddLast("Xin");
		linked.AddLast("Sammi");

		// Insert a node before the second node (after the first node)
		var node = linked.Find("Sarah");
		linked.AddAfter(node, "New Girl");

		// Loop through the linked list.
		foreach (var value in linked)
			Console.WriteLine(value);
	}
}
