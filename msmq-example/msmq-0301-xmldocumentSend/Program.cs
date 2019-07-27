using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Messaging;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace msmq_0301_xmldocumentSend
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义一个远端的
            // var gwMsmqPath = @"FormatName:DIRECT=TCP:10.130.2.211\Private$\jedi";
            var gwMsmqPath = @".\private$\jedi";
            
            // 定义一个xmlstring对象
            var doc = ReadXML2String();
            var billxml = ConvertXmlToString(doc);
            // Console.WriteLine(result.GetType());
            // Console.WriteLine(result);

            // 创建一个xmldocument对象, 并加载账单信息
            XmlDocument p_xmldoc = new XmlDocument();
            p_xmldoc.LoadXml(billxml);

            // 创建队列实例,消息实例,消息事务实例用于发送信息
            var Mqueue = new MessageQueue(gwMsmqPath, true);
            var Mmessage = new Message();
            var MsgTx = new MessageQueueTransaction();

            // 开始发送消息
            MsgTx.Begin();
            try
            {
                // p_xmldoc.Save(Mmessage.BodyStream);
		        // Mmessage.Formatter = new BinaryMessageFormatter();
		        // Mqueue.Send(Mmessage, "JediChou", MsgTx);
                Mqueue.Send("adadf", "JediChou", MsgTx);
		        MsgTx.Commit();
            }
            catch (Exception)
            {
                MsgTx.Dispose();
                Mqueue.Dispose();
            }

            // 退出程序
            Console.WriteLine("执行结束");
        }

        /// <summary>
        /// 将XML读取到一个字符串中
        /// </summary>
        private static XmlDocument ReadXML2String()
        {
            var path = @"D:\temp\file_sample\支付单.xml";
            var xmldoc = new XmlDocument();
            var reader = new XmlTextReader(path);
            reader.Read();
            xmldoc.Load(reader);
            return xmldoc;
        }

        /// <summary>  
        /// 将XmlDocument转化为string  
        /// </summary>  
        /// <param name="xmlDoc"></param>  
        /// <returns></returns>  
        private static string ConvertXmlToString(XmlDocument xmlDoc)
        {
            MemoryStream stream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(stream, null);
            writer.Formatting = Formatting.Indented;
            xmlDoc.Save(writer);
            StreamReader sr = new StreamReader(stream, System.Text.Encoding.UTF8);
            stream.Position = 0;
            string xmlString = sr.ReadToEnd();
            sr.Close();
            stream.Close();
            return xmlString;
        }
    }
}
