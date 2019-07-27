using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace dynatrce_cstest
{
    class Program
    {
        static void Main(string[] args)
        {
            var pre = "http://10.134.158.203:8080";
            var urls = new List<string> {
                "/dynatrace/index.html",
                "/dynatrace/jstest/test-mdn-error1.html",
                "/dynatrace/jstest/test-mdn-error2.html",
                "/dynatrace/jstest/test-mdn-error3.html",
                "/dynatrace/jstest/test-mdn-error4.html",
                "/dynatrace/jstest/test-mdn-error5.html",
                "/dynatrace/jstest/test-mdn-error6.html",
                "/dynatrace/jstest/test-mdn-error7.html",
                "/dynatrace/jstest/test-mdn-error8.html",
                "/dynatrace/jstest/test-mdn-error9.html",
                "/dynatrace/jstest/test-mdn-error10.html",
                "/dynatrace/jstest/test-mdn-error11.html",
                "/dynatrace/jstest/test-mdn-error12.html",
                "/dynatrace/jstest/test-mdn-error13.html",
                "/dynatrace/jstest/test-mdn-error14.html",
                "/dynatrace/jstest/test-mdn-error15.html",
                "/dynatrace/jstest/test-mdn-error16.html",
                "/dynatrace/jstest/test-mdn-error17.html",
                "/dynatrace/jstest/test-mdn-error18.html",
                "/dynatrace/jstest/test-mdn-error19.html",
                "/dynatrace/jstest/test-mdn-error20.html",
                "/dynatrace/jstest/test-mdn-error21.html",
                "/dynatrace/jstest/test-mdn-error22.html",
                "/dynatrace/jstest/test-mdn-error23.html",
                "/dynatrace/jstest/test-mdn-error24.html",
                "/dynatrace/jstest/test-mdn-error25.html",
                "/dynatrace/jstest/test-mdn-error26.html",
                "/dynatrace/jstest/test-mdn-error27.html",
                "/dynatrace/jstest/test-mdn-error28.html",
                "/dynatrace/jstest/test-mdn-error29.html",
                "/dynatrace/jstest/test-mdn-error30.html",
                "/dynatrace/jstest/test-mdn-error31.html",
                "/dynatrace/jstest/test-mdn-error32.html",
                "/dynatrace/jstest/test-mdn-error33.html",
                "/dynatrace/jstest/test-mdn-error34.html",
                "/dynatrace/jstest/test-mdn-error35.html",
                "/dynatrace/jstest/test-mdn-error36.html",
                "/dynatrace/jstest/test-mdn-error37.html",
                "/dynatrace/jstest/test-mdn-error38.html",
                "/dynatrace/jstest/test-mdn-error39.html",
                "/dynatrace/jstest/test-mdn-error40.html",
                "/dynatrace/jstest/test-mdn-error41.html",
                "/dynatrace/jstest/test-mdn-error42.html",
                "/dynatrace/jstest/test-mdn-error43.html",
                "/dynatrace/jstest/test-mdn-error44.html",
                "/dynatrace/jstest/test-mdn-error45.html",
                "/dynatrace/htmltest/html-error1.html", 
                "/dynatrace/htmltest/html-error2.html",
                "/dynatrace/htmltest/html-error3.html ",
                "/dynatrace/csstest/css-error1.html"
            };

            // 策略1
            for (int i = 0; i < 900000; i++)
            {
                foreach (var url in urls)
                {
                    var current = string.Format("{0}{1}", pre, url);
                    RequestUrl(current);
                }
            }

            // 策略2
            //Parallel.ForEach(urls, (url) =>
            //{
            //    var current = string.Format("{0}{1}", pre, url);
            //    RequestUrl(current);
            //});
        }

        /// <summary>
        /// RequestUrl
        /// </summary>
        /// <param name="url">test url</param>
        private static void RequestUrl(string url)
        {
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create(url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}
