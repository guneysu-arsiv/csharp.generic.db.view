using System;
using System.Windows.Forms;

namespace UI
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void viewDataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DBView_DataGrid();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DBView_ListView();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}