using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections;
using System.Net.Sockets;

namespace PortScanCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] iplist = GetIPList(args[0]);
            foreach (var ipaddress in iplist)
            {
                Console.WriteLine("==========================");
                Console.WriteLine("Scan: {0}", ipaddress);
                IPAddress ip;
                IPAddress.TryParse(ipaddress, out ip);
                Scan(ip, 1000, 6000);
                Console.WriteLine("==========================");
                Console.WriteLine();
            }
        }

        static string[] GetIPList(string iphead)
        {
            List<string> iplist = new List<string>();
            if (iphead != string.Empty)
                for (int i = 1; i <= 255; i++)
                    iplist.Add(string.Format("{0}.{1}", iphead, i));
            return iplist.ToArray();
        }

        /// <summary>
        /// 端口扫描
        /// </summary>
        /// <param name="ip">扫描的 IP地址</param>
        /// <param name="startPort">起始端口号</param>
        /// <param name="endPort">终止端口号</param>
        static void Scan(IPAddress ip, int startPort, int endPort)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            Console.WriteLine("Begin Scan...");
            for (int port = startPort; port < endPort; port++)
            {
                Socket scanSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                //寻找一个未使用的端口进行绑定
                do
                {
                    try
                    {
                        scanSocket.Bind(new IPEndPoint(IPAddress.Any, rand.Next(65535)));
                        break;
                    }
                    catch
                    {
                        //绑定失败
                    }
                } while (true);

                try
                {
                    scanSocket.BeginConnect(new IPEndPoint(ip, port), ScanCallBack, new ArrayList() { scanSocket, port });
                }
                catch
                {
                    // Console.WriteLine("port {0,5}\tClosed.\n{1}", port, ex.Message);
                    continue;
                }

            }

            Console.WriteLine("Port Scan Completed!");
        }

        /// <summary>
        /// BeginConnect的回调函数
        /// </summary>
        /// <param name="result">异步Connect的结果</param>
        static void ScanCallBack(IAsyncResult result)
        {
            //解析 回调函数输入 参数
            ArrayList arrList = (ArrayList)result.AsyncState;
            Socket scanSocket = (Socket)arrList[0];
            int port = (int)arrList[1];

            //判断端口是否开放
            if (result.IsCompleted && scanSocket.Connected && (port == 1433 || port == 3000))
                Console.WriteLine("port {0,5}\tOpen.", port);
            
            //关闭套接字
            scanSocket.Close();
        }
    }
}
