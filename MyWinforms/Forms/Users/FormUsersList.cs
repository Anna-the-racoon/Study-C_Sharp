using System;
using System.Windows.Forms;

namespace MyWinforms.Forms.Users
{
    public partial class FormUsersList : Form
    {
        public FormUsersList()
        {
            InitializeComponent();
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.Message);
            this.toolStripButtonBack.Click += new System.EventHandler(this.Message);

        }

        private void FormUsersList_Load(object sender, EventArgs e)
        {
        }

        public void Message(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Операция выполнена", "", MessageBoxButtons.OK);
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersdbDataSetUsers.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersdbDataSetUsers.Users);
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            var resilt = MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButtons.OKCancel);
            if (resilt == DialogResult.OK)
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
        private void toolStripButtonCreate_Click(object sender, EventArgs e)
        {
            var form = new FormUsersCreate();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

    }
}

