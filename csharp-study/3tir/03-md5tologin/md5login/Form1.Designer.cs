namespace md5login
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLoginMessage = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(78, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(163, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Location = new System.Drawing.Point(47, 61);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(25, 12);
            this.lblUID.TabIndex = 1;
            this.lblUID.Text = "UID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 96);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 12);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(78, 61);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(163, 22);
            this.txtUID.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(78, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(163, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // lblLoginMessage
            // 
            this.lblLoginMessage.AutoSize = true;
            this.lblLoginMessage.Location = new System.Drawing.Point(76, 199);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Size = new System.Drawing.Size(83, 12);
            this.lblLoginMessage.TabIndex = 5;
            this.lblLoginMessage.Text = "Welcome guest !";
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(78, 225);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(163, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblLoginMessage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLoginMessage;
        private System.Windows.Forms.Button btnModify;
    }
}

