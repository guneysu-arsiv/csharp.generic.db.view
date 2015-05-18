using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericDBView;


namespace UI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            var dbs = DB.GetDBList();
            //cmbDbList.DataSource = dbs;

            ToolStripMenuItem MenuDBList = new ToolStripMenuItem("DB List");

            foreach (var db in dbs)
            {
                var sub = new ToolStripMenuItem(
                    db, null,
                    new EventHandler((O, E) =>
                    {
                        
                    }));

                var tableList = DB.GetTableList(db);
                foreach (var table in tableList)
                {
                    sub.DropDownItems.Add(
                        table, null,
                        new EventHandler( (O, E) => { ListTable(db, table); })
                        );
                }
                MenuDBList.DropDownItems.Add(sub);

            }

            menuStrip1.Items.Add(MenuDBList);
        }

        private void ListTable(string db, string table)
        {
            dataGridView1.DataSource = DB.GetTable(tableName: table, dbName: db);
        }
    }
}
