namespace md5login
{
    partial class frmModifyPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword1 = new System.Windows.Forms.Label();
            this.lblNewPassword2 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(16, 56);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(68, 12);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Old Password";
            // 
            // lblNewPassword1
            // 
            this.lblNewPassword1.AutoSize = true;
            this.lblNewPassword1.Location = new System.Drawing.Point(12, 87);
            this.lblNewPassword1.Name = "lblNewPassword1";
            this.lblNewPassword1.Size = new System.Drawing.Size(72, 12);
            this.lblNewPassword1.TabIndex = 1;
            this.lblNewPassword1.Text = "New Password";
            // 
            // lblNewPassword2
            // 
            this.lblNewPassword2.AutoSize = true;
            this.lblNewPassword2.Location = new System.Drawing.Point(23, 116);
            this.lblNewPassword2.Name = "lblNewPassword2";
            this.lblNewPassword2.Size = new System.Drawing.Size(61, 12);
            this.lblNewPassword2.TabIndex = 2;
            this.lblNewPassword2.Text = "Again Input";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(90, 46);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(182, 22);
            this.txtOldPassword.TabIndex = 3;
            // 
            // txtNewPasword
            // 
            this.txtNewPasword.Location = new System.Drawing.Point(90, 77);
            this.txtNewPasword.Name = "txtNewPasword";
            this.txtNewPasword.Size = new System.Drawing.Size(182, 22);
            this.txtNewPasword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(90, 106);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(182, 22);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(90, 144);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(182, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify Password";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // frmModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPasword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblNewPassword2);
            this.Controls.Add(this.lblNewPassword1);
            this.Controls.Add(this.lblOldPassword);
            this.Name = "frmModifyPassword";
            this.Text = "frmModifyPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword1;
        private System.Windows.Forms.Label lblNewPassword2;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPasword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnModify;
    }
}