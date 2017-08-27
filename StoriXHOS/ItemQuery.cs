using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriXHOS
{
    public partial class ItemQuery : Form
    {
        public ItemQuery()
        {
            InitializeComponent();
            StoreTypeGrid.Rows.Add(true, "2001", "מגשימים");
            StoreTypeGrid.Rows.Add(true, "2002", "רמלה");

            StoresSelectedGrid.Rows.Add(true, "2001", "מגשימים", false);

            StoreResultGrid.Rows.Add("2001", "מגשימים");



            ItemsTypeGrid.Rows.Add(true, "35", "משקאות קרים");
            ItemsTypeGrid.Rows.Add(false, "36", "משקאות כללי");

            ItemsSeelctedGrid.Rows.Add(true, "1001", "משקאות קרים", false);
            ItemsSeelctedGrid.Rows.Add(true, "511", "תנובה", false);

            ItemsResultGrid.Rows.Add("345", "קולה");
            ItemsResultGrid.Rows.Add("346", "םפרייט");
            ItemsResultGrid.Rows.Add("345", "חלב");
            ItemsResultGrid.Rows.Add("345", "גבינה 5%");

            QueryResultGrid.Rows.Add("חלב", "מקרר", "תנובה", "23-05-2014");
        }
    }
}
