using AdoNetFramework;
using System;
using System.Windows.Forms;

namespace MyWinforms.Forms.Materials
{
    public partial class FormMaterialCreate : Form
    {
        public FormMaterialCreate()
        {
            InitializeComponent();
        }

        private void FormMaterialCreate_Load(object sender, EventArgs e)
        {
            try
            {
                var service = new ServiceOrder();
                var orders = service.GetOrdersNumbers();

                comboBoxOrders.DataSource = orders;
                comboBoxOrders.DisplayMember = "Number";
                comboBoxOrders.ValueMember = "Id";
                comboBoxOrders.FormattingEnabled = true;
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
                string name = this.textBoxNameOfMaterial.Text;
                int quantity = Convert.ToInt32(this.textBoxQuantity.Text);
                decimal price = Convert.ToDecimal(this.textBoxPrice.Text);
                int orderId = Convert.ToInt32(this.comboBoxOrders.SelectedValue.ToString());

                service.CreateMaterial(name, quantity, price, orderId);

                MessageBox.Show($"Материал {name} успешно добавлен.");

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void textBoxNameOfMaterial_TextChanged(object sender, EventArgs e)
        {
          //проверка на ошибку
        }

        private int textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(Console.ReadLine());
            return quantity;
        }

        private decimal textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            int p = Int32.Parse(Console.ReadLine());
            decimal price = p;
            return price;
        }

        private void comboBoxOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
