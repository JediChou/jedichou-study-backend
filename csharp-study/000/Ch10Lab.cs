using System;
using System.Collections.Generic;

public class MyClass
{
	public virtual void DoSomething()
	{
		Console.WriteLine("MyClass's DoSomething method");
	}
	
	public abstract void DoAbstractMethod()
	{
		Console.WriteLine("MyClass's DoAbstractMethod");
	}
}

public class MySubClass : MyClass
{
	public override void DoSomething()
	{
		Console.WriteLine("MySubClass's DoSomething method");
	}
	
	public override void DoAbstractMethod()
	{
		Console.WriteLine("MySubClass's DoAbstractMethod output ... ");
	}
	
	public static void Main()
	{
		MySubClass myObj = new MySubClass();
		myObj.DoSomething();
		
		Console.ReadKey();
	}
}


