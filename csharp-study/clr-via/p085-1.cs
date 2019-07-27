// File: p085-1.cs
// Description: 使用C#的is和as操作符來轉型

using System;

class Employee 
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

class Program 
{
	static void Main() 
	{
		Object o = new Object();
		Boolean b1 = (o is Object);
		Boolean b2 = (o is Employee);

		// //////////////////////////////////////////////////////////
		// 反編譯結果 -> ILSpy
		// object obj = new object();
		// bool flag = obj != null;
		// bool flag2 = obj is Employee;
		// //////////////////////////////////////////////////////////
		// Jedi comment
		// 1. Boolean可以直接用bool代替
		// 2. o is Object實際是判斷是否為基本類型，會直接檢驗是否為空
		// 3. o is Employee沒有變化
		// //////////////////////////////////////////////////////////

		Console.WriteLine("o is Object: {0}", b1);
		Console.WriteLine("o is Employee: {0}", b2);
	}
}
