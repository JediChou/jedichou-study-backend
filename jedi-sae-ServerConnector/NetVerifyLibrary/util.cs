namespace NetVerifyLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Net;
    using System.Net.NetworkInformation;
    using System.Net.Sockets;

    /// <summary>
    /// Network util
    /// </summary>
    public partial class util
    {
        /// <summary>
        /// If remote host is available the result is true,
        /// otherwise the result if false
        /// </summary>
        /// <param name="host">Remote host IP</param>
        /// <returns>Ping result</returns>
        public static Boolean TcpPing(string host)
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
            return (replay.Status == IPStatus.Success) ? true : false;
        }

        /// <summary>
        /// Verify port of remote host is active.
        /// </summary>
        /// <param name="host">remote host ip address</param>
        /// <param name="port">remote host port</param>
        /// <returns>port status</returns>
        public static Boolean CheckTcpPortConnect(string host, int port)
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
            catch (Exception) { return false; }
        }

    }
}
