using AdoNetFramework;
using System;
using System.Windows.Forms;

namespace MyWinforms.Forms.Materials
{
    public partial class FormMaterialsList : Form
    {

        private BindingSource BindingSourceMaterials { get; set; }

        public FormMaterialsList()
        {
            InitializeComponent();

            BindingSourceMaterials = new BindingSource();

            dataGridViewMaterials.DataSource = BindingSourceMaterials;
        }

        private void FormMaterialsList_Load(object sender, EventArgs e)
        {
            try
            {
                var service = new ServiceMaterialWf();

                var datatable = service.GetMaterials();

                //изменение размера табличек
                dataGridViewMaterials.AutoGenerateColumns = false;

                BindingSourceMaterials.DataSource = datatable;

                
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void toolStripButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormMaterialCreate();
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void toolStripButtonModify_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dataGridViewMaterials.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите одну строку!");
                    return;
                }

                this.toolStripButtonModify = new ToolStripButton();
                // orderId = toolStripButtonModify;

                int id = Convert.ToInt32(this.dataGridViewMaterials.SelectedRows[0].Cells["ColumnId"].Value);
                string name = this.dataGridViewMaterials.SelectedRows[0].Cells["ColumnMaterials"].Value.ToString();
                int quantity = Convert.ToInt32(this.dataGridViewMaterials.SelectedRows[0].Cells["ColumnQuantity"].Value);
                decimal price = Convert.ToDecimal(this.dataGridViewMaterials.SelectedRows[0].Cells["ColumnPrice"].Value);
                int orderId = (int)(dataGridViewMaterials.SelectedRows[0].Cells["ColumnOrderId"].Value);


                var form = new FormMaterialUpdate(id, name, quantity, price, orderId);
                form.MdiParent=this.MdiParent;
                form.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //this.toolStripButtonModify = new ToolStripButton();
            //int id = Convert.ToInt32(this.dataGridViewMaterials.SelectedRows[0].Cells["ColumnId"].Value);


            //вызываем диалоговое окно, которое предлагает удалить
            var result = MessageBox.Show(
                   "Вы уверены, что хотите удалить эту запись?", "Запись будет удалена безвозвратно",
                   MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.toolStripButtonModify = new ToolStripButton();

                    int id = Convert.ToInt32(this.dataGridViewMaterials.SelectedRows[0].Cells["ColumnId"].Value);

                    var service = new ServiceMaterialWf();
                    service.DeleteMaterials(id);


                    foreach (DataGridViewRow row in dataGridViewMaterials.SelectedRows)
                    {
                        dataGridViewMaterials.Rows.Remove(row);
                    }

                    //Message.ReferenceEquals
                    MessageBox.Show($"Объект был удален");

                    dataGridViewMaterials.CurrentCell = dataGridViewMaterials.Rows[dataGridViewMaterials.Rows.Count - 1].Cells[0];
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Exception: {exception.Message}");
                }

            }
            else
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
        }

        private void ToolStripButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSourceMaterials.Filter = $"Materials LIKE '*{toolStripTextBoxFilter.Text}*'";
                BindingSourceMaterials.Filter = $"OrderId LIKE '*{toolStripTextBoxFilter.Text}*'"; 
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void toolStripTextBoxFilter_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Exception: {exception.Message}");
            }
        }

        private void toolStripButtonRenew_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ServiceMaterialWf();

                var datatable = service.GetMaterials();
                BindingSourceMaterials.DataSource = datatable;
            }
            catch
            {
                throw;
            }
        }

        private void dataGridViewMaterials_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
