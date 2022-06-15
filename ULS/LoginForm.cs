using System;
using System.Windows.Forms;

namespace ULS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ПроверитьПодключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.connectionPath, "Проверка подключения");
        }

        private void ИзменитьПодключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeConnectionForm changeConnectionForm = new ChangeConnectionForm();
            changeConnectionForm.ShowDialog();
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Database.LoginConfirmation(LoginTextBox.Text, PasswordTextBox.Text) == true)
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
