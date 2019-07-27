using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_0302_SendMQBySelfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var t = new object();
                var mqsender = new MQSender("jedi", "mis-f3216338", "Fuck HuangYinXiu again and again");
                var result = mqsender.Send("Fuck RenJing.");
                Console.WriteLine(result ? "Success" : "Failed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }
    }
}
