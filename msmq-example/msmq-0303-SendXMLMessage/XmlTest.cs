using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace msmq_0303_SendXMLMessage
{
    /// <summary>
    /// 测试执行
    /// </summary>
    public class XmlTest
    {
        /// <summary>
        /// 执行XmlTest的测试容器
        /// </summary>
        private List<XmlSender> senders = new List<XmlSender>();

        /// <summary>
        /// XmlTest的测试入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ExecuteMqtest(100000);
        }

        /// <summary>
        /// 进行XmlTest的辅助函数
        /// </summary>
        /// <param name="nums"></param>
        private static void ExecuteMqtest(int nums)
        {
            var sw = Stopwatch.StartNew();
            Thread t = new Thread(() =>
            {
                var xmltest = new XmlTest();
                xmltest.mqtest(nums);
            });
            t.Start();
            sw.Stop();
            Console.WriteLine(
                "Execute date: {0}, Thread:{1}, Execute:{2} ms", 
                DateTime.Now,
                nums, 
                sw.ElapsedMilliseconds
            );
        }

        /// <summary>
        /// 实际执行XmlTest性能测试的方法
        /// </summary>
        /// <param name="thread_nums"></param>
        private void mqtest(int thread_nums)
        {
            senders.Clear();

            for (int i = 0; i < thread_nums; i++)
                senders.Add(Help.GetXmlSender(i));

            Parallel.ForEach(senders, (sender) => {
                sender.Send();
            });
        }
    }
}
