// File name: CrossProxy.cs
// Description: Cross Proxy to get html content
// Reference: <C#用HttpWebRequest通过代理服务器验证后抓取网页内容>

namespace CrossProxy
{
	using System;
	using System.IO;
	using System.Net;
	using System.Text;

	class Program
	{
		static void Main(string[] argv)
		{
			// Define a httpwebrequest
			var url = argv[0];
			HttpWebRequest hwr = (HttpWebRequest)HttpWebRequest.Create(url);
			hwr.Timeout = 20000;

			// define webproxy object
			WebProxy proxy = new WebProxy();
			proxy.Address = new Uri("http://10.191.131.3:3128");
			proxy.Credentials = new NetworkCredential("f3216338", "samsung00s");
			hwr.UseDefaultCredentials = true;

			// Connect
			try
			{
				HttpWebResponse hwrs = (HttpWebResponse)hwr.GetResponse();

				if ( hwrs.StatusCode != HttpStatusCode.OK )
				{
					Console.WriteLine("Connect sucess! But response is null.");
					hwrs.Close();
				} else {
					var stream = hwrs.GetResponseStream();
					var reader = new StreamReader(stream, Encoding.UTF8);
					while ( reader.Peek() != -1)
						Console.WriteLine(reader.ReadLine() + "\r\n");			
				}
			} 
			catch (Exception e)
			{
				Console.WriteLine("Can not connected. Error message:");
				Console.WriteLine(e.Message);
			}

			// end here
			// TODO Inside Foxconn this code can not cross HAProxy. :-(
		}
	}
}
