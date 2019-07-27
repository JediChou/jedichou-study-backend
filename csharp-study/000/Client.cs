using System;
using System.Text;
using System.Threading;
using NetMQ;

namespace ZMQGuide
{
    class EClient
    {
        static void Main(string[] args)
        {
            using (NetMQContext context = NetMQContext.Create())
            {
                Client(context);
            }

        }

        static void Client(NetMQContext context)
        {
            using (NetMQSocket clientSocket = context.CreateRequestSocket())
            {
                clientSocket.Connect("tcp://127.0.0.1:5555");

                while (true)
                {
                    Console.WriteLine("Please enter your message:");
                    string message = Console.ReadLine();
                    clientSocket.Send(message);

                    string answer = clientSocket.ReceiveString();

                    Console.WriteLine("Answer from server: {0}", answer);

                    if (message == "exit")
                    {
                        break;
                    }
                }
            }
        }
    }
}
