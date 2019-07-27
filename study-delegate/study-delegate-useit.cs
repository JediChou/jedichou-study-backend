class Study_Delegate_UseIt {

	public delegate void Del(string message);
	public static void DelegateMethod(string message) {
		System.Console.WriteLine(message);
	}
		
	static void Main(string[] args) {
		Del handler = DelegateMethod;
		handler("Hello world");
	}
}
