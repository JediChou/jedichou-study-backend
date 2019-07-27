using System;
using System.Collections.Generic;

class Stack<T>
{
	private T[] store;
	private int size;
	
	public Stack() {store = new T[10]; size = 0; }
	public void Push(T x) { store[size++] = x; }
	public T Pop() { return store[--size]; }
}

class Program
{
	public static void Main(string[] args)
	{
		Stack<string> s1 = new Stack<string>();
		Stack<int> s2 = new Stack<int>();
	}
}