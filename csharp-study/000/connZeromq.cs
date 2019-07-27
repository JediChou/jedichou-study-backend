//
// Hello World client
// Connects REQ socket to tcp://localhost:5555
// Sends "Hello" to server, expects "World" back
//
// From http://zguide.zeromq.org/cs:hwclient
// Author: Michael Compton, Tomas Roos
// Email: michael.compton@littleedge.co.uk, ptomasroos@gmail.com

using System;
using System.Text;
using ZeroMQ;

namespace zguide.hwclient
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			using ( var context = ZmqContent.Create() )
			{
				using ( ZmqSocket requester = context.CreateSocket(SocketType.REQ) )
				{
					requester.Connect("tcp://localhost:5555");

					const string requestMessage = "Hello";
					const int requestsToSend = 10;

					for( int requestsNumber = 0; requestNumber < requestsToSend; requestsNumber++)
					{
						Console.WriteLine("Sending request {0}...", requestNumber);
						requester.Send(requestMessage, Encoding.Unicode);

						string replay = requester.Receive(Encoding.Unicode);
						Console.WriteLine("Received replay {0}: {1}", requestNumber, replay);
					}
				}
			}
		}
	}
}
