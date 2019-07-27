using System;

public class MyBaseClass 
{
	public void DoSomething() {}
}

public class DriveClass : MyBaseClass
{
	// Use this you will get a warning.
	// public void DoSomething() 
	// {
	//	Console.WriteLine("This is a DriveClass DoSomething method.");
	// }

	// Use this have no warning.
	new public void DoSomething() 
	{
		Console.WriteLine("This is a DriveClass DoSomething method.");
	}

	static void Main()
	{
		new DriveClass().DoSomething();
	}
}
