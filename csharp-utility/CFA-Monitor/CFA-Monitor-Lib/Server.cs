using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFA
{
    public class Host
    {
        /// <summary>
        /// 所有Host共用的掃描器
        /// </summary>
        public static CFA.Net Scanner = new CFA.Net();

        /// <summary>
        /// IP地址或機器名
        /// </summary>
        public string IP { get; set; }
        
        /// <summary>
        /// IP地址開放的端口列表
        /// </summary>
        public List<int> Ports { get; set; }

        /// <summary>
        /// 缺省構造函數
        /// </summary>
        public Host() {}

        /// <summary>
        /// 構造函數
        /// </summary>
        /// <param name="ip">IP地址或機器名</param>
        public Host(string ip)
        {
            IP = ip;
        }

        /// <summary>
        /// 構造函數
        /// </summary>
        /// <param name="ip">IP地址或機器名</param>
        /// <param name="ports">端口號</param>
        public Host(string ip, List<int> ports)
        {
            IP = ip;
            Ports = ports;
        }

        /// <summary>
        /// Ping主機(三次不通則返回false)
        /// </summary>
        /// <returns>Ping結果</returns>
        public bool PingHost()
        {
            return IP.Equals(string.Empty) ? false : Scanner.CFAPing(IP) || Scanner.CFAPing(IP) || Scanner.CFAPing(IP) ? true : false;
        }

        /// <summary>
        /// Ping端口（只連接一次）
        /// </summary>
        /// <returns>端口連接結果</returns>
        public Dictionary<int, bool> PingPort()
        {
            var result = new Dictionary<int, bool>();
            if (Ports.Count != 0)
                foreach (var port in Ports)
                    result.Add(port, Scanner.CFAPort(IP, port));
            else
                return null;
            return result;
        }
    }
}
