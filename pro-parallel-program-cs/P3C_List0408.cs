// Listing 4-8. Unhandled Exceptions in Continuation Chains

using System;
using System.Threading.Tasks;

namespace Listing0408
{
	class Program
	{
		static void Main(string[] args) {
			// create a first generation task
			var gen1 = new Task(() => {
				// write out a message
				Console.WriteLine("First generation task");
			});

			// created a second-generation task
			var gen2 = gen1.ContinueWith( antecedent => {
				// write out a message
				Console.WriteLine("Second generation task - throws exception");
				throw new Exception();
			});

			// create a third-generation task
			var gen3 = gen2.ContinueWith( antecedent => {
				// write out a message
				Console.WriteLine("Third generation task");
			});

			// start the first gen task
			gen1.Start();

			// wait for the last task in the chain to complete
			gen3.Wait();
		}
	}
}
