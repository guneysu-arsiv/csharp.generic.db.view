using System;
using System.Windows.Forms;
using GenericDBView;

namespace UI
{
    public partial class DBView_DataGrid : Form
    {
        public DBView_DataGrid()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            new DBView_ListView().Show();
            var dbs = DB.GetDBList();
            //cmbDbList.DataSource = dbs;

            var MenuDBList = new ToolStripMenuItem("DB List");

            foreach (var db in dbs)
            {
                var sub = new ToolStripMenuItem(
                    db, null,
                    (O, E) => { });

                var tableList = DB.GetTableList(db);
                foreach (var table in tableList)
                {
                    sub.DropDownItems.Add(
                        table, null,
                        (O, E) => { ListTable(db, table); }
                        );
                }
                MenuDBList.DropDownItems.Add(sub);
            }

            menuStrip1.Items.Add(MenuDBList);
        }

        private void ListTable(string db, string table)
        {
            dataGridView1.DataSource = DB.GetTable(table, db);
        }
    }
}