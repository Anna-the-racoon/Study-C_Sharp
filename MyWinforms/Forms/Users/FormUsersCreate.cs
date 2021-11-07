using System;
using System.Windows.Forms;

namespace MyWinforms.Forms.Users
{
    public partial class FormUsersCreate : Form
    {
        public FormUsersCreate()
        {
            InitializeComponent();
        }

        private void FormUsersCreate_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            for (int i = 1; i < 1000; i++)
            {
                var button = new Button() { Name = $"Button{i:0000}" };   
                button.Size = new System.Drawing.Size(75, 23);
                button.Text = $"button{i:0000}";
                button.UseVisualStyleBackColor = true;
                flowLayoutPanel1.Controls.Add(button);
            }
            this.ResumeLayout(false);
        }
    }
}
