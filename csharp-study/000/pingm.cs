using System.Net;
using System.Net.Sockets;
using System;

namespace Pingm
{
	/// <SubCode>
	/// Use C# sokect to simulate a ping program.
	/// Reference URL: http://cache.baiducontent.com/c?m=9d78d513d99256af59fa940f4f4d8b330e55f0744cd1c7610cc3e24884132b550026bdb47d645646c4c40f7a1cff1701bfe7360576587ce48cc8ff1b80e4852858d97b293101d61f4f860ea8bf4075c0269351baaf1be4b8f26296ea8ac4df23098c0c5b&p=9d3dcd5e86cc41ae53b8c7710f408e&newp=98769a47cd934eaf59e6cb341e4f96231610db2151d1d01e64&user=baidu&fm=sc&query=c%23+ping%B4%FA%C2%EB&qid=&p1=5
	/// </summary>
	class Program
	{
		
		/// <summary>
		/// Implement a ICMP package
		/// </summary>
		public class IcmpPacket
		{
			public Byte Type;
			public Byte SubCode;
			public UInt16 CheckSum;
			public UInt16 Identifier;
			public UInt16 SequenceNumber;
			public Byte[] Data;
		}
		
		const int SOCKET_ERROR = -1;
		const int ICMP_ECHO = 8;
		
		/// <summary>
		/// Implement ping program
		/// </summary>
		public static void PingHost(string host)
		{
			// Define variables to storage localhost informations.
			IPHostEntry dstHost, srcHost;
			int nBytes = 0;
			int dwStart = 0, dwStop = 0, elapseTime = 0;
			int icmpFailureNum = 0;

			// Initialize socket
			Socket socket = null;
			try	{
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
			} catch (SocketException e) {
				System.Diagnostics.Debug.WriteLine(e.Message);
			}

			// Configure timeout variable
			socket.ReceiveTimeout = 1000;
			try {
				dstHost = Dns.GetHostEntry(host);
			} catch (Exception e) {
				System.Diagnostics.Debug.WriteLine(e.Message);
			}

			IPEndPoint ipepServer = new IPEndPoint(dstHost.AddressList[0], 0);
			EndPoint epServer = (ipepServer);
			srcHost = Dns.GetHostEntry(Dns.GetHostName());
			IPEndPoint ipEndPointFrom = new IPEndPoint(srcHost.AddressList[0], 0);
			EndPoint EndPointFrom = (ipEndPointFrom);
			int PacketSize = 0;
			IcmpPacket packet = new IcmpPacket();

			// configure ICMP information
			packet.Type = ICMP_ECHO;
			packet.SubCode = 0;
			packet.CheckSum = UInt16.Parse("0");
			packet.Identifier = UInt16.Parse("45");
			packet.SequenceNumber = UInt16.Parse("0");
			int PingData = 32;
			packet.Data = new byte[PingData];
			
			// initialize ICMP package
			for( int i = 0; i < PingData; i++)
			{
				packet.Data[i] = (byte)'#';
			}
			PacketSize = PingData + 8;
			Byte[] imcp_pkt_buffer = new Byte[PacketSize];
			Int32 Index = 0;

			// calculate ICMP package size
			Index = Serialize(packet, imcp_pkt_buffer, PacketSize, PingData);

			// error report
			if(Index == -1)
			{
				Console.WriteLine("Error in making Packet");
				return;
			}

			// TODO: continue at here.

		}

		/// <summary>
		/// Function checksum
		/// </summary>
		public static UInt16 checksum(UInt16[] buffer, int size)
		{
			Int32 cksum = 0;
			int counter = 0;

			while (size > 0)
			{
				UInt16 val = buffer[counter];
				cksum += Convert.ToInt32(buffer[counter]);
				counter += 1;
				size -= 1;
			}

			cksum = (cksum >> 16) + (cksum & 0xffff);
			cksum += (cksum >> 16);

			return (UInt16)(~cksum);
		}
			
		/// <summary>
		/// Function serialize
		/// </summary>
		public static Int32 Serialize(IcmpPacket packet, Byte[] Buffer, Int32 PacketSize, Int32 PingData)
		{
			Int32 cbReturn = 0;
			int Index = 0;
			Byte[] b_type = new Byte[1];
			b_type[0] = (packet.Type);
			Byte[] b_code = new Byte[1];
			b_code[0] = (packet.SubCode);
			Byte[] b_cksum = BitConverter.GetBytes(packet.CheckSum);
			Byte[] b_id = BitConverter.GetBytes(packet.Identifier);
			Byte[] b_seq = BitConverter.GetBytes(packet.SequenceNumber);

			Array.Copy(b_type, 0, Buffer, Index, b_type.Length);
			Index += b_type.Length;
			Array.Copy(b_code, 0, Buffer, Index, b_code.Length);
			Index += b_code.Length;
			Array.Copy(b_cksum, 0, Buffer, Index, b_cksum.Length);
			Index += b_cksum.Length;
			Array.Copy(b_id, 0, Buffer, Index, b_id.Length);
			Index += b_id.Length;
			Array.Copy(b_seq, 0, Buffer, Index, b_seq.Length);
			Index += b_seq.Length;

			// Copy datas
			Array.Copy(packet.Data, 0, Buffer, Index, PingData);
			Index += PingData;
			if ( Index != PacketSize )
			{
				cbReturn = -1;
				return cbReturn;
			}
			cbReturn = Index;
			
			return cbReturn;
		}

		/// <summary>
		/// Program entrance
		/// </summary>
		/// <param name="argv">Program Paramter</param>
		[STAThread]
		public static void Main(string[] argv)
		{
			Console.WriteLine("This is a test");
			Console.ReadLine();
		}

	}
}
