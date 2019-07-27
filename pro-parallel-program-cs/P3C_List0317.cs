// Listing 3-17. A data Race Sharing a Collection

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0317 {
	
	// TODO: There has an error.
	// Unhandled Exception: System.AggregateException:
	//   One or more errors occurred.

	class Program {

		static void Main(string[] args) {
			// create a shared collection
			var sharedQueue = new Queue<int>();
			// populate the collection with items to process
			for(int i = 0; i < 1000; i++) {
				sharedQueue.Enqueue(i);
			}

			// define a counter for the number of processed items
			var itemCount = 0;

			// create tasks to process the list
			var tasks = new Task[10];
			for(int i = 0; i < tasks.Length; i++) {
				// create the new task
				tasks[i] = new Task( () => {
					while (sharedQueue.Count > 0) {
						// take an item from the queue
						var item = sharedQueue.Dequeue();
						// increment the count of items processed
						Interlocked.Increment(ref itemCount);
					}
				});

				// start the new task
				tasks[i].Start();
			}
			
			// wait for the tasks to complete
			Task.WaitAll(tasks);

			// report on the number of items processed
			Console.WriteLine("Items processed: {0}", itemCount);
		}
	}
}
