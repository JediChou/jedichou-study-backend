using System;
using System.Configuration;

namespace ReadAppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", ReadAppKey("UserName"));
            Console.WriteLine("{0}", ReadAppKey("Homeland"));
        }

        static string ReadAppKey(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                var result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return "Error";
            }
        }
    }
}
