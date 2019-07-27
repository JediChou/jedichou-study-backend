using System;

public interface IMyInterface
{
	void DoSomething();
	void DoSomethingElse();
}

public class MyBaseClass : IMyInterface
{
	public virtual void DoSomething() {}
	public virtual void DoSomethingElse() {}
}

public class MyDriveClass : MyBaseClass
{
	public override void DoSomethingElse() {}
	static void Main() {}
}
