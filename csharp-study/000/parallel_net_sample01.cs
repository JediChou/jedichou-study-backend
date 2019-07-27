using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
	static void MethodA() { Console.WriteLine("MethodA"); }
	static void MethodB() { Console.WriteLine("MethodB"); }

	static void Main(string[] args)
	{
		var TaskA = Task.Factory.StartNew(MethodA);
		var TaskB = Task.Factory.StartNew(MethodB);
		Task.WaitAll(new Task[] { TaskA, TaskB } );
		Console.ReadLine();
	}
}

