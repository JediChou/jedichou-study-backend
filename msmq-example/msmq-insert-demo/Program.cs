using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_insert_demo
{
    /// <summary>
    /// Reference: http://www.dotnetlearners.com/msmq/introduction%20to%20msmq.aspx
    /// Description: Introducation MSMQ
    /// </summary>
    class Program
    {
        /// <summary>
        /// msmq path - style 1
        /// </summary>
        const string qname1 = @"FormatName:DIRECT=TCP:10.130.2.217\Private$\pvtmsmq";
        
        /// <summary>
        /// msmq path - style 2
        /// </summary>
        const string qname2 = @".\Private$\pvtmsmq";

        /// <summary>
        /// Program Start Here!
        /// </summary>
        static void Main(string[] args)
        {
            InsertMessageinQueue();
            Console.WriteLine(RetriveMessageFromQueue());
        }

        /// <summary>
        /// Send a message to local message queuen
        /// </summary>
        private static void InsertMessageinQueue()
        {
            try
            {
                var msmq = new MessageQueue();
                msmq.Path = qname1;
                msmq.Send("Becky", MessageQueueTransactionType.Single);
                msmq.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Read messages from Message Queue.
        /// </summary>
        private static string RetriveMessageFromQueue()
        {
            try
            {
                string mqvalue = string.Empty;
                var mqueu = new MessageQueue(qname1);
                var msgtypes = new System.Type[1];
                msgtypes[0] = mqvalue.GetType();
                mqueu.Formatter = new XmlMessageFormatter(msgtypes);
                mqvalue = mqueu.Receive(new TimeSpan(0, 0, 5), MessageQueueTransactionType.Single).Body.ToString();
                return mqvalue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }
    }
}
