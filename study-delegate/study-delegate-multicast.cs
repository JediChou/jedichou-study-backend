using System;

public class MethodClass {
	public void Method1(string msg) { Console.WriteLine("MethodClass.Method1: " + msg); }
	public void Method2(string msg) { Console.WriteLine("MethodClass.Method2: " + msg); }
}

public class Study_Delegte_Multicast {
	
	public delegate void Del(string message);
	public static void DelegateMethod(string msg) { Console.WriteLine(msg); }

	static void Main(string[] args) {
		var obj = new MethodClass();
		Del d1 = obj.Method1;
		Del d2 = obj.Method2;
		Del d3 = DelegateMethod;

		// Both types of assignment are valid
		Del allMethodsDelegate = d1 + d2;
		allMethodsDelegate += d3;
		Console.Write("===> with d1, d2, d3:\n");
		allMethodsDelegate("Jedi send these message");

		// remove method d1
		allMethodsDelegate -= d1;
		Console.Write("===> remove d1:\n");
		allMethodsDelegate("Jedi send these message");
	}
}
