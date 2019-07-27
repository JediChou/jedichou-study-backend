// Listing 3-10.
//   Convergent Isolation with Interlocked. CompareExchange()
//
// The System.Threading.Spinlock class is a lightweight, spin-based
// synchronization primitive. It has a similar structure to other
// primitives in that it relies on Enter(), TryEnter(), and Exit() 
// methods to acquire and release the lock. Listing 3-10 shows the
// bank account example implemented using SpinLock.

namespace Listing_0310 {
    
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
            
            // create the spinlock
            SpinLock spinlock = new SpinLock();
            
            // create an array of tasks
            Task[] tasks = new Task[10];
            
            for(int i=0; i<10; i++) {
                // create a new task
                tasks[i] = new Task(()=>{
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++) {
                        bool lockAcquired = false;
                        try{
                            spinlock.Enter(ref lockAcquired);
                            // update the balance
                            account.Balance = account.Balance + 1;
                        } finally {
                            if( lockAcquired) spinlock.Exit();
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
