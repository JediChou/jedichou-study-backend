using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_CreateTransactionalQueues
{
    /// <summary>
    /// Reference: https://msdn.microsoft.com/zh-cn/library/0t144497(v=vs.90).aspx
    /// Description: Create a transaction queue
    /// </summary>
    class Program
    {
        const string qname1 = @"FormatName:DIRECT=TCP:10.130.2.217\Private$\pvtmsmq";
        const string qname2 = ".\\MyTranscation";

        /// <summary>
        /// Program Start Here !
        /// </summary>
        static void Main(string[] args)
        {
            if (MQExists(qname2))
            {
                DeleteTransactionMQ(qname2);
                Console.WriteLine("MSMQ: {0} deleted !", qname2);
            }
            else
            {
                CreateTransactionMQ(qname2);
                Console.WriteLine("MSMQ: {0} created !", qname2);
            }
        }

        /// <summary>
        /// Check MSMQ is exists
        /// </summary>
        /// <param name="path">MSMQ's path</param>
        private static bool MQExists(string path)
        {
            try
            {
                return MessageQueue.Exists(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        /// <summary>
        /// Create a transaction msmq
        /// </summary>
        /// <param name="path">MSMQ's path</param>
        private static bool CreateTransactionMQ(string path)
        {
            try
            {
                var messageQueue = new MessageQueue();
                messageQueue = MessageQueue.Create(path, true);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        /// <summary>
        /// Delete a transaction msmq
        /// </summary>
        /// <param name="path">MSMQ's path</param>
        private static bool DeleteTransactionMQ(string path)
        {
            try
            {
                MessageQueue.Delete(path);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}
