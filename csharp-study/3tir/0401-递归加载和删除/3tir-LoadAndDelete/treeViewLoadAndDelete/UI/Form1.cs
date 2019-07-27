using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using treeViewLoadAndDelete.Model;
using treeViewLoadAndDelete.BLL;

namespace treeViewLoadAndDelete
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAreaToTree(0, treeView1.Nodes);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check current selection
            if (this.treeView1.SelectedNode != null)
            {
                // call bll's operate to delete record from database
                int areaid = (int)treeView1.SelectedNode.Tag;
                TblAreaBLL bll = new TblAreaBLL();
                bll.RecuseDelete(areaid);

                // delte node on the form
                treeView1.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Without anything selected.");
            }
        }

        private void LoadAreaToTree(int pid, TreeNodeCollection nodes)
        {
            var bll = new TblAreaBLL();

            // First, query data by pid
            List<TblArea> list = bll.GetAreaByAreaPid(pid);

            // second, bind data to nodes collection.
            foreach (var model in list)
            {
                TreeNode tnode = nodes.Add(model.AreaName);
                tnode.Tag = model.AreaId;
                LoadAreaToTree(model.AreaId, tnode.Nodes);
            }
        }
    }
}
