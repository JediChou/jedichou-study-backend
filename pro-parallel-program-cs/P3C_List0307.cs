// Listing 3-7. Using a Single Lock Object to Serialize
// Access to Two Critical Regions

using System;
using System.Threading.Tasks;

namespace Listing0307 {

	class BankAccount {
		public int Balance { get; set; }
	}

	class Program {
		static void Main(string[] args) {
			// create the bank account instance
			var account = new BankAccount();

			// create two arrays of tasks
			var incrementTasks = new Task[5];
			var decrementTasks = new Task[5];

			// create the lock object
			var lockObj = new object();

			for(int i = 0; i < 5; i++) {
				// create a new task
				incrementTasks[i] = new Task(()=>{
					// enter a loop for 1000 balance updates
					for(int j = 0; j < 1000; j++) {
						lock(lockObj) {
							// increment the balance
							account.Balance++;
						}
					}
				});

				// start the new task
				incrementTasks[i].Start();
			}

			for(int i = 0; i < 5; i++) {
				// create a new task
				decrementTasks[i] = new Task(()=>{
					// enter a loop for 1000 balance updates
					for(int j = 0; j < 1000; j++) {
						lock(lockObj) {
							// increment the balance
							account.Balance = account.Balance - 2;
						}
					}
				});

				// start the new task
				decrementTasks[i].Start();
			}

			// wait for all of the tasks to complete
			Task.WaitAll(incrementTasks);
			Task.WaitAll(decrementTasks);

			// write out the counter value
			Console.WriteLine(
				"Expected value: {0}, Balance: {1}",
				-5000, account.Balance
			);
		}
	}

}
