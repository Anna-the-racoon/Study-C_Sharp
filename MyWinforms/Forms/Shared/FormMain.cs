using MyWinforms.Forms.Materials;
using MyWinforms.Forms.Orders;
using MyWinforms.Forms.Users;
using System;
using System.Windows.Forms;

namespace MyWinforms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void listToolStripMenuItemOrders_Click(object sender, EventArgs e)
        {
            var form = new FormOrderList();
            form.MdiParent = this;
            form.Show();
        }

        private void listToolStripMenuItemMaterials_Click(object sender, EventArgs e)
        {
            var form = new FormMaterialsList();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItemListOfUsers_Click(object sender, EventArgs e)
        {
            var form = new FormUsersList();
            form.MdiParent = this;
            form.Show();
        }
    }
}