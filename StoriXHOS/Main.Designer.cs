namespace StoriXHOS
{
    partial class StoriXMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("דוחות");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("סוף יום");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("משרד אחורי", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("תיחקור פריט דינמי");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("קבוצות מבצעים");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("הגדרת מבצעים");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("תמחור", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("קטלוג", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("תיחקור מלאי דינמי");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("מלאי", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("תצורה");
            this.LeftMenu = new System.Windows.Forms.TreeView();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.דשבורד = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainTabs.SuspendLayout();
            this.דשבורד.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMenu
            // 
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.LeftMenu.Location = new System.Drawing.Point(1177, 0);
            this.LeftMenu.Name = "LeftMenu";
            treeNode1.Name = "Reports";
            treeNode1.Text = "דוחות";
            treeNode2.Name = "EOD";
            treeNode2.Text = "סוף יום";
            treeNode3.Name = "BackOffice";
            treeNode3.Text = "משרד אחורי";
            treeNode4.Name = "ItemQuery";
            treeNode4.Text = "תיחקור פריט דינמי";
            treeNode5.Name = "PromoGroups";
            treeNode5.Text = "קבוצות מבצעים";
            treeNode6.Name = "Promotions";
            treeNode6.Text = "הגדרת מבצעים";
            treeNode7.Name = "Priceing";
            treeNode7.Text = "תמחור";
            treeNode8.Name = "Node1";
            treeNode8.Text = "קטלוג";
            treeNode9.Name = "InventoryBrowser";
            treeNode9.Text = "תיחקור מלאי דינמי";
            treeNode10.Name = "Node2";
            treeNode10.Text = "מלאי";
            treeNode11.Name = "Node3";
            treeNode11.Text = "תצורה";
            this.LeftMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode10,
            treeNode11});
            this.LeftMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LeftMenu.Size = new System.Drawing.Size(156, 843);
            this.LeftMenu.TabIndex = 0;
            this.LeftMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LeftMenu_AfterSelect);
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.דשבורד);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Multiline = true;
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(1177, 843);
            this.MainTabs.TabIndex = 1;
            // 
            // דשבורד
            // 
            this.דשבורד.BackColor = System.Drawing.SystemColors.Control;
            this.דשבורד.Controls.Add(this.pictureBox1);
            this.דשבורד.Location = new System.Drawing.Point(4, 22);
            this.דשבורד.Name = "דשבורד";
            this.דשבורד.Padding = new System.Windows.Forms.Padding(3);
            this.דשבורד.Size = new System.Drawing.Size(1169, 817);
            this.דשבורד.TabIndex = 0;
            this.דשבורד.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoriXHOS.Properties.Resources.StoriXDashboard;
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1159, 802);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StoriXMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 843);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.LeftMenu);
            this.Name = "StoriXMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "StoriX";
            this.ResizeEnd += new System.EventHandler(this.StoriXMain_ResizeEnd);
            this.MainTabs.ResumeLayout(false);
            this.דשבורד.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView LeftMenu;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage דשבורד;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

