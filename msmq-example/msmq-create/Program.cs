using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_create
{
    class Program
    {
        static void Main(string[] args)
        {
            var mystr = "Jedi";
            CreateLocalPrivateQueue(mystr);
            UsePurgeDeletePrivateQueue(mystr);
            DeleteLocalPrivateQueue(mystr);
        }

        /// <summary>
        /// 创建公共队列
        /// </summary>
        static void CreatePublicQueue(string queue)
        {
            // notice: 在工作组模式下无法创建公共队列
            // Create a public message queue
            MessageQueue.Create(@"MyQueue");
        }

        /// <summary>
        /// 创建私有队列
        /// </summary>
        /// <param name="queue"></param>
        static void CreateLocalPrivateQueue(string queue)
        {
            var queStr = string.Format(@".\Private$\{0}", queue);
            MessageQueue.Create(queStr);
        }

        /// <summary>
        /// 删除私有队列
        /// </summary>
        static void DeleteLocalPrivateQueue(string queue)
        {
            var queStr = string.Format(@".\Private$\{0}", queue);
            MessageQueue.Delete(queStr);
        }

        /// <summary>
        /// 使用Purge方法删除有权限的队列
        /// TODO 此方法有问题
        /// </summary>
        static void UsePurgeDeletePrivateQueue(string queue)
        {
            System.Messaging.MessageQueue msgqu = new System.Messaging.MessageQueue();
            msgqu.Path = string.Format(@".\Private$\{0}", queue);
            msgqu.Purge();
            Console.WriteLine(msgqu.Path);
        }
    }
}
