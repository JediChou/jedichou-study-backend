// Listing 3-15. Using he ReaderWriterLockSlim Class

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0315 {
	class Program {
		static void Main(string[] args) {

			// Define
			var rwlock = new ReaderWriterLockSlim();
			var tokenSource = new CancellationTokenSource();
			var tasks = new Task[5];

			for(int i = 0; i < 5; i++) {
				// create a new task
				tasks[i] = new Task( () => {
					while (true) {
						// acqure the read lock
						rwlock.EnterReadLock();
						// we now have the lock
						Console.WriteLine("Read lock acquired - count: {0}",
							rwlock.CurrentReadCount);
						// wait - this simulates a read operation
						tokenSource.Token.WaitHandle.WaitOne(1000);
						// release the read lock
						rwlock.ExitReadLock();
						Console.WriteLine("Read lock released - count {0}",
							rwlock.CurrentReadCount);
						// check for cancellation
						tokenSource.Token.ThrowIfCancellationRequested();
					}
				}, tokenSource.Token);

				// start the new task
				tasks[i].Start();
			}

			// prompt the user, and wait for the user to press enter
			Console.WriteLine("Press enter to acquire write lock");
			Console.ReadLine();

			// acquire the write lock
			Console.WriteLine("Requesting write lock");
			rwlock.EnterWriteLock();

			Console.WriteLine("Write lock acquired");
			Console.WriteLine("Press enter to release write lock");
			Console.ReadLine();
			rwlock.ExitWriteLock();

			// wait for 2 seconds and then cancel the tasks
			tokenSource.Token.WaitHandle.WaitOne(2000);
			tokenSource.Cancel();

			try {
				// wait for the tasks to complete
				Task.WaitAll(tasks);
			} catch (AggregateException) {
				// do nothing
			}
		}
	} // end program
} // end namespace
