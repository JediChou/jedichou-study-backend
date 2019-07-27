// Listing 3-11. Basic Use of the Mutex Class

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0311 {
	class BankAccount { public int Balance {get; set;} }
	class Program {
		static void Main(string[] args) {
			var account = new BankAccount();
			var mutex = new Mutex();
			var tasks = new Task[10];

			for(int i = 0; i < 10; i++) {
				// create a new stask
				tasks[i] = new Task( ()=>{
					// enter a loop for 1000 balance updates
					for(int j = 0; j < 1000; j++) {
						// acquire the mutex
						var lockAcquired = mutex.WaitOne();
						try {
							account.Balance = account.Balance + 1;
						} finally {
							if (lockAcquired) mutex.ReleaseMutex();
						}
					}
				});

				// start task
				tasks[i].Start();
			}

			// wait for all of the tasks to complete
			Task.WaitAll(tasks);

			// write out the counter value
			Console.WriteLine("Expected value {0}, Balance: {1}",
				10000, account.Balance);
		}
	}
}
