using System;

public interface IMyInterface
{
	void DoSomething();
	void DoSomethingElse();
}

public class MyBaseClass
{
	public void DoSomething() {}
}

public class MyDriveClass : MyBaseClass, IMyInterface
{
	public void DoSomethingElse() {}
	static void Main() {}
}
