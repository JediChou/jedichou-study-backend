// Listing 3-10. Using the SpinLock Primitive

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0310 {
	class BankAccount {
		public int Balance { get; set; }
	}

	class Program {
		static void Main(string[] args) {
			var account = new BankAccount();
			var spinlock = new SpinLock();
			var tasks = new Task[10];

			for( int i=0; i<10; i++) {
				// create a new task
				tasks[i] = new Task( ()=> {
					for(int j=0; j<1000; j++) {
						var lockAcquired = false;
						try {
							spinlock.Enter(ref lockAcquired);
							account.Balance = account.Balance + 1; // update
						} finally {
							if (lockAcquired) spinlock.Exit();
						}
					}
				});

				// start the new task
				tasks[i].Start();
			}

			// wait for all of the tasks to complete
			Task.WaitAll(tasks);

			// Write out the counter value
			Console.WriteLine("Expected value: {0}, Balance: {1}",
				10000, account.Balance);
		}
	}
}
