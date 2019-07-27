// Listing 3-15. Using the ReadWriterLockSlim Class
// 
// The example creates five Tasks that acquire the read lock, wait
// for one second, and then release the read lock, repeating this
// sequence until they are cancelled. As the read lock is acquired
// and released, a message is printed to the console, and this message
// shows the number of holders of the read lock, which is available
// by reading the CurrentReadCount property.

namespace Listing_15 {
	
	using System;
	using System.Threading;
	using System.Threading.Tasks;

	class Listing_15 {

		static void Main(string[] args) {

			// create the reader-writer lock
			ReaderWriterLockSlim rwlock = new ReaderWriterLockSlim();

			// create a cancellation token source
			CancellationTokenSource tokenSource = new CancellationTokenSource();

			// create an array of tasks
			Task[] tasks = new Task[5];

			for(int i=0; i<5; i++) {
				// create a new task
				tasks[i] = new Task(()=> {
				}, tokenSource.Token)
				// TODO!
			}

		}

	}

}
