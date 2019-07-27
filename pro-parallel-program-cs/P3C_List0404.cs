// Listing 4-4. Continuations Based on Exceptions
using System;
using System.Threading.Tasks;

namespace Listing0404 {
	class Program {
		static void Main(string[] args) {

			// create the first generation task
			var firstGen = new Task( ()=> {
				Console.WriteLine("Message from first generation task");
				throw new Exception();
			});

			// create the second-generation task - only to run on exception
			var secondGen1 = firstGen.ContinueWith(antecedent => {
				// write out a message with the antecedent exception
				Console.WriteLine(
					"Antecedent task faulted with type: {0}",
					antecedent.Exception.GetType());
			}, TaskContinuationOptions.OnlyOnFaulted);

			// create the second-generation task - only to run on no exception
			var secondGen2 = firstGen.ContinueWith( antecedent => {
				Console.WriteLine("Antecedent task NOT faulted");
			}, TaskContinuationOptions.NotOnFaulted);

			// start the first generation task
			firstGen.Start();
		}
	}
}
