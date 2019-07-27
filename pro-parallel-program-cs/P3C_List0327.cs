// Listing 3-27
//
// Solution
//   Ensure that you do not return from a method before releasing a
//   lock and handle exceptions by releasing your lock in the finally
//   block of a try...catch...finally sequence. Alternatively, use
//   the lock keyword (although this may offer poor performance
//   compared with one of the lightweight synchorinization primitives
//	 ).
//
// Example
//   The following example uses a Mutex to demonstrate an orphanded
//   lock. The first Task created repeatedly acquires and releases
//   the Mutex. The second Task acquires the Mutex and then throws
//   an exception, so the Mutex is never released. The first Task
//   deadlocks waiting to acquire the Mutex and cannot move foward.
//   The Mutex remains orphaned even when the second Task has
//   finished and its exception has been processed.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0327
{
	class Program {
		static void Main(string[] args)
		{
			// create the sync primitive
			var mutex = new Mutex();

			// create a cancellation token source
			var tokenSource = new CancellationTokenSource();

			// create a task that acquires and releases the mutex
			var task1 = new Task( () => {
				while (true) {
					mutex.WaitOne();
					Console.WriteLine("Task 1 acquired mutex");
					// wait for 500ms
					tokenSource.Token.WaitHandle.WaitOne(500);
					// exit the mutex
					mutex.ReleaseMutex();
					Console.WriteLine("Task 1 released mutex");
				}
			}, tokenSource.Token);

			// create a task that acquires and then abandons the mutex
			var task2 = new Task( () => {
				// wait for 2 second to let the another task run
				tokenSource.Token.WaitHandle.WaitOne(2000);
				// acquire the mutex
				mutex.WaitOne();
				Console.WriteLine("Task 2 acquired mutex");
				// abandon the mutex
				throw new Exception("Abandoning Mutex");
			}, tokenSource.Token);

			// start the tasks
			Task.WaitAll(task1, task2);

			// wait for task 2
			try {
				task2.Wait();
			} catch (AggregateException ex) {
				ex.Handle( (inner) => {
					Console.WriteLine(inner);
					return true;	
				});
			}
		}
	}
}
