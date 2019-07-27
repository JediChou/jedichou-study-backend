using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace HeatOnResearch.httprecipes.ch1.Recipe0101
{
	class SimpleWebServer
	{
		/// <summary>
		/// The server socket that will listen for connnections
		/// </summary>
		private Socket server;

		/// <summary>
		/// Construct the web server to listen to the
		/// specified port.
		/// </summary>
		/// <param name="port">The port to tuse for the server.</param>
		public SimpleWebServer(int port)
		{
			server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
			server.Bind(new IPEndPoint(IPAddress.Loopback, port));
		}

		/// <summary>
		/// The run method endlessly waits for connections.
		/// As each connection is opened(from web browser)
		/// the connection is passed off to 
		/// handleClientSession.
		/// </summary>
		public void run()
		{
			server.Listen(10);
			for(;;)
			{
				Socket socket = server.Accept();
				HandlerClientSession(socket);				
			}
		}

		

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			var webServer = new SimpleWebServer(7777);
		}
	}
}
