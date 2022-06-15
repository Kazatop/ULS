using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ULS
{
    public partial class StorageAddForm : Form
    {
        private List<string> list = new List<string>();

        public StorageAddForm()
        {
            
            InitializeComponent();

            list = Database.HospitalNames();

            foreach (var item in list)
            {
                HospitalComboBox.Items.Add(item);
            }

            list = Database.DrugNames();

            foreach (var item in list)
            {
                DrugComboBox.Items.Add(item);
            }
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (HospitalComboBox.Text == "" || DrugComboBox.Text == "" || CountUpDown.Value == 0)
            {
                MessageBox.Show("Какие-то данные не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Database.StorageItemCheck(HospitalComboBox.SelectedIndex + 1, DrugComboBox.SelectedIndex + 1) == true)
            {
                Database.StorageItemIncrease(HospitalComboBox.SelectedIndex + 1, DrugComboBox.SelectedIndex + 1, Convert.ToInt32(CountUpDown.Value));
            }
            else
            {
                Database.StorageItemInsert(HospitalComboBox.SelectedIndex + 1, DrugComboBox.SelectedIndex + 1, Convert.ToInt32(CountUpDown.Value));
            }
            this.Close();
        }
    }
}
