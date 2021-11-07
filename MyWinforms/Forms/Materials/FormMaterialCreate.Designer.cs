namespace MyWinforms.Forms.Materials
{
    partial class FormMaterialCreate
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
            this.labelNameOfMaterial = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNameOfMaterial = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.comboBoxOrders = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNameOfMaterial
            // 
            this.labelNameOfMaterial.AutoSize = true;
            this.labelNameOfMaterial.Location = new System.Drawing.Point(156, 113);
            this.labelNameOfMaterial.Name = "labelNameOfMaterial";
            this.labelNameOfMaterial.Size = new System.Drawing.Size(161, 13);
            this.labelNameOfMaterial.TabIndex = 0;
            this.labelNameOfMaterial.Text = "Введите название материала:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(597, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 450);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Создать";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNameOfMaterial
            // 
            this.textBoxNameOfMaterial.Location = new System.Drawing.Point(327, 110);
            this.textBoxNameOfMaterial.Name = "textBoxNameOfMaterial";
            this.textBoxNameOfMaterial.Size = new System.Drawing.Size(195, 20);
            this.textBoxNameOfMaterial.TabIndex = 0;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(146, 180);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(171, 13);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Введите количество материала:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(327, 245);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(195, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(91, 248);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(226, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Введите стоимость за еденицу материала:";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 450);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(327, 177);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(195, 20);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Location = new System.Drawing.Point(191, 315);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(126, 13);
            this.labelOrderId.TabIndex = 11;
            this.labelOrderId.Text = "Введите номер заказа:";
            // 
            // comboBoxOrders
            // 
            this.comboBoxOrders.DisplayMember = "Number";
            this.comboBoxOrders.FormattingEnabled = true;
            this.comboBoxOrders.Location = new System.Drawing.Point(327, 312);
            this.comboBoxOrders.Name = "comboBoxOrders";
            this.comboBoxOrders.Size = new System.Drawing.Size(195, 21);
            this.comboBoxOrders.TabIndex = 3;
            this.comboBoxOrders.ValueMember = "Id";
            this.comboBoxOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderId_SelectedIndexChanged);
            // 
            // FormMaterialCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.comboBoxOrders);
            this.Controls.Add(this.labelOrderId);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxNameOfMaterial);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelNameOfMaterial);
            this.Name = "FormMaterialCreate";
            this.Text = "FormMaterialCreate";
            this.Load += new System.EventHandler(this.FormMaterialCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameOfMaterial;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxNameOfMaterial;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.ComboBox comboBoxOrders;
    }
}