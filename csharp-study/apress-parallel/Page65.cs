// Listing 3-7.
//   Using a Single Lock Object to Serialize Access
//
// Listing 3-7 extends our simple bank account example to
// serialize access to critical regions. There are two groups
// of Tasks, one of which wants to increment the balance
// while the other wants to decrement it. By using the same
// lock object, we ensure that there is at most one Task
// working in the pair of critical regions.

namespace Listing_0307 {
    
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    
    class BankAccount {
        public int Balance {
            get;
            set;
        }
    }
    
    class Listing_0307 {
        static void Main(string[] args) {
            
            // create the bank account instance
            BankAccount account = new BankAccount();
            
            // create an array of tasks
            Task[] incrementTasks = new Task[5];
            Task[] decrementTasks = new Task[5];
            
            // create the lock object
            object lockObj = new object();
            
            for(int i=0; i<5; i++) {
                // create a new task
                incrementTasks[i] = new Task(()=>{
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++) {
                        lock(lockObj) {
                            // increment the balance
                            account.Balance++;
                        }
                    }
                });
                
                // start the task
                incrementTasks[i].Start();
            }
            
            for(int i=0; i<5; i++) {
                //create a new task
                decrementTasks[i] = new Task(()=>{
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++) {
                        lock(lockObj) {
                            // decrement the balance
                            account.Balance = account.Balance - 2;
                        }
                    }
                });
                
                // start the task
                decrementTasks[i].Start();
            }
            
            // wait for all of the tasks to complete
            Task.WaitAll(incrementTasks);
            Task.WaitAll(decrementTasks);
            
            // write out the counter value
            Console.WriteLine("Expected value: -5000");
            Console.WriteLine("Balance: {0}", account.Balance);
            
            // wait for input before exiting
            Console.WriteLine("Press enter to finish.");
            Console.ReadLine();
        }
    }
}
