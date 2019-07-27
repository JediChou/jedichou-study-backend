using System;
using System.Collections;

namespace QueueExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var queue = new Queue();
			
			queue.Enqueue('A');
			queue.Enqueue('M');
			queue.Enqueue('G');
			queue.Enqueue('W');
			
			// output initila queue
			System.Console.WriteLine("Current queue: ");
			iterQueue(queue);
			
			// other operator
			queue.Enqueue("V");
			queue.Enqueue("H");
			iterQueue(queue);
			
			// Dequeue
			queue.Dequeue();
			queue.Dequeue();
			iterQueue(queue);
		}
		
		private static void iterQueue(Queue queue)
		{
			foreach (var character in queue)
				System.Console.Write("{0} ", character);
			System.Console.WriteLine();
		}
	}
}