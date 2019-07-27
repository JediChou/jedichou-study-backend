using System;

public class MethodSample {	public static void Main() {
	TestClass<int, string> tc = new TestClass<int, string>();
	tc.DoSomething(5, "10");
	tc.DoSomething("10", 5);

	//TestClass<int, int> tc2 = new TestClass<int, int>();
	//tc2.DoSomething(5, 10); tc2.DoSomething(10, 5);
}}

public class TestClass<T, V> {
	public void DoSomething(T n, V m){Console.WriteLine("Method1");}
	//public T DoSomething(T n, T m){Console.WriteLine("Method2");return m;}
	//public int DoSomething(int m, int n){Console.WriteLine("Method3");return 0;}
}
