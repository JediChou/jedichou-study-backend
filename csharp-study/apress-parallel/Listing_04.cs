// Listing 2-4. Creating Several Tasks Using Task State

using System;
using System.Threading.Tasks;

namespace Listing_04
{
	class Listing_04
	{
		static void Main(string[] args)
		{
			string[] messages = {
				"First task",
				"Second task",
				"Third task",
				"Fourth task"};

			foreach(string msg in messages)
			{
				// 批量建立, 各自执行
				Task myTask = new Task(obj => printMessage((string)obj), msg);
				myTask.Start();
			}

			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}

		static void printMessage(string message)
		{
			Console.WriteLine("Message: {0}", message);
		}
	}
}

