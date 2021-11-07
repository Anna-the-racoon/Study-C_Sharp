using System;
using System.Windows.Forms;

namespace MyWinforms.Forms.Orders
{
    public partial class FormOrderList : Form
    {
        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.orderDetailsDataSet.Orders);
            this.materialsTableAdapter.Fill(this.orderDetailsDataSet.Materials);

        }

        private void toolStripTextBoxFilter_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = this.toolStripTextBoxFilter.Text.Trim();

                if (text == null)
                {
                    this.ordersTableAdapter.Fill(this.orderDetailsDataSet.Orders);
                    this.materialsTableAdapter.Fill(this.orderDetailsDataSet.Materials);
                }
                else
                {
                    this.ordersTableAdapter.FillByNumber(this.orderDetailsDataSet.Orders, text);
                    this.materialsTableAdapter.Fill(this.orderDetailsDataSet.Materials);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }  
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
            this.ordersTableAdapter.Update(this.orderDetailsDataSet.Orders);
            MessageBox.Show("Изменение сохранено");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
