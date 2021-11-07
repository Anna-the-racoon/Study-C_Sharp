namespace MyWinforms.Forms.Materials
{
    partial class FormMaterialsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaterialsList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRenew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewMaterials = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaterials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripButtonCreate,
            this.toolStripSeparator4,
            this.toolStripButtonModify,
            this.toolStripSeparator5,
            this.toolStripButtonDelete,
            this.toolStripSeparator6,
            this.toolStripButtonRenew,
            this.toolStripSeparator1,
            this.toolStripLabelFilter,
            this.toolStripTextBoxFilter,
            this.toolStripButtonSearch,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(668, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonCreate
            // 
            this.toolStripButtonCreate.BackColor = System.Drawing.Color.White;
            this.toolStripButtonCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreate.Image")));
            this.toolStripButtonCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreate.Name = "toolStripButtonCreate";
            this.toolStripButtonCreate.Size = new System.Drawing.Size(70, 26);
            this.toolStripButtonCreate.Text = "Создать";
            this.toolStripButtonCreate.Click += new System.EventHandler(this.toolStripButtonCreate_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonModify
            // 
            this.toolStripButtonModify.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButtonModify.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModify.Image")));
            this.toolStripButtonModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModify.Name = "toolStripButtonModify";
            this.toolStripButtonModify.Size = new System.Drawing.Size(81, 26);
            this.toolStripButtonModify.Text = "Изменить";
            this.toolStripButtonModify.Click += new System.EventHandler(this.toolStripButtonModify_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(71, 26);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonRenew
            // 
            this.toolStripButtonRenew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButtonRenew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRenew.Image")));
            this.toolStripButtonRenew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRenew.Name = "toolStripButtonRenew";
            this.toolStripButtonRenew.Size = new System.Drawing.Size(81, 26);
            this.toolStripButtonRenew.Text = "Обновить";
            this.toolStripButtonRenew.Click += new System.EventHandler(this.toolStripButtonRenew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripLabelFilter
            // 
            this.toolStripLabelFilter.Name = "toolStripLabelFilter";
            this.toolStripLabelFilter.Size = new System.Drawing.Size(48, 26);
            this.toolStripLabelFilter.Text = "Фильтр";
            // 
            // toolStripTextBoxFilter
            // 
            this.toolStripTextBoxFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFilter.Name = "toolStripTextBoxFilter";
            this.toolStripTextBoxFilter.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBoxFilter.Click += new System.EventHandler(this.toolStripTextBoxFilter_Click);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(46, 26);
            this.toolStripButtonSearch.Text = "Поиск";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.ToolStripButtonSearch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // dataGridViewMaterials
            // 
            this.dataGridViewMaterials.AllowUserToAddRows = false;
            this.dataGridViewMaterials.AllowUserToDeleteRows = false;
            this.dataGridViewMaterials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnMaterials,
            this.ColumnQuantity,
            this.ColumnPrice,
            this.ColumnOrderId});
            this.dataGridViewMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaterials.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewMaterials.MultiSelect = false;
            this.dataGridViewMaterials.Name = "dataGridViewMaterials";
            this.dataGridViewMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterials.Size = new System.Drawing.Size(668, 375);
            this.dataGridViewMaterials.TabIndex = 1;
            this.dataGridViewMaterials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterials_CellContentClick);
            this.dataGridViewMaterials.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterials_RowValidated);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnMaterials
            // 
            this.ColumnMaterials.DataPropertyName = "Materials";
            this.ColumnMaterials.HeaderText = "Name";
            this.ColumnMaterials.Name = "ColumnMaterials";
            this.ColumnMaterials.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "Price";
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnOrderId
            // 
            this.ColumnOrderId.DataPropertyName = "OrderId";
            this.ColumnOrderId.HeaderText = "OrderId";
            this.ColumnOrderId.Name = "ColumnOrderId";
            this.ColumnOrderId.ReadOnly = true;
            // 
            // FormMaterialsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 404);
            this.Controls.Add(this.dataGridViewMaterials);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMaterialsList";
            this.Text = "FormMaterialsList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMaterialsList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilter;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFilter;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridViewMaterials;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonRenew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderId;
    }
}