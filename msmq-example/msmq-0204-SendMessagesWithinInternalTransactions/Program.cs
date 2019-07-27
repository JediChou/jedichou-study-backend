using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_0204_SendMessagesWithinInternalTransactions
{
    /// <summary>
    /// Reference: https://msdn.microsoft.com/zh-cn/library/y93c2k87(v=vs.90).aspx
    /// Description: Send messages within internal transactions
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program Start Here !
        /// </summary>
        static void Main()
        {
            // define msmq path
            var pname = @".\private$\pvtmstt";

            // Check msmq, if does not exists then create it
            if (!MessageQueue.Exists(pname))
                MessageQueue.Create(pname);

            // send a complex message
            var curMq = new MessageQueue(pname);
            var trans = new MessageQueueTransaction();
            trans.Begin();

            try
            {
                curMq.Send("Jedi", "message-1", trans);
                curMq.Send("Becky", "message-2", trans);
                curMq.Send("CiCi",  "message-3", trans);
                trans.Commit();
            }
            catch
            {
                trans.Abort();
                Console.WriteLine("The transcation abort");
            }

            if (MessageQueue.Exists(pname))
                MessageQueue.Delete(pname);
        }
    }
}
