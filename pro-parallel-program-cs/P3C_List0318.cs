// Listing 3-18. Using the ConcurrentQueue Class

using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0318 {
	class Program {
		static void Main(string[] args) {
			// create a shared collection
			var sharedQueue = new ConcurrentQueue<int>();

			// populate the collection with items to process
			for(int i = 0; i < 1000; i++)
				sharedQueue.Enqueue(i);

			// define a counter for the number of processed items
			var itemCount = 0;

			// create tasks to process the list
			var tasks = new Task[10];
			for(int i = 0; i < tasks.Length; i++) {
				// create the new task
				tasks[i] = new Task( () => {
					while (sharedQueue.Count > 0) {
						// define a variable for the dequeue request
						int queueElement;
						// take an item from the queue
						var gotElement = sharedQueue.TryDequeue(out queueElement);
						// increment the count of items processed
						if (gotElement) {
							Interlocked.Increment(ref itemCount);
						}
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
