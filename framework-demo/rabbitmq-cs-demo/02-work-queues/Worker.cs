using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;

class Receive
{
	public static void Main()
	{
		// Create a connection factory object instance
		var factory = new ConnectionFactory(){HostName="localhost"};
		
		// normal
		using (var connection = factory.CreateConnection())
		{
			using (var channel = connection.CreateModel())
			{
				channel.QueueDeclare("hello", false, false, false, null);

				var consumer = new QueueingBasicConsumer(channel);
				channel.BasicConsume("hello", true, consumer);

				Console.WriteLine(" [*] Waiting for message. To exit press ctrl+c");

				while(true)
				{
					var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

					var body = ea.Body;
					var message = Encoding.UTF8.GetString(body);
					Console.WriteLine(" [x] Received {0}", message);

					int dots = message.Split('.').Length - 1;
					Thread.Sleep(dots * 1000);

					Console.WriteLine(" [x] Done");
				}
			}
		}	
	}
}
