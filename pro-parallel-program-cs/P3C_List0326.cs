// Listing 3-26
//
// Solution
//   If you are using wait-handle-based primitives, the best solution
//   is to use the WaitAll() method demonstrated in the "Acquiring
//   Multiple Locks" section of this chapter. This method will
//   acquire the lock on multiple wait handles in single step, which
//   avoids the deadlock.
//
// Example
//   The following example creates two objects used with the lock key
//   word. Two Tasks are created, and they acquire one of the locks,
//   wait for 500 ms, and then acquire the second lock. The lock
//   acquisition order is different for each Task and deadlock occurs.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0326
{
	class Lock_Acquisition_Order {
		static void Main(string[] args)
		{
			// create two lock objects
			var lock1 = new object();
			var lock2 = new object();

			// create a task that acquires lock 1
			// and then lock 2
			var task1 = new Task( () => {
				lock(lock1) {
					Console.WriteLine("Task 1 acquired lock 1");
					Thread.Sleep(500);
					lock (lock2) {
						Console.WriteLine("Task 1 acquired lock 2");
					}
				}
			});

			// create a task that acquires lock 2
			// and then lock 1
			var task2 = new Task( () => {
				lock (lock2) {
					Console.WriteLine("Task 2 acquired lock 2");
					Thread.Sleep(500);
					lock (lock1) {
						Console.WriteLine("Task 2 acquired lock 1");
					}
				}
			});

			// start the tasks
			Task.WaitAll(task1, task2);
		}
	}
}
