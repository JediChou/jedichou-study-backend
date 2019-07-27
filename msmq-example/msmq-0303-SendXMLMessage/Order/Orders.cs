using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace msmq_0303_SendXMLMessage
{
    public class Orders
    {
        /// <summary>
        /// 支付单
        /// </summary>
        string PaymentOrder;
        
        /// <summary>
        /// 运单
        /// </summary>
        string WayBill;
        
        /// <summary>
        /// 清单
        /// </summary>
        string ProductList;
        
        /// <summary>
        /// 订单
        /// </summary>
        string PayOrder;

        /// <summary>
        /// 构造函数, 用于初始化4个单据的原始字符串
        /// </summary>
        public Orders()
        {
            PaymentOrder = Help.GetXmldocString(OrderLocation.Path_PaymentOrder);
            WayBill = Help.GetXmldocString(OrderLocation.Path_WayBill);
            ProductList = Help.GetXmldocString(OrderLocation.Path_ProductList);
            PayOrder = Help.GetXmldocString(OrderLocation.Path_PayOrder);
        }

        /// <summary>
        /// 获取支付单
        /// </summary>
        /// <returns>支付单字符串</returns>
        public string GetPaymentOrder()
        {
            return PaymentOrder;
        }

        /// <summary>
        /// 获取运单
        /// </summary>
        /// <returns>运单字符串</returns>
        public string GetWayBill()
        {
            return WayBill;
        }

        /// <summary>
        /// 获取清单
        /// </summary>
        /// <returns>清单字符串</returns>
        public string GetProductList()
        {
            return ProductList;
        }

        /// <summary>
        /// 获取订单
        /// </summary>
        /// <returns>订单字符串</returns>
        public string GetPayOrder()
        {
            return PayOrder;
        }
    }
}
