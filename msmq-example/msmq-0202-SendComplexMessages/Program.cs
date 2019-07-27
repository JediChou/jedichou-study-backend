using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_0202_SendComplexMessages
{
    /// <summary>
    /// Reference: https://msdn.microsoft.com/zh-cn/library/33h94ddt(v=vs.90).aspx
    /// Description: Send Complex Messages
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program Start Here!
        /// </summary>
        static void Main()
        {
            // define msmq path
            var pname = @".\JediQueue";

            // Check msmq, if does not exists then create it
            if (!MessageQueue.Exists(pname))
                MessageQueue.Create(pname);

            // send a complex message
            var curMq = new MessageQueue(pname);
            var message = new Message("Hello world");
            message.Label = "This is the label property";
            curMq.Send(message);

            // Delete msmq
            if (MessageQueue.Exists(pname))
                MessageQueue.Delete(pname);
        }
    }
}
