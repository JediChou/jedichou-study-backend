// Listing 3-24
//
// Unexpected Mutability
//   Types that are assumed to be immutable are built from mutable
//   types whose states are changed by another Task. Unexpected and
//   inconsistent program results from the point at which the state
//   change occurs.
//
// Solution
//   There is no programmatic solution to the Unexpected Mutability
//   antipattern. The only way to avoid this problem is to check the
//   field modifiers for all types that you are relying on as being
//   immutable to make sure that they can't be changed.
//
// Example
//   C# does not enforce immutability of complex types; it is
//   possible to declare a field to be readonly and still modify the
//   members of the type instance assigned to it. For example, the
//   following listing shows the type MyImmutableType, which
//   decleares a readonly field of the type MyReferenceData. The PI
//   field of MyReferenceData is not readonly and is changed by the
//   main thread of the program, causing incorrect calculations.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0323
{
	class MyReferenceData { public double PI = 3.14; }
	class MyImmutableType {
		public readonly MyReferenceData refData = new MyReferenceData();
		public readonly int circleSize = 1;
	}

	class Program {
		static void Main(string[] args)
		{
			// create a new instance of the immutable type
			var immutable = new MyImmutableType();

			// create a cancellation token source
			var tokenSource = new CancellationTokenSource();

			// create a task that will calculate the circumference
			// of a 1 unit circle and check the result
			var task1 = new Task( () => {
				while (true) {
					// perform the calculation
					var circ = 2 * immutable.refData.PI * immutable.circleSize;
					Console.WriteLine("Circumference: {0}", circ);
					// check for the mutation
					if (circ == 4) {
						// the mutation has occurred - break
						// out of the loop
						Console.WriteLine("Mutation detected");
						break;
					}
					// sleep for a moment
					tokenSource.Token.WaitHandle.WaitOne(250);
				}
			}, tokenSource.Token);

			// start the task
			task1.Start();

			// wait to let the task start work
			Thread.Sleep(1000);

			// perform the mutation
			immutable.refData.PI = 2;

			// join the task
			task1.Wait();
		}
	}
}
