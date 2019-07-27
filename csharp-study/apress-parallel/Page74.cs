// Listing 3-12.
//   Acquiring Multiple Lock with Mutex.WaitAll()
//
// Tips: Acquiring Multiple Locks
// 
// All classes that extend from WaitHandle inherit three methods that
// can be used to acquire the lock. You have see the WaitOne() instance
// method in Listing 3-11. In addition, the static WaitAll() and WaitAny()
// methods allow you to acquire multiple locks with one call. Lisitng
// 3-12 demostartes the WaitAll() methods, which causes the Task to block
// until all of the locks can be acquired.

namespace Listing_0312 {
    
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
        
            // creat the bank account instances
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();
            
            // create the mutexs
            Mutex mutex1 = new Mutex();
            Mutex mutex2 = new Mutex();
            
            // create a new task to update the first account
            Task task1 = new Task(()=>{
                // enter a loop for 1000 balance updates
                for( int j=0; j<1000; j++) {
                    // accquire the lock for the account
                    bool lockAcquired = mutex1.WaitOne();
                    try {
                        // update the balance
                        account1.Balance++;
                    } finally {
                        if( lockAcquired ) mutex1.ReleaseMutex();
                    }
                }
            });
            
            // create a new task to update first account
            Task task2 = new Task(()=>{
                // enter a loop for 1000 balance updates
                for( int j=0; j<1000; j++) {
                    // acquire the lock for the account
                    bool lockAcquired = mutex2.WaitOne();
                    try {
                        // update the balance
                        account2.Balance += 2;
                    } finally {
                        if (lockAcquired) mutex2.ReleaseMutex();
                    }
                }
            });
            
            // create a new task to update the first account
            Task task3 = new Task(()=>{
                // enter a loop for 1000 balance updates
                for(int j=0; j<1000; j++) {
                    // accquire the locks for both accounts
                    bool lockAcquired = Mutex.WaitAll(new WaitHandle[] {mutex1, mutex2});
                    try {
                        // simulate a transfer between accounts
                        account1.Balance++;
                        account2.Balance--;
                    } finally {
                        if( lockAcquired) {
                            mutex1.ReleaseMutex();
                            mutex2.ReleaseMutex();
                        }
                    }
                }
            });
            
            // start the tasks
            task1.Start();
            task2.Start();
            task3.Start();
            
            // wait for the tasks to complete
            Task.WaitAll(task1, task2, task3);
            
            // write out the counter value
            Console.WriteLine("Account1 balance {0}, Account2 balance {1}",
                              account1.Balance, account2.Balance);
                              
            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
