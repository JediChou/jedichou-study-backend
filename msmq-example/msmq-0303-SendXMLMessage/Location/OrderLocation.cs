using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace msmq_0303_SendXMLMessage
{
    public static class OrderLocation
    {
        public static string path = @"D:\file_sample\";
        public static string Path_PaymentOrder = path + "支付单.xml";
        public static string Path_WayBill = path + "运单.xml";
        public static string Path_ProductList = path + "清单.xml";
        public static string Path_PayOrder = path + "订单.xml";
    }
}
