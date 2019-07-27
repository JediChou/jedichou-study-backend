// Listing 2-23. Lazy Task Execution
/*
	From page 43-44
	Title: Executing Task Lazily
	
	If you want to perform some work in parallel only when the result
	is required for the first time, you can use lazy task execution,
	which combines lazy variable initialization and the Task<>.Factory.StartNew()
	method.
	
	Lazy variables are not initialized until they are required, allowing
	you to avoid potentially expensive computation until they are needed
	or to doing work for variables that may not be needed at all. You can
	combin lazy variables with tasks to create a task that is not executed
	until the lazy variable is read.
	
	Listing 2-24 demonstrates lazy task execution using two examples: The
	first defines the task body as a function and then uses it to create
	a lazy variable. The second does the saming thing in a single statement.
	I have included the first version because the code is a lot easier to
	understand when the two parts are created separately.
*/

using System;
using System.Threading.Tasks;

namespace Listing_23 {
	class Listing_23 {
		static void Main(string[] args) {
		
			// define the function
			Func<string> taskBody = new Func<string>(()=> {
				Console.WriteLine("Task body working...");
				return "Task Result";
			});
			
			// create the lazy variable
			Lazy<Task<string>> lazyData = new Lazy<Task<string>>(()=>
				Task<string>.Factory.StartNew(taskBody));
				
			Console.WriteLine("Calling lazy variable");
			Console.WriteLine("Result from task: {0}", lazyData.Value.Result);
			
			// do the same thing in a single statement
			Lazy<Task<string>> lazyData2 = new Lazy<Task<string>>(
				()=> Task<string>.Factory.StartNew(()=>{
					Console.WriteLine("Task body working...");
					return "Task Result";
				}));
			
			Console.WriteLine("Calling second lazy variable");
			Console.WriteLine("Result from task: {0}", lazyData2.Value.Result);
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}
