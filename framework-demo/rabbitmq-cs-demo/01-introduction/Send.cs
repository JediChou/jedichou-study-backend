using System;
using RabbitMQ.Client;
using System.Text;

class Send
{
	public static void Main()
	{
		var factory = new ConnectionFactory() { HostName = "localhost" };
		using (var connection = factory.CreateConnection())
		{
			using (var channel = connection.CreateModel())
			{
				channel.QueueDeclare("hello", false, false, false, null);

				var message = "Hello World!";
				var body = Encoding.UTF8.GetBytes(message);

				channel.BasicPublish("", "hello", null, body);
				Console.WriteLine(" [x] Send {0}", message);
			}
		}
	}
}
