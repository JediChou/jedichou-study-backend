// Listing 3-13. Interprocess Mutex Use

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0313 {
	class Program {
		static void Main(string[] args) {
			var mutexName = "myApressMutex";
			Mutex namedMutext;  // declare the mutext

			try {
				// test to see if te named mutex already exists
				namedMutext = Mutex.OpenExisting(mutexName);
			} catch (WaitHandleCannotBeOpenedException) {
				// the mutext does not exist - we must create it
				namedMutext = new Mutex(false, mutexName);
			}

			// create the task
			var task = new Task( () => {
				while (true) {
					// acquire the mutex
					Console.WriteLine("Waiting to acquire Mutex");
					namedMutext.WaitOne();
					Console.WriteLine("Acquired Mutex - press enter to release");
					Console.ReadLine();
					namedMutext.ReleaseMutex();
					Console.WriteLine("Released Mutex");
				}
			});

			task.Start();
			task.Wait();
		}
	}
}
