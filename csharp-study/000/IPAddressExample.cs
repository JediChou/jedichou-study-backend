using System;
using System.Net;
using System.Net.Sockets;

class IPAddressExample {
	
	static void PrintHostInfo(String host) {
		try {
			IPHostEntry hostInfo;

			// Attempt to resolve DNS for given host or address
			hostInfo = Dns.GetHostEntry(host);

			// Display the primary host name
			Console.WriteLine("Canonical Name: " + hostInfo.HostName);
			
			// Display list of IP addresses for this host
			Console.Write("IP Address:  ");
			foreach( IPAddress ipaddr in hostInfo.AddressList) {
				Console.Write(ipaddr.ToString() + " ");
			}
			Console.WriteLine();

			// Display list of alias names for this host
			Console.Write("Aliases:     ");
			foreach( String alias in hostInfo.Aliases) {
				Console.Write(alias + " ");
			}
			Console.WriteLine("\n");

		} catch (Exception) {
			Console.WriteLine("Unable to resolve host: " + host + "\n");
		}
	}

	static void Main(string[] args) {

		// Get and print local host information
		try {
			Console.WriteLine("Local Host:");
			String localHostName = Dns.GetHostName();
			Console.WriteLine("Host Name:     " + localHostName);
			PrintHostInfo(localHostName);
		} catch (Exception) {
			Console.WriteLine("Unable to resolve local host\n");
		}

		// Get and print info for hosts given on command line
		foreach(String arg in args) {
			Console.WriteLine(arg + ":");
			PrintHostInfo(arg);
		}
	}

	
}
