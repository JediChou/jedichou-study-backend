namespace Listing_01
{
	using System;
	using System.Threading.Tasks;

	class Listing_01
	{
		static void Main(string[] args)
		{
			
			// 使用Task.Factory.StartNew();來创
			// 这个只能在.NET 4.0上的版本才能使用
			Task.Factory.StartNew(() => {
				Console.WriteLine("Hello World");
			});

			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine(); 
		}
	}
}
