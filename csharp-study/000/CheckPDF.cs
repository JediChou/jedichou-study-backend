using System;
using System.Text;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Threading;

namespace CheckPdf
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
                textSelectFile.Text = fileDialog.FileName;
        }

        private void btnCheckPDF_Click(object sender, EventArgs e)
        {
            var filename = this.textSelectFile.Text;
            var message = File.Exists(filename) ?
                IsValidPdf(filename) ?
                    "This is a PDF file" : 
                    "God, is not a PDF file" :
                "File does not exists!";
            MessageBox.Show(message);
        }

        private bool IsValidPdf(string filename)
        {
           try
           {
              new iTextSharp.text.pdf.PdfReader(filename);
              return true;
           }
           catch
           {
              return false;
           }
        }
    }
}
