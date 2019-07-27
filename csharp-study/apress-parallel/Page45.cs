// Listing. Page45.cs
/*
	From page 45-46
	Title:
	1. Task Dependency Deadlock
	2. Solution
	3. Example
	
	Task Dependency Deadlock
	If two or more Tasks depend on each other to complete, none move
	forward without the others, so a deadlock ( the condition where
	the Tasks involved cannot progress) occurs.
	
	Solution
	The only way to avoid this problem is to ensure that your Tasks
	do not depend on one another. This requires careful attention when
	writing your Task bodies and thorough testing. You can also use the
	debugging features of Visual Studio 2010 to help detect deadlock
	(see Chapter 7 details).
	
	Example
	In the following example, two Task depend upon one another, and
	each requires the result of the other to generate its own result.
	When the program is run, both Tasks are started by the main application
	thread and dealock. Because the main thread waits for the Tasks
	to finish, the whole program seizes up and never completes.
	
	<code list>
*/

using System;
using System.Threading.Tasks;

namespace Page45 {
	class Dependency_Deadlock {
		static void Main(string[] args) {
			
			// define an array to hold the Tasks
			Task<int>[] tasks = new Task<int>[2];
			
			// create and start the first task
			tasks[0] = Task.Factory.StartNew(()=>{
				// get the result of the other task,
				// add 100 to it and return it as the result
				return tasks[1].Result + 100;
			});
			
			// create and start second task
			tasks[1] = Task.Factory.StartNew(()=>{
				// get the result of the other task,
				// add 100 to it and return it as the result.
				return tasks[1].Result + 100;
			});
			
			// wait for the tasks to complete
			// Test result: You will get a long long waitness.
			Task.WaitAll(tasks);
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}
