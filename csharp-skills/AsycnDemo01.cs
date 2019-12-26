using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace AsycnDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDumpPage();
            UseCallWebApi();
        }

        public static void UseDumpPage()
        {
            try
            {
                var start = new Stopwatch();
                start.Start();
                DumpWebPage("http://esign.efoxconn.com").Wait();
                start.Stop();
                Console.WriteLine(start.ElapsedMilliseconds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static async Task DumpWebPage(string uri)
        {
            var webClient = new WebClient();
            var page = await webClient.DownloadStringTaskAsync(uri);
            Console.WriteLine(page);
            Console.WriteLine(page.Length);
        }

        private static void UseCallWebApi()
        {
            try
            {
                var start = new Stopwatch();
                start.Start();
                CallWebApi().Wait();
                start.Stop();
                Console.WriteLine(start.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an exception: {ex}");
            }
        }

        private static async Task CallWebApi()
        {
            var response = await WebRequest
                .Create("http://esign.efoxconn.com")
                .GetResponseAsync()
                .ConfigureAwait(false);
            Console.WriteLine(response.Headers);
        }
    }
}
