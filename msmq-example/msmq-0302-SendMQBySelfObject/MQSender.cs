using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace msmq_0302_SendMQBySelfObject
{
    /// <summary>
    /// 自定义的MSMQ发送消息类
    /// </summary>
    class MQSender
    {
        /// <summary>
        /// 字段_mq, 用于实例化一个消息队列对象
        /// </summary>
        private MessageQueue _mq;

        /// <summary>
        /// 字段_message, 用于实例化一个消息字符串
        /// </summary>
        private string _message;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mqname">远端的消息队列名称</param>
        /// <param name="ip">远端消息队列的IP地址</param>
        /// <param name="message">待发送的信息</param>
        public MQSender(string mqname, string ip, string message)
        {
            var remote_mqname = string.Format("FormatName:Direct=TCP:{0}\\private$\\{1}", ip, mqname);
            _mq = new MessageQueue(remote_mqname);
            _message = message;
        }

        /// <summary>
        /// 发送默认消息
        /// </summary>
        /// <returns>发送成功则返回true</returns>
        public bool Send()
        {
            try
            {
                _mq.Send(_message);
                return true;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 发送指定消息
        /// </summary>
        /// <param name="message">指定消息</param>
        /// <returns>发送成功则返回true</returns>
        public bool Send(string message)
        {
            try
            {
                _mq.Send(message);
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
