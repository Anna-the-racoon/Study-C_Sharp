using AdoNetFramework;
using System;
using System.Windows.Forms;

namespace MyWinforms.Forms.Materials
{
    public partial class FormMaterialUpdate : Form
    {
        private readonly int id;
        private readonly string name;
        private readonly int quantity;
        private readonly decimal price;
        private readonly int orderId;

        public FormMaterialUpdate(int id, string name, int quantity, decimal price, int orderId)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.orderId = orderId;
        }

        private void FormMaterialUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'materialsUpdateDataSet.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.materialsUpdateDataSet.Orders);
            try
            {
                this.textBoxId.Text = Convert.ToString(this.id);
                this.textBoxName.Text = this.name;
                this.textBoxQuantity.Text = Convert.ToString(this.quantity);
                this.textBoxPrice.Text = Convert.ToString(this.price);
                this.comboBoxOrderNumber.Text = Convert.ToString(this.orderId);

                var service = new ServiceOrder();
                var orders = service.GetOrdersNumbers();
                comboBoxOrderNumber.DataSource = orders;
                comboBoxOrderNumber.DisplayMember = "Number";
                comboBoxOrderNumber.ValueMember = "Id";
                comboBoxOrderNumber.FormattingEnabled = true;
                comboBoxOrderNumber.SelectedValue = orderId;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ServiceMaterialWf();
                int id = Convert.ToInt32(this.textBoxId.Text);
                string name = this.textBoxName.Text;
                int quantity = Convert.ToInt32(this.textBoxQuantity.Text);
                decimal price = Convert.ToDecimal(this.textBoxPrice.Text);
                int orderId = Convert.ToInt32(this.comboBoxOrderNumber.SelectedValue.ToString());

                service.UpdateMaterials(id, name, quantity, price, orderId);


                MessageBox.Show($"Материал {name} успешно изменен.");

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void comboBoxOrderNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
