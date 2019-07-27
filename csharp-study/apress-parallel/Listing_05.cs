// Listing 2-5. Getting Results from a Task
using System;
using System.Threading.Tasks;

namespace Listing_05
{
	class Listing_05
	{
		static void Main(string[] args)
		{
			// 1. create the task without parameter
			// 2. start the task and write out the result
			Task<int> task1 = new Task<int>(() => {
				int sum = 0;
				for (int i = 0; i<100; i++)
					sum += i;
				return sum;
			});			
			task1.Start();
			Console.WriteLine("Result 1: {0}", task1.Result);

			// 1. create the task using state with a parameter
			// 2. start the task and write out the result
			Task<int> task2 = new Task<int>( obj => {
				int sum = 0;
				int max = (int)obj;
				for (int i=0; i<max; i++)
					sum += i;
				return sum;
			}, 100);
			task2.Start();
			Console.WriteLine("Result 2: {0}", task2.Result);

			// Wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}

