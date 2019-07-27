// Listing 3-6. Applying the lock Keyword
using System;
using System.Threading.Tasks;

namespace Listing0306
{
	class BankAccount {
		public int Balance { get; set; }
	}

	class Program {
		static void Main(string[] args)
		{
			// Create the bank account instance
			var account = new BankAccount();

			// Create an array of tasks
			var tasks = new Task[10];

			// create the lock object
			var lockObj = new object();

			for(int i = 0; i < 10; i++)
			{
				// Create a new task
				tasks[i] = new Task(() => {
					// Enter a loop for 1000 balance updates
					for( int j = 0; j < 1000; j++ ) {
						lock(lockObj) {
							// update the balance
							account.Balance = account.Balance + 1;
						}
					}
				});

				// Start the new task
				tasks[i].Start();
			}

			// Wait for all of the tasks to complete
			Task.WaitAll(tasks);

			// Write out the counter value
			Console.WriteLine(
				"Expected value {0}, Balance: {1}",
				10000, account.Balance
			);
		}
	}
}
