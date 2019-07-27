// Listing 3-19. Using the ConcurrentStack Class

using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0319 {
	class Program {
		static void Main(string[] args) {
			// create a shared collection
			var sharedStack = new ConcurrentStack<int>();

			// populate the collection with items to process
			for(int i = 0; i < 1000; i++)
				sharedStack.Push(i);

			// deinfe a counter for the number of processed items
			var itemCount = 0;

			// create tasks to process the list
			var tasks = new Task[10];
			for(int i = 0; i < tasks.Length; i++) {
				// create the new task
				tasks[i] = new Task( () => {
					while( sharedStack.Count > 0) {
						// define a variable for the dequeue requests
						int queueElement;
						// taken an item from the queue
						var gotElement = sharedStack.TryPop(out queueElement);
						// increment the count of items processed
						if (gotElement) {
							Interlocked.Increment(ref itemCount);
						}
					}
				});

				// start the new task
				tasks[i].Start();
			}

			// wait for task complete
			Task.WaitAll(tasks);

			// report on the number of items processed
			Console.WriteLine("Items processed: {0}", itemCount);
		}
	}
}
