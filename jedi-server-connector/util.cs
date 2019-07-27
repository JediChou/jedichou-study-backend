// <copyright file="util.cs" company="Foxconn-Business Corporation-iTEC">
//     Copyright (c) Foxconn-iTEC Group. All rights reserved.
// </copyright>
// <author>Jedi Chou</author>
namespace NetVerifyLibrary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.NetworkInformation;
    using System.Net.Sockets;
    using System.Text;

    /// <summary>
    /// Network Utility
    /// </summary>
    public partial class Util
    {
        /// <summary>
        /// If remote host is available the result is true,
        /// otherwise the result if false
        /// </summary>
        /// <param name="host">Remote host IP</param>
        /// <returns>Ping result</returns>
        public static PingReply TcpPing(string host)
        {
            // Define variables and set ping option
            var ip = host;
            var pingSender = new Ping();
            var pingOption = new PingOptions();
            var pingData = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            var buffer = Encoding.ASCII.GetBytes(pingData);
            var timeout = 120;
            pingOption.DontFragment = true;

            // execute and return result
            var replay = pingSender.Send(ip, timeout, buffer, pingOption);
            return replay;
        }

        /// <summary>
        /// Verify port of remote host is active.
        /// </summary>
        /// <param name="host">Remote host IP address</param>
        /// <param name="port">Ports of remote host</param>
        /// <returns>Remote port status</returns>
        public static bool CheckTcpPortConnect(string host, int port)
        {
            // Define a tcp client and connect host.
            // Function return false if get any exception, otherwise
            // connect success and return true.
            try
            {
                using (var tc = new TcpClient())
                {
                    // 1. Config send timeout and receive timeout.
                    // 2. Connect to host:port.
                    tc.SendTimeout = 5;
                    tc.ReceiveTimeout = 100;
                    tc.Connect(host, port);
                }

                return true;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Get IP list from file
        /// </summary>
        /// <param name="path">Path of IP list file</param>
        /// <returns>A array list for IP and list of port</returns>
        public static ArrayList GetIPListFromFile(string path)
        {
            var iplist = new ArrayList();

            using (var fs = new FileStream(path, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        // Get line
                        string stringLine = sr.ReadLine();

                        // Process line and add elements to ScanIP array list.
                        if (stringLine != string.Empty)
                        {
                            string ip = stringLine.Trim().Split(':')[0];
                            string portstr = stringLine.Trim().Split(':')[1].Trim();
                            string[] ports = portstr.Split(',');
                            iplist.Add(new ScanIP(ip, ports)); 
                        }
                    }
                }
            }

            return iplist;
        }
    }
}
