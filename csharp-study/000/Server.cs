using System;
using System.Text;
using System.Threading;
using NetMQ;

namespace ZMQGuide
{
    class EServer
    {
        static void Main(string[] args)
        {
            using (var context = NetMQContext.Create())
            {
                Server(context);
            }
        }

        static void Server(NetMQContext context)
        {
            using (var serverSocket = context.CreateResponseSocket())
            {
                serverSocket.Bind("tcp://*:5555");
                while (true)
                {
                    string message = serverSocket.ReceiveString();
                    Console.WriteLine("收到的信息是 {0}", message);
                    serverSocket.Send("World");
                    if (message == "Exit")
                        break;
                }
            }
        }
    }
}
