using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace msmq_0303_SendXMLMessage
{
    /// <summary>
    /// XmlTest的Help类
    /// </summary>
    public static class Help
    {
        /// <summary>
        /// 获取
        /// </summary>
        public static string ip = MSMQLocation.ip;
        
        /// <summary>
        /// 
        /// </summary>
        public static string qname = MSMQLocation.qname;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static XmlSender GetXmlSender(int i)
        {
            var t = i.ToString("D6");
            var billno = string.Format("billno-jedi-{0}", t);
            var imod = i % 4;
            var billxml = "";
            var orders = new Orders();

            switch (imod)
            {
                case 0:
                case 1:
                    billxml = orders.GetPaymentOrder();
                    break;
                case 2:
                    billxml = orders.GetWayBill();
                    break;
                case 3:
                    billxml = orders.GetProductList();
                    break;
                case 4:
                    billxml = orders.GetPayOrder();
                    break;
                default:
                    billxml = orders.GetPaymentOrder();
                    break;
            }

            return new XmlSender(ip, qname, billno, billxml);
        }

        /// <summary>
        /// 获得xml的全文字符串
        /// </summary>
        /// <param name="path">xml文件路径</param>
        public static string GetXmldocString(string path)
        {
            if (File.Exists(path))
            {
                var xml = ReadXMLFile(path);
                return ConvertXmlToString(xml);
            }
            else
            {
                throw new Exception("xml文件路径错误");
            }
        }

        /// <summary>
        /// 将XML读取到一个字符串中
        /// </summary>
        public static XmlDocument ReadXMLFile(string path)
        {
            var xmldoc = new XmlDocument();
            var reader = new XmlTextReader(path);
            reader.Read();
            xmldoc.Load(reader);
            return xmldoc;
        }

        /// <summary>  
        /// 将XmlDocument转化为string  
        /// </summary>  
        /// <param name="xmlDoc">xmldocument对象</param>  
        /// <returns>xmldocument转换成的字符串</returns>  
        public static string ConvertXmlToString(XmlDocument xmlDoc)
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
