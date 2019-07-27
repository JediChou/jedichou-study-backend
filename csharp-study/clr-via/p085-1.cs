// File: p085-1.cs
// Description: ʹ��C#��is��as���������D��

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
		// �����g�Y�� -> ILSpy
		// object obj = new object();
		// bool flag = obj != null;
		// bool flag2 = obj is Employee;
		// //////////////////////////////////////////////////////////
		// Jedi comment
		// 1. Boolean����ֱ����bool����
		// 2. o is Object���H���Д��Ƿ�������ͣ���ֱ�әz��Ƿ���
		// 3. o is Employee�]��׃��
		// //////////////////////////////////////////////////////////

		Console.WriteLine("o is Object: {0}", b1);
		Console.WriteLine("o is Employee: {0}", b2);
	}
}
