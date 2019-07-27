// Listing 3-12. Acquiring Multiple Locks with Mutex.WaitAll()

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0312 {
	class BankAccount {
		public int Balance {get; set;}
	}

	class Program {
		static void Main(string[] args) {
			// create the bank account instances
			var account1 = new BankAccount();
			var account2 = new BankAccount();

			// create the mutexes
			var mutex1 = new Mutex();
			var mutex2 = new Mutex();

			// create a new task to update the first account
			var task1 = new Task( () => {
				// enter a loop for 10000 balance updates
				for(int j = 0; j < 1000; j++) {
					// acqurie the lock for the account
					var lockAcquired = mutex1.WaitOne();
					try {
						account1.Balance++;
					} finally {
						if (lockAcquired) mutex1.ReleaseMutex();
					}
				}
			});

			// create a new task to update the first account
			var task2 =  new Task( () => {
				// enter a loop for 10000 balance updates
				for(int j = 0; j < 1000; j++) {
					// acqurie the lock for the account
					var lockAcquired = mutex2.WaitOne();
					try {
						account2.Balance += 2;
					} finally {
						if (lockAcquired) mutex2.ReleaseMutex();
					}
				}
			});

			// create a new task to update the first account
			var task3 = new Task( () => {
				// enter a loop for 1000 balance updates
				for(int j = 0; j < 1000; j++) {
					// acquire the locks for both accounts
					var lockAcquired = Mutex.WaitAll(new WaitHandle[] { mutex1, mutex2} );
					try {
						// simulate a transfer between accounts
						account1.Balance++;
						account2.Balance--;
					} finally {
						if(lockAcquired) {
							mutex1.ReleaseMutex();
							mutex2.ReleaseMutex();
						}
					}
				}
			});

			// start the tasks
			task1.Start();
			task2.Start();
			task3.Start();

			// wait for the tasks to complete
			Task.WaitAll(task1, task2, task3);

			// write out the counter value
			Console.WriteLine("Account1 balance: {0}", account1.Balance);
			Console.WriteLine("Account2 balance: {0}", account2.Balance);
		}
	}
}

