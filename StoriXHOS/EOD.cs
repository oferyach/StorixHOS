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
    public partial class EOD : Form
    {
        public EOD()
        {
            InitializeComponent();
        }

        private void EOD_ParentChanged(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
