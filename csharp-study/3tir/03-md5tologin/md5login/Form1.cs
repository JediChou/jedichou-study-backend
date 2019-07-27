using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace md5login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click event
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region lab1 - only check login

            //var sql = "select count(1) from usersmd5 where loginId=@uid and loginPwd=@pwd";
            //var pms = new SqlParameter[]
            //{
            //    new SqlParameter("uid", txtUID.Text.Trim()),
            //    new SqlParameter("pwd", Security.GetStringMD5(txtPassword.Text))
            //};

            //int counter = (int) SqlHelper.ExecuteScalar(sql, CommandType.Text, pms);
            //MessageBox.Show(counter > 0 ? "Success!" : "Failed");

            #endregion

            #region lab 2 - check user does not exist and password is right (use two connection)

            //var sql_checkuser = "select count(1) from usersmd5 where loginId=@uid";
            //var sql_checkpass = "select count(1) from usersmd5 where loginId=@uid and loginPwd=@pwd";
            //var pms1 = new SqlParameter[] { new SqlParameter("uid", txtUID.Text.Trim()) };
            //var pms2 = new SqlParameter[] {
            //    new SqlParameter("uid", txtUID.Text.Trim()),
            //    new SqlParameter("pwd", Security.GetStringMD5(txtPassword.Text))
            //};

            //if ((int)SqlHelper.ExecuteScalar(sql_checkuser, CommandType.Text, pms1) > 0)
            //    if ((int)SqlHelper.ExecuteScalar(sql_checkpass, CommandType.Text, pms2) > 0)
            //        MessageBox.Show("Login succuess!");
            //    else
            //        MessageBox.Show("Password is wrong!");
            //else
            //    MessageBox.Show("user does not exits");

            #endregion

            #region lab 3 - check user and password (one connection)

            //var sql = "select AutoID, loginId, loginPwd from usersmd5 where loginId = @uid";
            //var pms = new SqlParameter[] { new SqlParameter("@uid", txtUID.Text.Trim()) };
            //var message = "";

            //using (var srd = SqlHelper.ExecuteReader(sql, CommandType.Text, pms))
            //{
            //    if (srd.HasRows)
            //    { 
            //        if (srd.Read())
            //            message = (srd.GetString(2) == Security.GetStringMD5(txtPassword.Text)) ? "Sucess!" : "Password is wrong!";
            //    }
            //    else
            //        message = "User does not exists!";
            //}

            //MessageBox.Show(message);

            #endregion

            #region lab 3 - check user and password (use zxh style, set some flag)

            //var sql = "select AutoID, loginId, loginPwd from usersmd5 where loginId = @uid";
            //var pms = new SqlParameter[] { new SqlParameter("@uid", txtUID.Text.Trim()) };
            //var login_name_exists = false;
            //var login_password_right = false;

            //using (var srd = SqlHelper.ExecuteReader(sql, CommandType.Text, pms))
            //{
            //    if (srd.HasRows)
            //    {
            //        login_name_exists = true;
            //        if (srd.Read())
            //        {
            //            login_password_right = (srd.GetString(2) == Security.GetStringMD5(txtPassword.Text)) ? true : false;
            //        }
            //    }
            //}

            //// Todo: 需要精化此代码
            //if (!login_name_exists) MessageBox.Show("User does not exists");
            //else if (!login_password_right) MessageBox.Show("Password wrong");
            //else MessageBox.Show("Login sucess!");

            #endregion

            #region lab 4 - add a lable and button for modify password

            var sql = "select AutoID, loginId, loginPwd from usersmd5 where loginId = @uid";
            var pms = new SqlParameter[] { new SqlParameter("@uid", txtUID.Text.Trim()) };
            var usernamedb = "";
            var login_name_exists = false;
            var login_password_right = false;

            using (var srd = SqlHelper.ExecuteReader(sql, CommandType.Text, pms))
            {
                if (srd.HasRows)
                {
                    login_name_exists = true;
                    if (srd.Read())
                    {
                        login_password_right = (srd.GetString(2) == Security.GetStringMD5(txtPassword.Text)) ? true : false;
                        usernamedb = srd.GetString(1);

                        // set global variable
                        GlobalHelper.CurrentAutoID = srd.GetInt32(0);
                        GlobalHelper.CurrentLoginID = srd.GetString(1);
                        GlobalHelper.CurrentLoginPWD = srd.GetString(2);
                    }
                }
            }

            if (!login_name_exists)
                MessageBox.Show("User does not exists");
            else if (!login_password_right)
                MessageBox.Show("Password wrong");
            else
            { 
                MessageBox.Show("Login sucess!");
                btnModify.Enabled = true;
                lblLoginMessage.Text = string.Format("Welcome to system, {0}", usernamedb);
            }

            #endregion

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var frmPassword = new frmModifyPassword();
            frmPassword.Show();
        }
    }
}
