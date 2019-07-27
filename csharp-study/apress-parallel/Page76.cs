// Listing 3-13. Interprocess Mutex Use
// 
// Tips
// Listing 3-13 shows how to use the OpenExisting() method and
// the overloaded constructor to test for, create, and use a
// shared Mutex. To test this liting, you must run tow or more
// instance of the compiled program. Control of the Mutex will
// pass from process to process each time you press the Enter key.
// If you compile and run the code in this listing, the program
// will loop forever, so you can safely close the console window
// when you have had enough.

namespace Listing0313 {
    
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    
    class Listing0313 {
        
        static void Main(string[] args) {
        
            // declare the name we will use for the mutex
            string mutexName = "myApressMutex";
            
            // declare the mutex
            Mutex namedMutext;
            
            try {
                // test to see if the named mutex already exists
                namedMutext = Mutex.OpenExisting(mutexName);
            } catch (WaitHandleCannotBeOpenedException) {
                // the mutext does not exist -  we must create it
                namedMutext = new Mutex(false, mutexName);
            }
            
            // create the task
            Task task = new Task(()=>{
                while(true) {
                    // acquire the mutex
                    Console.WriteLine("Waiting to acquire Mutex");
                    namedMutext.WaitOne();
                    Console.WriteLine("Acquired Mutex - press enter to release");
                    Console.ReadLine();
                    namedMutext.ReleaseMutex();
                    Console.WriteLine("Released Mutex");
                }
            });
            
            // start the task
            task.Start();
            
            // wait for the task to complete
            task.Wait();
        }
    }
}
