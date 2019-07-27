using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUID.Text.Trim();
            var password = txtPassword.Text;
            var result = new BLL.TBLUserBLL().CheckPassword(user, password);
            MessageBox.Show(result ? "Login Success" : "Login failed");
        }
    }
}
