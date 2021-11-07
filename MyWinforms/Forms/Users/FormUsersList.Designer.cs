using MyWinforms;

namespace MyWinforms.Forms.Users

{
    partial class FormUsersList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsersList));
            this.dataGridViewUsersList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersdbDataSetUsers = new MyWinforms.usersdbDataSetUsers();
            this.usersTableAdapter = new MyWinforms.usersdbDataSetUsersTableAdapters.UsersTableAdapter();
            this.toolStripUsersList = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCreate = new System.Windows.Forms.ToolStripButton();
            this.usersdbDataSetUsers1 = new MyWinforms.usersdbDataSetUsers();
            this.usersdbDataSetUsers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersdbDataSetUsers1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSetUsers)).BeginInit();
            this.toolStripUsersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSetUsers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSetUsers1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSetUsers1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsersList
            // 
            this.dataGridViewUsersList.AllowUserToAddRows = false;
            this.dataGridViewUsersList.AllowUserToOrderColumns = true;
            this.dataGridViewUsersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsersList.AutoGenerateColumns = false;
            this.dataGridViewUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridViewUsersList.DataSource = this.usersBindingSource;
            this.dataGridViewUsersList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewUsersList.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewUsersList.Name = "dataGridViewUsersList";
            this.dataGridViewUsersList.ReadOnly = true;
            this.dataGridViewUsersList.Size = new System.Drawing.Size(660, 415);
            this.dataGridViewUsersList.StandardTab = true;
            this.dataGridViewUsersList.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersdbDataSetUsers;
            // 
            // usersdbDataSetUsers
            // 
            this.usersdbDataSetUsers.DataSetName = "usersdbDataSetUsers";
            this.usersdbDataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripUsersList
            // 
            this.toolStripUsersList.BackColor = System.Drawing.Color.Snow;
            this.toolStripUsersList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUpdate,
            this.toolStripButtonBack,
            this.toolStripButtonCreate});
            this.toolStripUsersList.Location = new System.Drawing.Point(0, 0);
            this.toolStripUsersList.Name = "toolStripUsersList";
            this.toolStripUsersList.Size = new System.Drawing.Size(660, 25);
            this.toolStripUsersList.TabIndex = 1;
            this.toolStripUsersList.Text = "toolStrip1";
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.BackColor = System.Drawing.Color.Snow;
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonUpdate.Text = "Обновить";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);


            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonBack.Text = "Отмена";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripButtonCreate
            // 
            this.toolStripButtonCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButtonCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreate.Image")));
            this.toolStripButtonCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreate.Name = "toolStripButtonCreate";
            this.toolStripButtonCreate.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonCreate.Text = "Создать";
            this.toolStripButtonCreate.Click += new System.EventHandler(this.toolStripButtonCreate_Click);
            // 
            // usersdbDataSetUsers1
            // 
            this.usersdbDataSetUsers1.DataSetName = "usersdbDataSetUsers";
            this.usersdbDataSetUsers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersdbDataSetUsers1BindingSource
            // 
            this.usersdbDataSetUsers1BindingSource.DataSource = this.usersdbDataSetUsers1;
            this.usersdbDataSetUsers1BindingSource.Position = 0;
            // 
            // usersdbDataSetUsers1BindingSource1
            // 
            this.usersdbDataSetUsers1BindingSource1.DataSource = this.usersdbDataSetUsers1;
            this.usersdbDataSetUsers1BindingSource1.Position = 0;
            // 
            // FormUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(660, 440);
            this.Controls.Add(this.dataGridViewUsersList);
            this.Controls.Add(this.toolStripUsersList);
            this.Name = "FormUsersList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUsersList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSetUsers)).EndInit();
            this.toolStripUsersList.ResumeLayout(false);
            this.toolStripUsersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSetUsers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSetUsers1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSetUsers1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private usersdbDataSetUsers usersdbDataSetUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private usersdbDataSetUsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersdbDataSetUsers1BindingSource;
        private usersdbDataSetUsers usersdbDataSetUsers1;
        private System.Windows.Forms.ToolStrip toolStripUsersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.BindingSource usersdbDataSetUsers1BindingSource1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        public System.Windows.Forms.DataGridView dataGridViewUsersList;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreate;
    }
}