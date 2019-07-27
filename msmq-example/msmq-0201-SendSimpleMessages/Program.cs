using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_0201_SendSimpleMessages
{
    /// <summary>
    /// Reference: https://msdn.microsoft.com/zh-cn/library/05zc5b61(v=vs.90).aspx
    /// Description: Send Simple Message
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program Start Here
        /// </summary>
        static void Main()
        {
            // Define mq path string
            var qname = @".\Private$\YourQueue";

            // If mq does not exist, then create it
            if (!MessageQueue.Exists(qname))
                MessageQueue.Create(qname);
            
            // Send two simple message
            var mq = new MessageQueue(qname);
            mq.Send(1);
            mq.Send("Hello world");

            // Delete it
            MessageQueue.Delete(qname);
        }
    }
}
