using System;
using System.Threading.Tasks;

namespace Listing_02 {
	class Listing_02 {
		static void Main(string[] args) {
			
			// use an Action delegate and a named method
			// Task task1 = new Task(new Action(printMessage));

			// use a anonymous delegate
			// 方式1：使用匿名托管来定义
			Task task2 = new Task(delegate { printMessage(2); });

			// use a lambda expression and name
			// 方式2：或者使用Lambda表达式来定义
			Task task3 = new Task(() => printMessage(3));

			// use a lambda expression and an anonymous method
			// 方式3：使用Lambda表示式和匿名方法
			Task task4 = new Task(() => { printMessage(4); } );

			// task1.Start();
			task2.Start();
			task3.Start();
			task4.Start();

			// wait for input before existing
			Console.WriteLine("Main method complete. Press enter to finish");
			Console.ReadLine();
		}

		static void printMessage(int i) {
			Console.WriteLine("Hello World" + i);
		}
	}
}

