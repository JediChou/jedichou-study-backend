using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;
using System.Xml;

namespace msmq_0303_SendXMLMessage
{
    public class XmlSender
    {
        private XmlDocument p_xmldoc;
        private string billno;
        private string billxml;
        private string gwMsmqPath;
        private MessageQueue Mqueue;
        private Message Mmessage;
        private MessageQueueTransaction MsgTx;

        public XmlSender(string ip, string qname, string billno, string billxml)
        {
            this.billno = billno;
            this.billxml = billxml;
            gwMsmqPath = string.Format("FormatName:Direct=TCP:{0}\\private$\\{1}", ip, qname);
            Mqueue = new MessageQueue(gwMsmqPath, true);
            Mmessage = new Message();
            p_xmldoc = new XmlDocument();
            p_xmldoc.LoadXml(billxml);
        }

        public bool Send()
        {
            MsgTx = new MessageQueueTransaction();
            MsgTx.Begin();

            try
            {
                p_xmldoc.Save(Mmessage.BodyStream);
                Mmessage.Formatter = new BinaryMessageFormatter();
                Mqueue.Send(Mmessage, billno, MsgTx);
                MsgTx.Commit();
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("thread execute failed!");
                MsgTx.Dispose();
                Mqueue.Dispose();
                throw;
            }
        }
    }
}
