using System;
using System.Collections.Generic;

public interface IMyInterface
{
	void DoSomething();
	void DoSomethingElse();
}

public class MyBaseClass
{
	public void DoSomething()
	{
	}
}

public class MyClass : MyBaseClass, IMyInterface
{
	public void DoSomething() {}
	public void DoSomethingElse() {}
	
	public static void Main(string[] args)
	{
		// comment.
	}
}
