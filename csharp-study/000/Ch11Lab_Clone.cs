using System;
using System.Collections.Generic;

public class Content
{
	public int Val;
	
//	public Content(int newVal)
//	{
//		Val = newVal;
//	}
//	
//	public Content()
//	{
//		Val = 0;
//	}
}

public class Cloner : ICloneable
{
	public Content MyContent = new Content();
	
	public Cloner(int newVal)
	{
		MyContent.Val = newVal;
	}
	
	public object Clone()
	{
		Cloner clonedCloner = new Cloner(MyContent.Val);
		clonedCloner.MyContent = MyContent.Clone();
		return clonedCloner;
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Cloner myObj1 = new Cloner(101);
		Cloner myObj2 = myObj1.Clone();
		
		Console.WriteLine(myObj1 == myObj2);
		
		Console.ReadKey();
	}
}
