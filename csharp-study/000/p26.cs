using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TwoTask_WaitAny
{
	class Program
	{
		static void MethodA() { Thread.SpinWait(int.MaxValue); }
		static void MethodB() { Thread.SpinWait(int.MaxValue/2); }

		static void Main(string[] args)
		{
			var TaskA = Task.Factory.StartNew(MethodA);
			var TaskB = Task.Factory.StartNew(MethodB);

			Console.WriteLine("TaskA id = {0}", TaskA.Id);
			Console.WriteLine("TaskB id = {0}", TaskB.Id);

			var tasks = new Task[] { TaskA, TaskB };
			int whichTask = Task.WaitAny(tasks);
			Console.WriteLine("Task {0} is the gold medal task.",
							  tasks[whichTask].Id);
		}
	}
}

