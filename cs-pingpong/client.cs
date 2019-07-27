using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Producer
{    
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("Producer.exe <server_ip> <port>");
                return;
            }

            string ipAddress = args[0];
            string port = args[1];

            Console.WriteLine("IpAddress: " + ipAddress);
            Console.WriteLine("Port     : " + port);

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), int.Parse(port)));

            Console.WriteLine("Press key to start pinging");
            Console.ReadKey();

            byte[] buff = new byte[1];
            Console.WriteLine("Pinging started");
            DateTime start = DateTime.Now;

            for (int i = 0; i < 200000; i++)
            {
				var message = string.Format("Jedi & Mike - counter: {0}", i);
				var byteArray = System.Text.Encoding.Default.GetBytes(message);
				s.Send(byteArray);
                s.Receive(byteArray, 1, SocketFlags.None);
            }

            DateTime end = DateTime.Now;
            Console.WriteLine("Pinging finished in: {0}", (end - start).TotalSeconds);

            Console.ReadKey();
        }
    }
}
