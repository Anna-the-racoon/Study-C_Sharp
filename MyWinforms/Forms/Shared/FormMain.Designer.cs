namespace MyWinforms
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItemOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItemMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemListOfUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItemOrders,
            this.materialsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItemOrders
            // 
            this.ordersToolStripMenuItemOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.ordersToolStripMenuItemOrders.Name = "ordersToolStripMenuItemOrders";
            this.ordersToolStripMenuItemOrders.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItemOrders.Text = "Orders";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItemOrders_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // materialsToolStripMenuItem
            // 
            this.materialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItemMaterials});
            this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            this.materialsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.materialsToolStripMenuItem.Text = "Materials";
            // 
            // listToolStripMenuItemMaterials
            // 
            this.listToolStripMenuItemMaterials.Name = "listToolStripMenuItemMaterials";
            this.listToolStripMenuItemMaterials.Size = new System.Drawing.Size(92, 22);
            this.listToolStripMenuItemMaterials.Text = "List";
            this.listToolStripMenuItemMaterials.Click += new System.EventHandler(this.listToolStripMenuItemMaterials_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItemListOfUsers});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(89, 6);
            // 
            // toolStripMenuItemListOfUsers
            // 
            this.toolStripMenuItemListOfUsers.Name = "toolStripMenuItemListOfUsers";
            this.toolStripMenuItemListOfUsers.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItemListOfUsers.Text = "List";
            this.toolStripMenuItemListOfUsers.Click += new System.EventHandler(this.toolStripMenuItemListOfUsers_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(633, 456);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItemOrders;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItemMaterials;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemListOfUsers;
    }
}

