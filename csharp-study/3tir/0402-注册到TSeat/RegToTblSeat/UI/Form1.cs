using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegToTblSeat.Model;
using RegToTblSeat.BLL;

namespace RegToTblSeat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnRegisted_Click(object sender, EventArgs e)
        {
            // check password
            if (
                txtLoginID.Text.Trim() != "" && 
                txtPassword.Text != "" && 
                txtUsername.Text.Trim() != "" &&
                txtConfirm.Text != "" && 
                txtPassword.Text == txtConfirm.Text
            )
            {
                // collected data
                var tseat = new TSeat();
                tseat.LoginId = txtLoginID.Text.Trim();
                tseat.LoginPassword = txtPassword.Text;
                tseat.UserName = txtUsername.Text.Trim();

                // call bll to exectute operate
                var bll = new TblSeatBLL();
                MessageBox.Show(bll.RegUser(tseat) > 0 ? "Regist sucess!" : "Regist fail!");
            }
            else
            {
                MessageBox.Show("Password is not right, or password is null!");
            }
        }
    }
}
