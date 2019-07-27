using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("Server.exe <port>");
                return;
            }

            string port = args[0];

            //IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            //IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint m_LocalEndPoint = new IPEndPoint(ipAddress, int.Parse(port));

            try
            {
                // Create a TCP/IP socket.
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Bind(m_LocalEndPoint);
                s.Listen(10);

                Console.WriteLine("IpAddress: " + ipAddress.ToString());
                Console.WriteLine("Port     : " + port);

                byte[] buff = new byte[1];

                Socket s2 = s.Accept();
                Console.WriteLine("connected");

                while (true)
                {
                    s2.Receive(buff, 1, SocketFlags.None);
                    s2.Send(buff);
					var accepted_message = System.Text.Encoding.Default.GetString(buff);
					Console.WriteLine("Message: {0}, by: {1}", accepted_message, DateTime.Now);
                }
            }
            catch( Exception ex )
            {
				Console.WriteLine(ex.Message);
				
            }
        }
    }
}
