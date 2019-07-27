// Listing 4-7. Cancelling Continuations

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0407
{
	class Program
	{
		static void Main(string[] args)
		{
			// create a cancellation token source
			var tokenSource = new CancellationTokenSource();

			// create the antecedent task
			var task = new Task( () => {
				// write out a message
				Console.WriteLine("Antecedent running");
				// wait indefinately on the token wait handle
				tokenSource.Token.WaitHandle.WaitOne();
				// handle the cancellation exception
				tokenSource.Token.ThrowIfCancellationRequested();
			}, tokenSource.Token);

			// create a selective continuation
			var neverScheduled = task.ContinueWith( antecedent => {
				// write out a message
				Console.WriteLine("This task will never be scheduled");
			}, tokenSource.Token);

			// create a bad selective continuation
			var badSelective = task.ContinueWith( antecedent => {
				// write out a message
				Console.WriteLine("This task will never be scheduled");
			}, tokenSource.Token, TaskContinuationOptions.OnlyOnCanceled, TaskScheduler.Current);

			// create a good selective continuation
			var continuation = task.ContinueWith( antecedent => {
				// write out a message
				Console.WriteLine("Continuation running");
			}, TaskContinuationOptions.OnlyOnCanceled);

			// start the task
			task.Start();

			// prompt the user so they can cancel the token
			Console.WriteLine("Press enter to cancel token");
			Console.ReadLine();
			// cancel the token source
			tokenSource.Cancel();

			// wait for the good continuation to complete
			continuation.Wait();
		}
	}
}
