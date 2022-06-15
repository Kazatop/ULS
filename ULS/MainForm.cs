using System;
using System.Windows.Forms;

namespace ULS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Employee employee = Database.EmployeeGetInformation();

            EmployeeAccountIdLabel.Text = "ID Аккаунта: " + Database.accountId.ToString();
            EmployeePrivilegesLabel.Text = "Привилегии: " + employee.privileges.ToString();
            EmployeeFirstNameLabel.Text = "Фамилия: " + employee.firstName.ToString();
            EmployeeLastNameLabel.Text = "Имя: " + employee.lastName.ToString();
            EmployeePatronymicLabel.Text = "Отчество: " + employee.patronymic.ToString();
            EmployeePostLabel.Text = "Должность: " + employee.post.ToString();
            EmployeePictureBox.ImageLocation = System.IO.Directory.GetCurrentDirectory() + "/Avatars" + employee.photoPath;

            if (employee.post == "Медицинский работник")
            {
                ProcessUnactiveInvoiceButton.Enabled = false;
                CompleteActiveInvoiceButton.Enabled = false;
                CompletedInvoicesReportButton.Enabled = false;
                AllInvoicesReportButton.Enabled = false;
                StorageAddButton.Enabled = false;
                StorageReportButton.Enabled = false;
            }

            UpdateTabPagesMainTab();
        }

        private void UpdateTabPagesMainTab()
        {
            if (MainTabControl.SelectedIndex == 0)
            {
                Database.DisplayAllUnactiveInvoices(UnactiveInvoiceGridView);
            }
            else if (MainTabControl.SelectedIndex == 1)
            {
                Database.DisplayAllActiveInvoices(ActiveInvoiceGridView);
            }
            else if (MainTabControl.SelectedIndex == 2)
            {
                Database.DisplayAllCompletedInvoices(CompletedInvoiceGridView);
            }
            else if (MainTabControl.SelectedIndex == 3)
            {
                Database.DisplayAllInvoices(AllInvoiceGridView);
            }
            else if (MainTabControl.SelectedIndex == 4)
            {
                Database.DisplayStorage(StorageGridView);
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTabPagesMainTab();
        }

        private void CreateUnactiveInvoiceButton_Click(object sender, EventArgs e)
        {
            InvoiceCreationForm invoiceCreationForm = new InvoiceCreationForm();
            invoiceCreationForm.ShowDialog();

            UpdateTabPagesMainTab();
        }

        private void ProcessUnactiveInvoiceButton_Click(object sender, EventArgs e)
        {
            if (UnactiveInvoiceGridView.RowCount == 0)
            {
                return;
            }    
            if (UnactiveInvoiceGridView.SelectedCells != null)
            {
                Database.ProcessUnactiveInvoice(Convert.ToInt32(UnactiveInvoiceGridView.Rows[UnactiveInvoiceGridView.SelectedCells[0].RowIndex].Cells[1].Value));
                UnactiveDrugsInvoiceGridView.DataSource = "";
                UpdateTabPagesMainTab();
            }
        }

        private void UnactiveInvoiceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            if (UnactiveInvoiceGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Database.DisplaySelectedDrugsOfInvoice(UnactiveDrugsInvoiceGridView, Convert.ToInt32(UnactiveInvoiceGridView.Rows[e.RowIndex].Cells[1].Value));
            }
        }

        private void ActiveInvoiceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            if (ActiveInvoiceGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Database.DisplaySelectedDrugsOfInvoice(ActiveDrugsInvoiceGridView, Convert.ToInt32(ActiveInvoiceGridView.Rows[e.RowIndex].Cells[1].Value));
            }
        }

        private void CompleteActiveInvoiceButton_Click(object sender, EventArgs e)
        {
            if (ActiveInvoiceGridView.RowCount == 0)
            {
                return;
            }
            if (ActiveDrugsInvoiceGridView.SelectedCells != null && ActiveDrugsInvoiceGridView.RowCount != 0)
            {
                int[] drugIdCount = new int[3];

                for (int i = 0; i < ActiveDrugsInvoiceGridView.RowCount; i++)
                {
                    drugIdCount[0] = Convert.ToInt32(ActiveDrugsInvoiceGridView.Rows[i].Cells[2].Value);
                    drugIdCount[1] = Convert.ToInt32(ActiveDrugsInvoiceGridView.Rows[i].Cells[4].Value);
                    drugIdCount[2] = Convert.ToInt32(ActiveDrugsInvoiceGridView.Rows[i].Cells[1].Value);
                    if (Database.CompleteActiveInvoiceCheck(drugIdCount[0], drugIdCount[1], drugIdCount[2]) == false)
                    {
                        MessageBox.Show($"Товара с номером {drugIdCount[0]} недостаточно на складе больницы номер {Database.SelectHospitalByInvoiceId(drugIdCount[2])}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                for (int i = 0; i < ActiveDrugsInvoiceGridView.RowCount; i++)
                {
                    drugIdCount[0] = Convert.ToInt32(ActiveDrugsInvoiceGridView.Rows[i].Cells[2].Value);
                    drugIdCount[1] = Convert.ToInt32(ActiveDrugsInvoiceGridView.Rows[i].Cells[4].Value);
                    drugIdCount[2] = Convert.ToInt32(ActiveDrugsInvoiceGridView.Rows[i].Cells[1].Value);
                    Database.CompleteActiveInvoiceDecreaseStorage(drugIdCount[0], drugIdCount[1], drugIdCount[2]);
                }
                Database.ProcessActiveInvoiceToComplete(Convert.ToInt32(ActiveInvoiceGridView.Rows[ActiveInvoiceGridView.SelectedCells[0].RowIndex].Cells[1].Value));

                ActiveDrugsInvoiceGridView.DataSource = "";
                UpdateTabPagesMainTab();
            }
        }

        private void CompletedInvoiceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            if (CompletedInvoiceGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Database.DisplaySelectedDrugsOfInvoice(CompletedDrugsInvoiceGridView, Convert.ToInt32(CompletedInvoiceGridView.Rows[e.RowIndex].Cells[1].Value));
            }
        }

        private void AllInvoiceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            if (AllInvoiceGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Database.DisplaySelectedDrugsOfInvoice(AllDrugsInvoiceGridView, Convert.ToInt32(AllInvoiceGridView.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void StorageAddButton_Click(object sender, EventArgs e)
        {
            StorageAddForm storageAddForm = new StorageAddForm();
            storageAddForm.ShowDialog();

            UpdateTabPagesMainTab();
        }

        private void CompletedInvoicesReportButton_Click(object sender, EventArgs e)
        {
            if (CompletedDrugsInvoiceGridView.Rows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали накладную", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ExportMicrosoftOffice.ExportExcel(CompletedInvoiceGridView, CompletedDrugsInvoiceGridView);
        }

        private void AllInvoicesReportButton_Click(object sender, EventArgs e)
        {
            if (AllDrugsInvoiceGridView.Rows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали накладную", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ExportMicrosoftOffice.ExportExcel(AllInvoiceGridView, AllDrugsInvoiceGridView);
        }

        private void StorageReportButton_Click(object sender, EventArgs e)
        {
            ExportMicrosoftOffice.ExportExcel(StorageGridView);
        }
    }
}
