using System;

public interface IMyInterface
{
	void DoSomething();
	void DoSomethingElse();
}

public class MyClass : IMyInterface
{
	public void DoSomething() {}
	public void DoSomethingElse() {}

	static void Main() {}
}
