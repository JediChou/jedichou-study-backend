using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace CFA
{
    /// <summary>
    /// 網絡服務接口
    /// </summary>
    interface NetService
    {
        bool CFAPing(string ip);
        bool CFAPort(string ip, int port);
    }
    
    /// <summary>
    /// 網絡監控的Net類
    /// </summary>
    public class Net : NetService
    {
        /// <summary>
        /// Ping一個主機
        /// </summary>
        /// <param name="ip">ip地址或主機名</param>
        /// <returns>是否能ping通</returns>
        public bool CFAPing(string ip)
        {
            try
            {
                var ping = new Ping();
                var reply = ping.Send(ip);
                return (reply.Status == IPStatus.Success) ? true : false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 確認IP的某個端口是否可用
        /// </summary>
        /// <param name="ip">ip地址或主機名</param>
        /// <param name="port">端口號</param>
        /// <returns>端口是否可用</returns>
        public bool CFAPort(string ip, int port)
        {
            try
            {
                var client = new TcpClient(ip, port);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
