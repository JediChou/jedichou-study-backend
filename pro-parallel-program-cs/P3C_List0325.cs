// Listing 3-25
//
// Multiple Locks
//   In a multiple lock scenario, multiple critical sections modify
//   the same shared data, and each has its own lock or
//   synchronization primitive. Access to each critical region is
//   synchronized, but there is no overall coordination which menas
//   that a data race can still occur.
//
// Solution
//   Ensure that every Task that enters the critical region uses the
//   same reference to acquire the synchronization lock.
//
// Example
//   The following examples shows two locks being used to synchronize
//   access to critical regions that access the same shared data, in
//   this case, the balance of our bank account example. Ten Tasks
//   are created in two groups of five: members of the first group
//   uses one lock to synchronize their balance updates, and the
//   second group uses the other lock.

using System;
using System.Threading.Tasks;

namespace Listing0325
{
	class BankAccount {	public int Balance { get; set; } }
	class Multiple_Locks {
		static void Main(string[] args)
		{
			// create the bank account instance
			var account = new BankAccount();

			// create two lock objects
			var lock1 = new object();
			var lock2 = new object();

			// create an array of tasks
			var tasks = new Task[10];

			// create five tasks that use the first lock object
			for (int i = 0; i < 5; i++) {
				// create a new task
				tasks[i] = new Task( () => {
					// enter a loop for 1000 balance updates
					for (int j = 0; j < 1000; j++) {
						lock(lock1) {
							// udpate the balance
							account.Balance++;
						}
					}
				});
			}

			// create five tasks that use the second lock object
			for (int i= 5; i < 10; i++) {
				// create a new task
				tasks[i] = new Task( () => {
					// enter a loop for 1000 balance updates
					for (int j = 0; j < 1000; j++) {
						lock(lock2) {
							// update the balance
							account.Balance++;
						}
					}
				});
			}

			// start the tasks
			foreach(var task in tasks)
				task.Start();

			// wait for all of the tasks to complete
			Task.WaitAll(tasks);

			// write out the counter value
			Console.WriteLine("Expeced value {0}, Balance: {1}",
				10000, account.Balance);
		}
	}
}
