using System;
using System.Windows.Forms;
using GenericDBView;

namespace UI
{
    public partial class DBView_ListView : Form
    {
        public DBView_ListView()
        {
            InitializeComponent();
        }

        private void DBView_ListView_Load(object sender, EventArgs e)
        {
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
            //listView1.DataSource = DB.GetTable(tableName: table, dbName: db);
            var dt = DB.GetTable(table, db);
            dt.ToListView(listView1);
        }
    }
}