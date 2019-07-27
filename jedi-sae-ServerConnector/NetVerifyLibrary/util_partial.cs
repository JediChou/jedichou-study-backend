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
        public static string[] PortInfo_en = {
            // Reference http://en.wikipedia.org/wiki/List_of_TCP_and_UDP_port_numbers
            // Format Port:Protocol:Introduction
            
            "0:UDP:Reserved",
            "1:TCP,UDP:TCP Port Service Multiplexer (TCPMUX)",
            "2:TCP,UDP:CompressNET Management Utility",
            "3:TCP,UDP:CompressNET Compression Process",
            "4:TCP,UDP:Unassigned",

            "5:TCP,UDP:Remote Job Entry",
            "6:TCP,UDP:Unassigned",
            "7:TCP,UDP:Echo Protocol,Ping,ICMP",
            "8:TCP,UDP:Unassigned Official",
            "9:TCP,UDP:Discard Protocol",
            
            "10:TCP,UDP:Unassigned",
            "11:TCP,UDP:Active Users (systat service)",
            "12:TCP,UDP:Unassigned Official",
            "13:TCP,UDP:Daytime Protocol (RFC 867)",
            "14:TCP,UDP:Unassigned",

            "15:TCP,UDP:Unassigned",
            "16:TCP,UDP:Unassigned",
            "17:TCP,UDP:Quote of the Day",
            "18:TCP,UDP:Message Send Protocol",
            "19:TCP,UDP:Character Generator Protocol (CHARGEN)", 

            "20:TCP,UDP:FTP data transfer",
            "21:TCP:FTP control (command)",
            "22:TCP,UDP:Secure Shell (SSH)—used for secure logins, file transfers (scp, sftp) and port forwarding",
            "23:TCP,UDP:Telnet protocol—unencrypted text communications",
            "24:TCP,UDP:Priv-mail : any private mail system",

            "20:TCP,UDP:FTP data transfer",
        };    

    }
}
