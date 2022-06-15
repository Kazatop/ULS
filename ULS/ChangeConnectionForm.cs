using System;
using System.Windows.Forms;

namespace ULS
{
    public partial class ChangeConnectionForm : Form
    {
        public ChangeConnectionForm()
        {
            InitializeComponent();
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (ChangeConnectionTextBox.Text == "")
            {
                this.Close();
            }
            else
            {
                Database.ChangeConnectionPath(ChangeConnectionTextBox.Text);
                this.Close();
            }
        }
    }
}
