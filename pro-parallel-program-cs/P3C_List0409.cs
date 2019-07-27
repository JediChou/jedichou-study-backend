// Listing 4-9. Propagating Exceptions Along a Continuation Chain

using System;
using System.Threading.Tasks;

namespace Listing0409
{
	class Program
	{
		static void Main(string[] args) {
			// create a first generation task
			var gen1 = new Task( () => {
				// write out a message
				Console.WriteLine("First generation task");
			});

			// create a second-generation task
			var gen2 = gen1.ContinueWith( antecedent => {
				// write out a message
				Console.WriteLine("Second generation task - throws exception");
				throw new Exception();
			});

			// create a third-generation task
			var gen3 = gen2.ContinueWith( ancetedent => {
				// check to see if the antecedent threw an exception
				if (ancetedent.Status == TaskStatus.Faulted) {
					// get an rethrow the antecedent exception
					throw ancetedent.Exception.InnerException;
				}
				// write out a message
				Console.WriteLine("Third generation task");
			});

			// start the first gen task
			gen1.Start();

			try {
				// wait for the last task in the chain to complete
				gen3.Wait();
			} catch (AggregateException ex) {
				//ex.Handle( inner => {
				//	Console.WriteLine("Handled exception of type: {0}", inner.GetType());
				//});
				Console.WriteLine(ex.Message);
			}
		}
	}
}
