using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadDemo01
{
    public partial class ASyncFrm : Form
    {
        public ASyncFrm()
        {
            InitializeComponent();
            Console.WriteLine("*********** ThreadDemo01  ***********");
            Console.WriteLine("Current thread id: {0}", Thread.CurrentThread.ManagedThreadId);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Action<string> action = PostMessageToConsole;
            Console.WriteLine("\nbtnSync click event...");
            for (int i=0; i < 5; i++)
            {
                var name = $"btnSync -> {Thread.CurrentThread.ManagedThreadId}";
                action.Invoke(name);
            }
        }

        private void btnASync_Click(object sender, EventArgs e)
        {
            Action<string> action = PostMessageToConsole;
            Console.WriteLine("\nbtnASync click event...");

            for (int i = 0; i < 5; i++)
            {
                string name = $"btnASync -> {Thread.CurrentThread.ManagedThreadId}";
                action.BeginInvoke(name, null, null);
            }
        }

        /// <summary>
        /// Post message to console
        /// </summary>
        /// <param name="msg">message</param>
        private static void PostMessageToConsole(string msg)
        {
            // 消耗时间
            int j = 0, k = 999999999, m = 0;
            for (j = 0; j < k; j++)
                m = j + k;
            Console.Write(Thread.CurrentThread.ManagedThreadId + " ");
            Console.WriteLine($"From PostMessageToConsole: {msg}");
        }
    }
}
