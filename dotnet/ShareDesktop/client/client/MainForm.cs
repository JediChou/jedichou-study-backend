
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Drawing.Imaging;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace client
{
    /// <summary>
    /// swpu
    /// </summary>
    public partial class MainForm : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public Point ptScreenPos;
        }

        private const Int32 CURSOR_SHOWING = 0x00000001;

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(out CURSORINFO pci);

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        Socket sendsocket;
        int interval = 42;

        private void Button1Click(object sender, EventArgs e)
        {
            try
            {
                sendsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //实例化socket
                IPEndPoint ipendpiont = new IPEndPoint(IPAddress.Parse(textBox1.Text.Trim()), 10001);
                sendsocket.Connect(ipendpiont);
                
                //建立终结点
                Thread th = new Thread(new ThreadStart(threadimage));
                th.IsBackground = true;
                th.Start();

                Thread thread = new Thread(new ThreadStart(threadState));
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
            this.Hide();
        }

        private void threadimage()
        {
            try
            {
                while (true)
                {

                    MemoryStream ms = new MemoryStream();
                    CompressImage(GetScreen(), ms);

                    byte[] b = Compress(ms.ToArray());
                    sendsocket.Send(b);
                    Thread.Sleep(interval);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
        }

        private void threadState()
        {
            try
            {
                while (true)
                {
                    byte[] b = new byte[10];
                    sendsocket.Receive(b);
                    if (b[0] == 1)
                    {
                        interval = 10000;
                    }
                    else if (b[0] == 2)
                    {
                        interval = 100;
                    }
                    Thread.Sleep(2000);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
        }

        private Bitmap GetScreen()
        {
            Bitmap bit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bit);
            g.CopyFromScreen(0, 0, 0, 0, bit.Size);

            try
            {
                CURSORINFO pci;
                pci.cbSize = Marshal.SizeOf(typeof(CURSORINFO));
                GetCursorInfo(out pci);
                System.Windows.Forms.Cursor cur = new System.Windows.Forms.Cursor(pci.hCursor);
                cur.Draw(g, new Rectangle(pci.ptScreenPos.X, pci.ptScreenPos.Y, cur.Size.Width, cur.Size.Height));
            }
            catch
            {
            }
  
            return bit;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        public void CompressImage(Bitmap bitmap, MemoryStream ms,int high)
        {
            try
            {
                bitmap.Save(ms,ImageFormat.Jpeg);  
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 压缩图片
        /// </summary>
        /// <param name="bitmap">原图片</param>
        /// <param name="ms">内存流</param>
        public void CompressImage(Bitmap bitmap, MemoryStream ms)
        { 
            ImageCodecInfo ici = null;
            Encoder ecd = null; 
            EncoderParameter ept = null; 
            EncoderParameters eptS = null;
            try
            {
                ici = this.getImageCoderInfo("image/jpeg");
                ecd = Encoder.Quality;
                eptS = new EncoderParameters(1);
                ept = new EncoderParameter(ecd, 50L);
                eptS.Param[0] = ept;
                bitmap.Save(ms, ici, eptS);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                ept.Dispose();
                eptS.Dispose();
            }
        }

        /// <summary>  
        /// 获取图片编码信息  
        /// </summary>  
        /// <param name="coderType">编码类型</param>  
        /// <returns>ImageCodecInfo</returns>  
        private ImageCodecInfo getImageCoderInfo(string coderType)
        {
            ImageCodecInfo[] iciS = ImageCodecInfo.GetImageEncoders();

            ImageCodecInfo retIci = null;

            foreach (ImageCodecInfo ici in iciS)
            {
                if (ici.MimeType.Equals(coderType))
                    retIci = ici;
            }
            return retIci;
        }

        /// <summary>
        /// 压缩流
        /// </summary>
        /// <param name="sourceStream"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                GZipStream Compress = new GZipStream(ms, CompressionMode.Compress);

                Compress.Write(bytes, 0, bytes.Length);

                Compress.Close();

                return ms.ToArray();
            }
        }
    }
}
