// <copyright file="ScanIP.cs" company="Foxconn-Business Corporation-iTEC">
//     Copyright (c) Foxconn-iTEC Group. All rights reserved.
// </copyright>
// <author>Jedi Chou</author>

namespace NetVerifyLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Custom ScanIP object
    /// </summary>
    public class ScanIP
    {
        /// <summary>
        /// Save IP information
        /// </summary>
        private string ip;

        /// <summary>
        /// Save ports information for a special IP
        /// </summary>
        private string[] port;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanIP"/> class.
        /// </summary>
        /// <param name="ip">IP address of remote server</param>
        /// <param name="port">Port of remote server</param>
        public ScanIP(string ip, string[] port)
        {
            this.ip = ip;
            this.port = port;
        }

        /// <summary>
        /// Get ScanIP instance's IP address
        /// </summary>
        /// <returns>IP address</returns>
        public string GetIPAddress()
        {
            return this.ip;
        }

        /// <summary>
        /// Get ports information from ScanIP instance
        /// </summary>
        /// <returns>Port list of ScanIP instance</returns>
        public string[] GetPort()
        {
            return this.port;
        }
    }
}
