using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GenericDBView
{
    public static partial class DB
    {
        public static void ToListViewColumns(this DataTable dt, ListView listview)
        {
            var cols = dt.Columns; //.Cast<string>().ToList();
            listview.Columns.Clear();
            foreach (DataColumn col in cols)
            {
                listview.Columns.Add(col.ToString());
            }
        }

        public static void ToListView(this DataTable dt, ListView listview)
        {
            dt.ToListViewColumns(listview);
            var columns = dt.GetColumns();
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listview.Items.Clear();

            var odd = false;
            foreach (DataRow row in dt.Rows)
            {
                var item = new ListViewItem(row[columns[0]].ToString());
                if (odd)
                {
                    item.BackColor = Color.DarkSeaGreen;
                }
                for (var i = 1; i < columns.Count - 1; i++)
                {
                    item.SubItems.Add(row[columns[i]].ToString());
                }
                listview.Items.Add(item);
                odd = !odd;
            }
        }

        public static List<string> GetColumns(this DataTable dt)
        {
            return dt.Columns.Cast<DataColumn>()
                .Select(x => x.ColumnName)
                .ToList();
        }
    }
}