class Study_Delegate_JoinSort {

	public delegate void Del(string message);
	public static void DeletgateMethod(string message) {
		System.Console.WriteLine(message);
	}

	public void MethodWithCallback(int param1, int param2, Del callback) {
		callback("The number is: " + (param1 + param2).ToString());
	}

	static void Main(string[] args) {
		Del handler = DeletgateMethod;
		var testobj = new Study_Delegate_JoinSort();
		testobj.MethodWithCallback(1, 2, handler);
	}
}
