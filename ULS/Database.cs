using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ULS
{
    public static class Database
    {
        public static string connectionPath = @"Data Source=localhost;Initial Catalog=ULS;Integrated Security=True";
        public static int accountId;

        public static void ChangeConnectionPath(string newSource)
        {
            connectionPath = $"Data Source={newSource};Initial Catalog=ULS;Integrated Security=True";
        }

        public static bool LoginConfirmation(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = "SELECT Login, Password, ID FROM Accounts";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    bool confirm = false;

                    while (reader.Read())
                    {
                        if (reader["Login"].ToString() == login && reader["Password"].ToString() == password)
                        {
                            accountId = Convert.ToInt32(reader["ID"]);
                            confirm = true;
                        }
                    }
                    connection.Close();
                    return confirm;
                }
            }
        }

        public static Employee EmployeeGetInformation()
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                Employee employee = new Employee();

                string databaseCommand = $"SELECT Employees.First_Name, Employees.Last_Name, Employees.Patronymic, Employees.Photo_Path, Accounts.Privileges, Post.Name FROM Employees, Accounts, Post WHERE Employees.ID_Account = Accounts.ID AND Employees.ID_Account = {accountId} AND Employees.ID_Post = Post.ID";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employee.firstName = reader["First_Name"].ToString();
                        employee.lastName = reader["Last_Name"].ToString();
                        employee.patronymic = reader["Patronymic"].ToString();
                        employee.photoPath = reader["Photo_Path"].ToString();
                        employee.privileges = reader["Privileges"].ToString();
                        employee.post = reader["Name"].ToString();
                    }
                }
                connection.Close();

                return employee;
            }
        }

        public static void DisplayAllUnactiveInvoices(DataGridView dataGrid)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                string command = "SELECT Invoice.ID AS Номер, ID_Invoice AS 'Номер накладной', Date AS Дата FROM Unactive_Invoice, Invoice WHERE Unactive_Invoice.ID = Invoice.ID";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                connection.Close();
            }
        }

        public static void DisplaySelectedDrugsOfInvoice(DataGridView dataGrid, int invoiceId)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                string command = $"SELECT Drug_of_Invoice.ID AS Номер, ID_Invoice AS 'Номер накладной', Drugs.ID AS 'Номер препарата', Drugs.Name AS 'Название препарата', Drug_of_Invoice.Count AS 'Требуемое количество' FROM Drug_of_Invoice, Drugs WHERE Drug_of_Invoice.ID_Invoice = {invoiceId} AND Drugs.ID = Drug_of_Invoice.ID_Drug";

                SqlDataAdapter adapted = new SqlDataAdapter(command, connectionPath);
                adapted.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                connection.Close();
            }
        }

        public static void ProcessUnactiveInvoice(int invoiceID)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = $"SELECT ID FROM Employees WHERE Employees.ID_Account = {accountId}";
                int employeeID = -1;

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employeeID = Convert.ToInt32(reader["ID"]);
                    }
                }

                databaseCommand = $"INSERT INTO Active_Invoice(ID_Employee, ID_Invoice) VALUES ({employeeID}, {invoiceID}); DELETE FROM Unactive_Invoice WHERE Unactive_Invoice.ID_Invoice = {invoiceID};";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void DisplayAllActiveInvoices(DataGridView dataGrid)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                string command = "SELECT Invoice.ID AS Номер, ID_Invoice AS 'Номер накладной', (Employees.First_Name + ' ' + Employees.Last_Name + ' ' + Employees.Patronymic) AS Сотрудник, Date AS Дата FROM Active_Invoice, Invoice, Employees WHERE Active_Invoice.ID = Invoice.ID AND Active_Invoice.ID_Employee = Employees.ID";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                connection.Close();
            }
        }

        public static bool CompleteActiveInvoiceCheck(int drugId, int count, int invoiceId)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                int hospitalId = -1;
                string databaseCommand = $"SELECT ID_Hospital FROM Invoice WHERE Invoice.ID = {invoiceId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hospitalId = Convert.ToInt32(reader["ID_Hospital"]);
                    }
                }

                databaseCommand = $"SELECT * FROM Storage WHERE {drugId} = Storage.ID_Drug AND {hospitalId} = Storage.ID_Hospital AND {count} <= Storage.Count";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    bool confirm = false;

                    while (reader.Read())
                    {
                        confirm = true;
                    }

                    connection.Close();
                    return confirm;
                }
            }
        }

        public static int SelectHospitalByInvoiceId(int invoiceId)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                int hospitalId = -1;
                string databaseCommand = $"SELECT ID_Hospital FROM Invoice WHERE Invoice.ID = {invoiceId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hospitalId = Convert.ToInt32(reader["ID_Hospital"]);
                    }
                    
                }

                connection.Close();
                return hospitalId;
            }
        }

        public static void CompleteActiveInvoiceDecreaseStorage(int drugId, int count, int invoiceId)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                int hospitalId = 0;
                string databaseCommand = $"SELECT ID_Hospital FROM Invoice WHERE ID = {invoiceId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hospitalId = Convert.ToInt32(reader["ID_Hospital"]);
                    }
                }

                databaseCommand = $"UPDATE Storage SET Count = Count - {count} WHERE ID_Drug = {drugId} AND ID_Hospital = {hospitalId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public static void ProcessActiveInvoiceToComplete(int invoiceId)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                int hospitalId = -1;
                string today = System.DateTime.Today.ToString("yyyy-MM-dd");
                string databaseCommand = $"SELECT ID_Hospital FROM Invoice WHERE ID = {invoiceId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hospitalId = Convert.ToInt32(reader["ID_Hospital"]);
                    }
                }

                databaseCommand = $"INSERT INTO Completed_Invoice(ID_Invoice, Date) VALUES ({invoiceId}, '{today}')";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                databaseCommand = $"DELETE Active_Invoice WHERE ID_Invoice = {invoiceId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public static void DisplayAllCompletedInvoices(DataGridView dataGrid)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                string command = "SELECT ID AS Номер, ID_Invoice AS 'Номер накладной', Date AS Дата FROM Completed_Invoice";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                connection.Close();
            }
        }

        public static void DisplayAllInvoices(DataGridView dataGrid)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                string command = "SELECT Invoice.ID AS Номер, ID_Hospital AS 'Номер больницы', Hospital.Name AS 'Название больницы', Date AS Дата FROM Invoice, Hospital WHERE Hospital.ID = Invoice.ID_Hospital";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                connection.Close();
            }
        }

        public static void DisplayStorage(DataGridView dataGrid)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                string command = "SELECT Storage.ID AS Номер, ID_Drug AS 'Номер препарата', Drugs.Name AS 'Название препарата', Count AS 'Доступное количество', ID_Hospital AS 'Номер больницы', Hospital.Name AS Больница FROM Storage, Drugs, Hospital WHERE Drugs.ID = Storage.ID_Drug AND Hospital.ID = Storage.ID_Hospital";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                connection.Close();
            }
        }

        public static List<string> HospitalNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = $"SELECT Name FROM Hospital";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> hospitalNames = new List<string>();

                    while (reader.Read())
                    {
                        hospitalNames.Add(reader["Name"].ToString());
                    }

                    connection.Close();
                    return hospitalNames;
                }
            }
        }

        public static List<string> DrugNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = $"SELECT Name FROM Drugs";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> drugNames = new List<string>();

                    while (reader.Read())
                    {
                        drugNames.Add(reader["Name"].ToString());
                    }

                    connection.Close();
                    return drugNames;
                }
            }
        }

        public static bool StorageItemCheck(int hospitalId, int drugId)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = $"SELECT * FROM Storage WHERE ID_Hospital = {hospitalId} AND ID_Drug = {drugId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return true;
                    }
                }
                connection.Close();
                return false;
            }
        }

        public static void StorageItemIncrease(int hospitalId, int drugId, int count)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = $"UPDATE Storage SET Count = Count + {count} WHERE ID_Hospital = {hospitalId} AND ID_Drug = {drugId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public static void StorageItemInsert(int hospitalId, int drugId, int count)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = $"INSERT INTO Storage(ID_Drug, ID_Hospital, Count) VALUES ({drugId}, {hospitalId}, {count})";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public static void CreateInvoice(int hospitalId, List<DrugInvoice> drugInvoiceList)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string today = System.DateTime.Today.ToString("yyyy-MM-dd");
                string databaseCommand = $"INSERT INTO Invoice(ID_Hospital, Date) VALUES ({hospitalId}, '{today}')";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                databaseCommand = $"SELECT Invoice.ID FROM Invoice WHERE ID_Hospital = {hospitalId} AND Date = '{today}'";
                int invoiceId = -1;

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        invoiceId = Convert.ToInt32(reader["ID"]);
                    }
                }

                databaseCommand = $"INSERT INTO Unactive_Invoice(ID_Invoice) VALUES ({invoiceId})";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                foreach (var item in drugInvoiceList)
                {
                    databaseCommand = $"INSERT INTO Drug_of_Invoice(ID_Invoice, ID_Drug, Count) VALUES ({invoiceId}, {item.id}, {item.count})";

                    using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }    
                }

                connection.Close();
            }    
        }
    }
}
