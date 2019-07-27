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
    public partial class frmModifyPassword : Form
    {
        public frmModifyPassword()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            #region lab 5 - jedi's normal thinking

            // step 1: check new password and confirm password
            // step 2: check old password
            // step 3: update database and pop message

            if (txtNewPasword.Text == txtConfirmPassword.Text)
            { 
                if (CheckPassword(txtOldPassword.Text, GlobalHelper.CurrentAutoID))
                { 
                    if (ModifyPassword(txtNewPasword.Text, GlobalHelper.CurrentAutoID))
                    { 
                        MessageBox.Show("Modify Sucess!");
                        this.Close();
                    }
                    else
                    { 
                        MessageBox.Show("Modify Failed!");
                    }
                }
                else
                { 
                    MessageBox.Show("Old password wrong!");
                }
            }
            else
            { 
                MessageBox.Show("Password confirm failed");
            }

            #endregion
        }

        /// <summary>
        /// Modify current password
        /// </summary>
        /// <param name="txtNewPasword1"></param>
        /// <param name="currentAutoID"></param>
        /// <returns>Modify result</returns>
        private bool ModifyPassword(string password, int currentAutoID)
        {
            var sql = "update usersmd5 set loginPwd = @NewPassword where AutoID = @AutoID";
            var pms = new SqlParameter[]
            {
                new SqlParameter("@NewPassword", Security.GetStringMD5(password)),
                new SqlParameter("@AutoID", currentAutoID),
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms) > 0;
        }

        /// <summary>
        /// Check old password is right
        /// </summary>
        /// <param name="oldpassword"></param>
        /// <param name="currentAutoID"></param>
        /// <returns>Check result</returns>
        private bool CheckPassword(string oldpassword, int currentAutoID)
        {
            var sql = "select count(1) from usersmd5 where AutoID = @AutoId and loginPwd = @OldPassword";
            var pms = new SqlParameter[] 
            {
                new SqlParameter("@AutoId", currentAutoID),
                new SqlParameter("@OldPassword", Security.GetStringMD5(oldpassword))
            };
            return (int) SqlHelper.ExecuteScalar(sql, CommandType.Text, pms) > 0;
        }
    }
}
