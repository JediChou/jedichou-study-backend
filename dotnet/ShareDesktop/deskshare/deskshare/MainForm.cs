
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.IO.Compression;

namespace deskshare
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
		}
        Socket hostSocket;
        Thread thread;
        private void Button1Click(object sender, EventArgs e)
        {
            Socket receiveSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint hostIpEndPoint = new IPEndPoint(IPAddress.Parse(textBox1.Text.Trim()), 10001);
            //关联结点
            receiveSocket.Bind(hostIpEndPoint);
            receiveSocket.Listen(10);
            MessageBox.Show("start");
            hostSocket = receiveSocket.Accept();

            thread = new Thread(new ThreadStart(trreadimage));
            thread.IsBackground = true;
            thread.Start();
        }
      
        private void trreadimage()
        {
            try
            { 
                while (true)
                {
                    int len = 0;
                    byte[] b = new byte[1024 * 500];
                    len = hostSocket.Receive(b);
                    //byte[] bb=new byte[len];
   
                    //Array.Copy(b, 0, bb, 0, len);
                    byte[] arr = Decompress(b,len);
                    if (arr == null)
                        continue;
                    MemoryStream ms = new MemoryStream(arr);
                    Image img;
                    if (getImage(ms, out img))
                    {
                        picReceive.Image = img;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                thread.Abort();
            }
        }

        private bool getImage(MemoryStream ms,out Image image)
        {
            try
            {
                image = Image.FromStream(ms);
                return true;
            }
            catch
            {
                image = null;
                return false;
            }
        }

        /// <summary>
        /// 解压缩流
        /// </summary>
        /// <param name="sourceStream"></param>
        /// <returns></returns>
        public byte[] Decompress(Byte[] bytes,int len)
        {
            try
            {
                using (MemoryStream tempMs = new MemoryStream())
                {
                    using (MemoryStream ms = new MemoryStream(bytes,0,len))
                    {
                        GZipStream Decompress = new GZipStream(ms, CompressionMode.Decompress);
                        Decompress.CopyTo(tempMs);
                        Decompress.Close();
                        return tempMs.ToArray();
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hostSocket.Send(new byte[] { 2, 2, 2 });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            hostSocket.Send(new byte[] { 1, 1, 1 });
        }
	}
}
