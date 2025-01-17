// Listing 3-20. Using the ConcurrentBag Class
//
// ConcurrentBag:
//   The ConcurrentBag class implements an unordered collection, such
//   that the order in which items are added does not guarantee the
//   order in which they will be returned. Items are added with the
//   Add() method, returned and removed from the collection with the
//   TryTake() method, and returned without being removed with the
//   TryPeek() method. This demonstrates use of the ConcurrentBag
//   collection.

using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0320
{
	class Program
	{
		static void Main(string[] args) {
			// create a shared collection
			var sharedBag = new ConcurrentBag<int>();

			// populate the collection with items to process
			for(int i = 0; i < 1000; i++)
				sharedBag.Add(i);

			// define a counter for the number of processed items
			var itemCount = 0;

			// create tasks to process the list
			var tasks = new Task[10];
			for(int i = 0; i < tasks.Length; i++) {
				// create the new task
				tasks[i] = new Task( () => {
					while (sharedBag.Count > 0) {
						// define a variable for the dequeue requests
						int queueElement;
						// take an item from the queue
						var gotElement = sharedBag.TryTake(out queueElement);
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

	} // end program
} // end namespace
