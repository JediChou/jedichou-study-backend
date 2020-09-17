namespace ThreadDemo01
{
    partial class ASyncFrm
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnASync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(27, 40);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "同步调用";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnASync
            // 
            this.btnASync.Location = new System.Drawing.Point(27, 79);
            this.btnASync.Name = "btnASync";
            this.btnASync.Size = new System.Drawing.Size(75, 23);
            this.btnASync.TabIndex = 1;
            this.btnASync.Text = "异步调用";
            this.btnASync.UseVisualStyleBackColor = true;
            this.btnASync.Click += new System.EventHandler(this.btnASync_Click);
            // 
            // ASyncFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 150);
            this.Controls.Add(this.btnASync);
            this.Controls.Add(this.btnSync);
            this.Name = "ASyncFrm";
            this.Text = "ASyncFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnASync;
    }
}