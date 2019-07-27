using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_RetrieveQueues
{
    /// <summary>
    /// Reference: https://msdn.microsoft.com/zh-cn/library/9ss0c06x(v=vs.90).aspx
    /// Description: How to retrive msmq
    /// </summary>
    class Program
    {
        /// <summary>
        /// msmq's prefix
        /// </summary>
        static string pname = @".\Private$\";
        
        /// <summary>
        /// msmq's basic name
        /// </summary>
        static List<string> paths = new List<string> { "RetrieveQueues1", "RetrieveQueues2", "RetrieveQueues3" };

        /// <summary>
        /// Program Start Here !
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                // process paths
                for (int i = 0; i < paths.Count; i++)
                    paths[i] = string.Format("{0}{1}", pname, paths[i]);

                // Create some public msmq
                foreach (var path in paths)
                    if (!MQExists(path))
                        CreateMSMQ(path);

                // Output these public msmq's path info
                var mqs = MessageQueue.GetPrivateQueuesByMachine(".");
                foreach (var mq in mqs)
                    Console.WriteLine(mq.Path);

                // Delete these msmq
                foreach (var path in paths)
                    DeleteMSMQ(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("God, there has a exception");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Delete a exists msmq
        /// </summary>
        /// <param name="path">msmq path</param>
        private static void DeleteMSMQ(string path)
        {
            try
            {
                if (MQExists(path))
                    MessageQueue.Delete(path);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Create a does not exists msmq
        /// </summary>
        /// <param name="path">the part path of msmq</param>
        private static void CreateMSMQ(string path)
        {
            try
            {
                if (!MQExists(path))
                    MessageQueue.Create(path);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check MSMQ exists
        /// </summary>
        /// <param name="path">the part path of msmq</param>
        /// <returns></returns>
        private static bool MQExists(string path)
        {
            try
            {
                return MessageQueue.Exists(path);
            }
            catch
            {
                throw;
            }
        }
    }
}
