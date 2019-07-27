using System;
using System.Collections;
// using System.Collections.Generic;

public class Stack : IEnumerable
{
	int[] items = { 4, 5, 8, 10, 2, 6, 9, 11 }; 
	
	public IEnumerator GetEnumerator()
	{
		for(int i = 0; i < items.Length; i++)
			yield return items[i];
	}
}

class Test
{
	static void Main()
	{
		Stack stack = new Stack();
		foreach(int i in stack) {
			Console.WriteLine(i);
		}
	}
}
