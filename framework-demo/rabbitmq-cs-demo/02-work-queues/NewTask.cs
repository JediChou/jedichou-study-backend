using System;
using RabbitMQ.Client;
using System.Text;

class Send
{
	public static void Main(string[] args)
	{
		var factory = new ConnectionFactory() { HostName = "localhost" };
		using (var connection = factory.CreateConnection())
		{
			using (var channel = connection.CreateModel())
			{
				channel.QueueDeclare("hello", false, false, false, null);

				var message = GetMessage(args);
				var body = Encoding.UTF8.GetBytes(message);

				var properties = channel.CreateBasicProperties();
				properties.DeliveryMode = 2;

				channel.BasicPublish("", "hello", properties, body);
				Console.WriteLine(" [x] Send {0}", message);
			}
		}
	}

	private static string GetMessage(string[] args)
	{
		return ((args.Length > 0) ? string.Join(" ", args) : "Hello World!");
	}
}
