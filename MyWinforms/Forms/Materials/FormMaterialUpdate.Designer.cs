namespace MyWinforms.Forms.Materials
{
    partial class FormMaterialUpdate
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.comboBoxOrderNumber = new System.Windows.Forms.ComboBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsUpdateDataSet = new MyWinforms.MaterialsUpdateDataSet();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.ordersTableAdapter = new MyWinforms.MaterialsUpdateDataSetTableAdapters.OrdersTableAdapter();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsUpdateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(0, 399);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(698, 50);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(186, 116);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(161, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Введите название материала:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(180, 221);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(167, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Введите стоимость материала:";
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(698, 23);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(353, 218);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 10;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(176, 168);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(171, 13);
            this.labelQuantity.TabIndex = 12;
            this.labelQuantity.Text = "Введите количество материала:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(353, 165);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantity.TabIndex = 13;
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Location = new System.Drawing.Point(213, 273);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(134, 13);
            this.labelOrderId.TabIndex = 14;
            this.labelOrderId.Text = "Выберете номер заказа:";
            // 
            // comboBoxOrderNumber
            // 
            this.comboBoxOrderNumber.DataSource = this.ordersBindingSource;
            this.comboBoxOrderNumber.DisplayMember = "Number";
            this.comboBoxOrderNumber.FormattingEnabled = true;
            this.comboBoxOrderNumber.Location = new System.Drawing.Point(353, 270);
            this.comboBoxOrderNumber.Name = "comboBoxOrderNumber";
            this.comboBoxOrderNumber.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrderNumber.TabIndex = 15;
            this.comboBoxOrderNumber.ValueMember = "Id";
            this.comboBoxOrderNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderNumber_SelectedIndexChanged);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.materialsUpdateDataSet;
            // 
            // materialsUpdateDataSet
            // 
            this.materialsUpdateDataSet.DataSetName = "MaterialsUpdateDataSet";
            this.materialsUpdateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(353, 113);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(270, 70);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(77, 13);
            this.labelId.TabIndex = 16;
            this.labelId.Text = "Id материала:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(353, 67);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(121, 20);
            this.textBoxId.TabIndex = 17;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // FormMaterialUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 449);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.comboBoxOrderNumber);
            this.Controls.Add(this.labelOrderId);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormMaterialUpdate";
            this.Text = "FormMaterialUpdate";
            this.Load += new System.EventHandler(this.FormMaterialUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsUpdateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.ComboBox comboBoxOrderNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private MaterialsUpdateDataSet materialsUpdateDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MaterialsUpdateDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
    }
}