namespace msmq_0301_ConnectRemoteServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Messaging;
    
    /// <summary>
    /// 测试连接至远程的MSMQ服务
    /// </summary>
    public class Program
    {
        // 定义一个消息队列字符串
        private const string MQName = "FormatName:Direct=TCP:10.130.2.211\\private$\\jedi";

        static void Main(string[] args)
        {
            
            // 创建一个消息组
            string[] messages = { 
                "Jedi", "Ray", "XiaoBin", "BingJun"
            };

            try
            {
                var mq = new MessageQueue(MQName);
                foreach (var message in messages)
                    mq.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
