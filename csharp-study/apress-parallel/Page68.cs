// Listing 3-8.
//   Using a Single Lock Object to Serialize Access
//
// Listing 3-8 shows how we can use Interlocked

namespace Listing_0308 {
    
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    
    class BankAccount {
        public int Balance = 0;
    }
    
    class Listing_0308 {
        static void Main(string[] args) {
            
            // create the bank account instance
            BankAccount account = new BankAccount();
            
            // create an array of tasks
            Task[] tasks = new Task[10];
            
            for(int i=0; i<10; i++) {
                // create a new task
                tasks[i] = new Task(()=>{
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++) {
                        // update the balance
                        Interlocked.Increment(ref account.Balance);
                    }
                });
                
                // start the new task
                tasks[i].Start();
            }
            
            // wait for all of the tasks to complete
            Task.WaitAll(tasks);
            
            // write out the counter value
            Console.WriteLine("Expected value: 10000");
            Console.WriteLine("Balance: {0}", account.Balance);
            
            // wait for input before exiting
            Console.WriteLine("Press enter to finish.");
            Console.ReadLine();
        }
    }
}
