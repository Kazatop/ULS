using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ULS
{
    public partial class InvoiceCreationForm : Form
    {
        private List<string> list = new List<string>();
        private List<DrugInvoice> drugInvoiceList = new List<DrugInvoice>();
        public InvoiceCreationForm()
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

        private void RefreshDrugList()
        {
            DrugsListBox.Items.Clear();
            foreach (var item in drugInvoiceList)
            {
                DrugsListBox.Items.Add($"Препарат: {item.name}, количество: {item.count}");
            }
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = DrugComboBox.SelectedIndex + 1;
            CheckDrungInList(selectedIndex);

            RefreshDrugList();
        }

        private bool CheckDrungInList(int drugId)
        {
            for (int i = 0; i < drugInvoiceList.Count; i++)
            {
                if (drugId == drugInvoiceList[i].id)
                {
                    drugInvoiceList[i].count += Convert.ToInt32(CountUpDown.Value);
                    return true;
                }
            }
            AddDrugToList();
            return false;
        }

        private void AddDrugToList()
        {
            if (HospitalComboBox.Text == "" || DrugComboBox.Text == "" || CountUpDown.Value == 0)
            {
                MessageBox.Show("Данные не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DrugInvoice drugInvoice = new DrugInvoice();

            drugInvoice.id = DrugComboBox.SelectedIndex + 1;
            drugInvoice.name = DrugComboBox.Text;
            drugInvoice.count = Convert.ToInt32(CountUpDown.Value);

            drugInvoiceList.Add(drugInvoice);

            RefreshDrugList();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (HospitalComboBox.Text == "" || DrugComboBox.Text == "" || CountUpDown.Value == 0 || DrugsListBox.Items.Count == 0)
            {
                MessageBox.Show("Какие-то данные не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Database.CreateInvoice(HospitalComboBox.SelectedIndex + 1, drugInvoiceList);
            this.Close();
        }
    }
}
