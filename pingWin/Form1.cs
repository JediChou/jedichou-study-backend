using System;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Threading;

namespace pingWin
{
    public partial class Form1 : Form
    {
        int maxLength=0;
        static string sql;
        static int count = 0;
        static int listNum = 0;
        List<string> sqls;
        static string sqliteDB = "E:\\workspace 201603\\CFA-Monitor-0.01\\bin\\ping-db.db";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private delegate void SetTextBoxValue(string value);
        private void writePingResult(string IP)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextBoxValue objSetTextBoxValue = new SetTextBoxValue(writePingResult);
                IAsyncResult result = this.textBox1.BeginInvoke(objSetTextBoxValue, new object[] { IP });
            }
            else
            {
                this.textBox1.Text += DateTime.Now.ToString() +"\t"+IP + Environment.NewLine;
                this.textBox1.SelectionStart = this.textBox1.TextLength;
                this.textBox1.ScrollToCaret();
            }

        }
        private void pingIP(object obj)
        {

            string IP = obj.ToString();
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "CFA Jedi.Chou";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 2000;
            PingReply reply = null;
            for (int i = 1; i <= 3; i++)
            {
                reply = pingSender.Send(IP, timeout, buffer, options);
                
                if (reply.Status == IPStatus.Success)
                {
                    //InsertPingResult(DateTime.Now.ToString(), IP, "OK");
                   lock (this)
                   {
                       count++;
                       //sql+="";
                       sql += "(\"";
                       sql += DateTime.Now.ToString();
                       sql+="\",\"";
                       sql += IP;
                       sql+="\",\"";
                       sql+="true";
                       sql+="\"),";
                       if (count % 100 == 0 || maxLength == count)
                       {
                           insertPingResults(sql);//insert();
                           sql = "";
                       }
                       //writePingResult(IP + "\ttrue"); 
                       break;
                    }
                    
                }
                else
                {
                    if (i == 3 )
                        lock (this)
                        {
                            count++;
                            //sql+="";
                            sql += "(\"";
                            sql += DateTime.Now.ToString();
                            sql += "\",\"";
                            sql += IP;
                            sql += "\",\"";
                            sql += "false";
                            sql += "\"),";
                            if (count % 100 == 0 || maxLength == count)
                            {
                                insertPingResults(sql);//insert();
                                sql = "";
                            }
                    }
                    //InsertPingResult(DateTime.Now.ToString(), IP, "FALSE");
                   // writePingResult(IP + "\tfalse");
                }

            }
        }
        private bool insertPingResults(string sql)
        {
            try
            {
                sql = string.Format("INSERT INTO PingResult VALUES") + sql;
                sql = sql.Remove(sql.LastIndexOf(","), 1);
                using (var conn = new SQLiteConnection("Data Source=" + sqliteDB))
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private delegate void pingIPDelegate(object obj);
        private void pingIPCompele(IAsyncResult ar)
        {
            if (ar == null)
            {
                return;
            }
            
        }
        private bool CheckDB()
        {
            if (File.Exists(sqliteDB))
            {
                try
                {
                    using (var conn = new SQLiteConnection("Data Source=" + sqliteDB))
                        conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private bool CreateDB()
        {
            try
            {
                var sql = "CREATE TABLE IF NOT EXISTS PingResult(pingDate varchar(50),ip varchar(50), ping varchar(50))";
                using (var conn = new SQLiteConnection("Data Source=" + sqliteDB))
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        static bool InsertPingResult(string pingDate,string ip, string result)
        {
            try
            {
                var sql = string.Format("INSERT INTO PingResult VALUES ('{0}', '{1}','{2}')", pingDate, ip, result);
                using (var conn = new SQLiteConnection("Data Source=" + sqliteDB))
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void queryDB()
        {
            var sql = "SELECT * FROM PingResult";
            try
            {
                using (var conn = new SQLiteConnection("Data Source=" + sqliteDB))
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) { 
                        string a=reader["ip"] + "\t" + reader["ping"]; }
                    //    Console.WriteLine(reader["ip"] + "\t" + reader["ping"]);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckDB()) CreateDB();
            ThreadPool.SetMinThreads(1000, 1000);    // Refer to Chapter 21
            ThreadPool.SetMaxThreads(1000, 1000);    // Refer to Chapter 21
            string num1 = "10.134.154.";
            string num2 = "10.134.156.";
            string num3 = "10.134.158.";

            for (int i = 1; i <= 255; i++)
            {
                maxLength+=3;
                ThreadPool.QueueUserWorkItem(pingIP, num1 + i);
                ThreadPool.QueueUserWorkItem(pingIP, num2 + i);
                ThreadPool.QueueUserWorkItem(pingIP, num3 + i);
               // pingIPDelegate p = pingIP;
                //p.BeginInvoke(num1 + i, pingIPCompele, p);
                // p.BeginInvoke(num2 + i, pingIPCompele, p);
                // p.BeginInvoke(num3 + i, pingIPCompele, p);
            }
            




            //string path = "E:\\workspace 201603\\CFA-Monitor-0.01\\bin\\ping-host.txt";
            //StreamReader sr = new StreamReader(path, Encoding.Default);
            //String line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    //ThreadPool.QueueUserWorkItem(pingIP, line.ToString());
            //   pingIPDelegate p = pingIP;
            //   p.BeginInvoke(line.ToString(), pingIPCompele, p);
            //    //Thread t = new Thread(new ParameterizedThreadStart(pingIP));
            //    //t.Start(line.ToString());
            //    //pingIP(line.ToString());
            //}

            //for (int i = 1; i <= 3; i++)
            //{

            //    ThreadPool.QueueUserWorkItem(WaitCallBackMethod, i);

            //}

        }
    }
}
