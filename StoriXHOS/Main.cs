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
    public partial class StoriXMain : Form
    {
        public StoriXMain()
        {
            InitializeComponent();
        }

        private void LeftMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "EOD")
            {
                TabPage myTabPage = new TabPage("סוף יום");
                EOD myUserControl = new EOD();
                myUserControl.TopLevel = false;
                //myUserControl.Dock = DockStyle.Fill;             
                myUserControl.Show();
                myTabPage.Controls.Add(myUserControl);
                MainTabs.TabPages.Add(myTabPage);
                myTabPage.Select();
            }

            if (e.Node.Name == "ItemQuery")
            {
                TabPage myTabPage = new TabPage("תיחקור פריט דינמי");
                ItemQuery myUserControl = new ItemQuery();
                myUserControl.TopLevel = false;
                //myUserControl.Dock = DockStyle.Fill;             
                myUserControl.Show();
                myTabPage.Controls.Add(myUserControl);
                MainTabs.TabPages.Add(myTabPage);
                MainTabs.Select();
                MainTabs.SelectTab(1);                
            }
            if (e.Node.Name == "Promotions")
            {
                TabPage myTabPage = new TabPage("הגדרות מבצעים");
                Promotions myUserControl = new Promotions();
                myUserControl.TopLevel = false;
                //myUserControl.Dock = DockStyle.Fill;             
                myUserControl.Show();
                myTabPage.Controls.Add(myUserControl);
                MainTabs.TabPages.Add(myTabPage);
                MainTabs.Select();
                MainTabs.SelectTab(1);
            }

            if (e.Node.Name == "InventoryBrowser")
            {
                TabPage myTabPage = new TabPage("תיחקור מלאי דנמי");
                InventoryBrowser myUserControl = new InventoryBrowser();
                myUserControl.TopLevel = false;
                //myUserControl.Dock = DockStyle.Fill;             
                myUserControl.Show();
                myTabPage.Controls.Add(myUserControl);
                MainTabs.TabPages.Add(myTabPage);
                MainTabs.Select();
                MainTabs.SelectTab(1);
            }

        }

        private void StoriXMain_ResizeEnd(object sender, EventArgs e)
        {
            foreach (TabPage t in MainTabs.TabPages)
            {
                foreach (Object o in t.Controls)
                {
                    //(o as Form).Dock = DockStyle.Fill;
                   // (o as Form).WindowState = FormWindowState.Maximized;
                }
            }
        }
    }
}
