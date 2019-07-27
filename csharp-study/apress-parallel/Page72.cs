// Listing 3-11.
//   Basic Use of the Mutex Class
//
// Tips: Using Wait Handles and the Mutex class
//
// Wait handles are wrappers around a Windows feature called synchronization
// handles. Serveral .NET synchronization primitives that are based on wait
// handless, and they all derive from the System.Threading.WaitHandle class.
// Each class has slightly different characteristics, and we'll walk through
// each of them in the next chapter when we explorer coordinating Tasks.
//
// The wait handle class that has most relevance to avoiding data races and
// is System.Threading.Mutex. Listing 3-11 shows the basic use of the Mutex
// class to solve the bank account data race problem. You acquire the lock on
// Mutex by calling the WaitOne() method and release the lock by calling
// ReleaseMutex(). 

namespace Listing_0311 {
    
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    
    class BankAccount {
        public int Balance {
            get;
            set;
        }
    }
    
    class Listing_0310 {
        static void Main(string[] args) {
        
            // create the bank account instance
            BankAccount account = new BankAccount();
            
            // creat the mutex
            Mutex mutex = new Mutex();
            
            // create an array of tasks
            Task[] tasks = new Task[10];
            
            for(int i=0; i<10; i++) {
                // create a new task
                tasks[i] = new Task(()=>{
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++) {
                        // acquire the mutex
                        bool lockAcquired = mutex.WaitOne();
                        try {
                            // update the balance
                            account.Balance = account.Balance + 1;
                        } finally {
                            // release the mutext
                            if( lockAcquired) mutex.ReleaseMutex();
                        }
                    }
                });
                // start the new task
                tasks[i].Start();
            }
            
            // wait for all of the tasks to complete
            Task.WaitAll(tasks);
            
            // write out the counter value
            Console.WriteLine("Expected value {0}, Balance: {1}",
                              10000, account.Balance);
                              
            // wait for input before exitting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
