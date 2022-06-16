using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISPharmacy
{
    public static class BaseDate
    {

        public static String ConnectString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PharmacyBD;Integrated Security=True;Connect Timeout=10;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void DisplayAllPreparationData(DataGridView adminDataGrid) {

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();
                DataTable dt = new DataTable();

                String command = "SELECT Preparation.id, Preparation.name AS 'Название', Category.name AS 'Тип', Provider.name AS 'Компания', Preparation.price AS 'Цена', Preparation.count AS 'Наличие на складе' FROM Preparation LEFT JOIN Category ON Preparation.id_Category = Category.id LEFT JOIN Provider ON Preparation.id_Provider = Provider.id";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dt);
                adminDataGrid.DataSource = dt;

                adminDataGrid.Columns[0].Width = 39;
                adminDataGrid.Columns[1].Width = 200;
                adminDataGrid.Columns[2].Width = 200;
                adminDataGrid.Columns[3].Width = 180;
                adminDataGrid.Columns[4].Width = 60;
                adminDataGrid.Columns[5].Width = 80;

                connection.Close();
            }

        }

        public static void DisplayAllPrepTypeData(DataGridView adminDataGrid)
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();
                DataTable dt = new DataTable();
                
                String command = "SELECT Category.id, Category.name as 'Название' FROM Category ";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dt);
                adminDataGrid.DataSource = dt;
                connection.Close();
            }
        }

        public static void DisplayAllWorkerData(DataGridView adminDataGrid)
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();
                DataTable dt = new DataTable();

                String command = "SELECT Worker.id, Worker.firstName as 'Фамилия', Worker.name as 'Имя', Worker.postName as 'Отчество', Worker.phone as 'Номер телефона', Post.Name as 'Должность', Worker.login, Worker.password FROM Worker LEFT JOIN Post ON Post.id = Worker.id_Post";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dt);
                adminDataGrid.DataSource = dt;
                connection.Close();
            }
        }
        public static void DisplayAllClients(DataGridView adminDataGrid)
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();
                DataTable dt = new DataTable();

                String command = "SELECT Client.id AS 'ID Клиента', Client.fullName AS 'Фамилия', Client.name AS 'Имя', Client.postName AS 'Отчество', Client.phone AS 'Номер телефона' FROM Client";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dt);
                adminDataGrid.DataSource = dt;
                connection.Close();
            }
        }

        public static void DisplayAllOrders(DataGridView adminDataGrid) {

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();
                DataTable dt = new DataTable();

                String command = "SELECT Orders.id AS 'ID Заказа', Orders.id_Client AS 'ID Клиента', Preparation.name AS 'Название', Provider.name AS 'Компания', Ready.name AS 'Статус', Orders.count AS 'Кол-во', Orders.price AS 'Цена', Orders.time AS 'Время заказа' FROM Orders LEFT JOIN Preparation ON Preparation.id = Orders.id_Preparation LEFT JOIN Provider ON Provider.id = Orders.id_Provider LEFT JOIN Ready ON Ready.id = Orders.id_Ready";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dt);
                adminDataGrid.DataSource = null;
                adminDataGrid.DataSource = dt;

                adminDataGrid.Columns[0].Width = 66;
                adminDataGrid.Columns[1].Width = 70;
                adminDataGrid.Columns[2].Width = 120;
                adminDataGrid.Columns[3].Width = 140;
                adminDataGrid.Columns[4].Width = 120;
                adminDataGrid.Columns[5].Width = 60;
                adminDataGrid.Columns[5].Width = 40;
                adminDataGrid.Columns[6].Width = 60;
                adminDataGrid.Columns[7].Width = 140;

                connection.Close();
            }
        }

        public static void DisplayAllOrders(DataGridView adminDataGrid, int clientID)
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();
                DataTable dt = new DataTable();

                String command = $"SELECT Orders.id AS 'ID Заказа', Preparation.name AS 'Название', Provider.name AS 'Компания', Ready.name AS 'Статус', Orders.count AS 'Кол-во', Orders.price AS 'Цена', Orders.time AS 'Время заказа' FROM Orders LEFT JOIN Preparation ON Preparation.id = Orders.id_Preparation LEFT JOIN Provider ON Provider.id = Orders.id_Provider LEFT JOIN Ready ON Ready.id = Orders.id_Ready WHERE Orders.id_Client = {clientID}" ;

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(dt);
                adminDataGrid.DataSource = dt;

                adminDataGrid.Columns[0].Width = 66;
                adminDataGrid.Columns[1].Width = 140;
                adminDataGrid.Columns[2].Width = 160;
                adminDataGrid.Columns[3].Width = 120;
                adminDataGrid.Columns[4].Width = 70;
                adminDataGrid.Columns[5].Width = 70;
                adminDataGrid.Columns[6].Width = 140;

                connection.Close();
            }
        }

        public static bool IsStoragePreparation(int id, int count) {

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();

                String strCommand = $"SELECT * FROM Preparation WHERE Preparation.id = {id} AND {count} <= Preparation.count";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader()) {

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

        public static List<SPharmacy> AllProvider()
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                String strCommand = "SELECT * FROM Provider";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    List<SPharmacy> pharmacy = new List<SPharmacy>();

                    while (reader.Read())
                    {
                        SPharmacy _pharmacy = new SPharmacy();

                        _pharmacy.id = Convert.ToInt32(reader["id"]);
                        _pharmacy.name = reader["name"].ToString();
                        _pharmacy.adress = reader["address"].ToString();
                        _pharmacy.phone = reader["phone"].ToString();
                        _pharmacy.email = reader["email"].ToString();

                        pharmacy.Add(_pharmacy);
                    }

                    connection.Close();
                    return pharmacy;
                }
            }
        }
        public static List<string> AllCategory()
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                String strCommand = "SELECT * FROM Category";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    List<string> Category = new List<string>();

                    while (reader.Read())
                    {
                        Category.Add(reader["name"].ToString());
                    }

                    connection.Close();
                    return Category;
                }
            }
        }

        public static List<string> AllWorkerType()
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                String strCommand = "SELECT * FROM Post";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    List<string> Category = new List<string>();

                    while (reader.Read())
                    {
                        Category.Add(reader["name"].ToString());
                    }

                    connection.Close();
                    return Category;
                }
            }
        }

        public static List<SPreparation> AllPreparation()
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                String strCommand = "SELECT Category.id, Preparation.name, Category.name AS 'Category', Provider.name AS 'Provider', Preparation.price FROM Preparation LEFT JOIN Category ON Preparation.id_Category = Category.id LEFT JOIN Provider ON Preparation.id_Provider = Provider.id";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    List<SPreparation> Preparation = new List<SPreparation>();

                    while (reader.Read())
                    {
                        SPreparation _preparation = new SPreparation();

                        _preparation.id = Convert.ToInt32(reader["id"]);
                        _preparation.name = reader["name"].ToString();
                        _preparation.nameCategory = reader["Category"].ToString();
                        _preparation.nameProvider = reader["Provider"].ToString();
                        _preparation.price = Convert.ToInt32(reader["price"]);

                        Preparation.Add(_preparation);
                    }

                    connection.Close();
                    return Preparation;
                }
            }
        }

        public static int ClientId(string phone) {

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();

                String strCommand = "SELECT id FROM Client WHERE Client.phone = '" + phone + "'";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader()) {

                    int id = -1;

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                    }

                    connection.Close();
                    return id;
                }
            }
        }

        public static void AddClient(String firstName, String name, String postName, String phone) {

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Client(fullName, name, postName, phone) VALUES ('" + firstName + "', '" + name + "', '" + postName + "', '" + phone + "')", connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        public static void AddOrder(int clientId, int preparationId, string providerName, int count, int price) {

            int status = 1;

            if( IsStoragePreparation(preparationId, count) )
            {
                DeletePreparationCount(preparationId, count);
            }
            else
            {
                status = 2;
            }

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();

                int providerID = -1;
                string databaseCommand = $"SELECT id FROM Provider WHERE name = '{providerName}'";

                using (SqlCommand cmd = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        providerID = Convert.ToInt32(reader["id"]);
                    }
                }

                var timeNow = DateTime.Now;

                SqlCommand command = new SqlCommand("INSERT INTO Orders(id_Client, id_Preparation, id_Provider, id_Ready, count, time, price) " +
                    $"VALUES ({clientId}, {preparationId}, {providerID}, {status}, {count}, '{timeNow.ToString("yyyy-MM-dd HH:mm:ss")}', {price})", connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddPharmacy(string name, int id_Category, int id_Provider, decimal price, decimal count)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Preparation(name, id_Category, id_Provider, price, count) " +
                        $"VALUES ('{name}', {id_Category}, {id_Provider}, {price}, '{count}')", connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введины данные");
                return;
            } 
            
        }

        public static void AddWorker(string firstName, string name, string postName, string phone, int id_Post, string login, string pass)
        {
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(
                    "INSERT INTO Worker(firstName, name, postName, phone, id_Post, login, password) " +
                    $"VALUES ('{firstName}', '{name}', '{postName}', '{phone}', {id_Post}, '{login}', '{pass}')", connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddPrepType(string name)
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(
                    "INSERT INTO Category(name) " +
                    $"VALUES ('{name}')", connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddPreparationCount(int id, int count)
        {
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                string databaseCommand = $"UPDATE Preparation SET count = count + {count} WHERE id = {id}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }

        public static void UpdatePreparation(string id, string name, int id_Category, int id_Provider, decimal price, decimal count)
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(
                    "UPDATE Preparation " +
                    $"SET name = '{name}', id_Category = {id_Category}, id_Provider = {id_Provider}, price = {price}, count = '{count}' " +
                    $"WHERE id = {id};", connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void UpdatePrepType(string id, string name )
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(
                    "UPDATE Category " +
                    $"SET name = '{name}' " +
                    $"WHERE id = {id};", connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void UpdateWorker(string id, string firstName, string name, string postName, string phone, int id_Post, string login, string pass)
        {
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(
                    "UPDATE Worker " +
                    $"SET firstName = '{firstName}', name = '{name}', postName = '{postName}', phone = '{phone}', id_Post = {id_Post}, login = '{login}', password = '{pass}' " +
                    $"WHERE id = {id};", connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeletePreparation(object id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    id = Convert.ToInt32(id);
                    connection.Open();

                    var command = new SqlCommand($"DELETE FROM Preparation WHERE Preparation.id = {id}", connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить данный товар так как он находится в заказах");
            }
            
        }

        public static void DeletePrepType(string id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {

                    connection.Open();

                    SqlCommand command = new SqlCommand($"DELETE FROM Category WHERE Category.id ='{id}'", connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить тип товара так как он используется в товарах");
            }
            
        }

        public static void DeletePreparationCount(int id, int count)
        {
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                string databaseCommand = $"UPDATE Preparation SET count = count - {count} WHERE id = {id}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }

        public static void DeleteWorker(string id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand($"DELETE FROM Worker WHERE Worker.id ='{id}'", connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeleteOneOrderClient(int id) {

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Orders WHERE Orders.id = " + id, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeleteALLOrderClient(int id) {

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Orders WHERE Orders.id_Client = " + id, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static int getPreparationID(string drugName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                String strCommand = $"SELECT Preparation.id FROM Preparation WHERE Preparation.name = '{drugName}'";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    List<string> Category = new List<string>();

                    while (reader.Read())
                    {
                        return Convert.ToInt32(reader["id"]);
                    }

                }

                connection.Close();
                return -1;
            }
        }

        public static void completeOrder(int id, int count, string drugName)
        {
            int drugID = getPreparationID(drugName);

            if (IsStoragePreparation(drugID, count))
            {
                DeletePreparationCount(drugID, count);
            }
            else
            {
                MessageBox.Show("Не достаточно товара на складе");
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                string databaseCommand = $"UPDATE Orders SET id_Ready = 1 WHERE id = {id}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }

        public static void cancelOrder(int id, int count, string drugName, bool isReady)
        {
            int drugID = getPreparationID(drugName);

            if (!isReady) AddPreparationCount(drugID, count);

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                string databaseCommand = $"UPDATE Orders SET id_Ready = 4 WHERE id = {id}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }

        public static void readyOrder(int id, int count, string drugName)
        {
            int drugID = getPreparationID(drugName);

            if (!IsStoragePreparation(drugID, count))
            {
                MessageBox.Show("Не достаточно товара на складе");
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                string databaseCommand = $"UPDATE Orders SET id_Ready = 3 WHERE id = {id}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }

        public static int WorkerJoin(string login, string password) {

            using (SqlConnection connection = new SqlConnection(ConnectString)) {

                connection.Open();

                String strCommand = "SELECT login, password FROM Worker";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader()) {

                    int i = -1;

                    while (reader.Read())
                    {
                        if (reader["login"].ToString() == login && reader["password"].ToString() == password) {
                            i = 0;
                        }
                    }

                    connection.Close();
                    return i;
                }
            }
        }

        public static int WorkerType(string login)
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                String strCommand = "SELECT id_Post FROM Worker WHERE Worker.login = '" + login + "'";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    int id = -1;

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id_Post"]);
                    }

                    connection.Close();
                    return id;
                }
            }
        }

        public static string WorkerFullName(string login)
        {

            using (SqlConnection connection = new SqlConnection(ConnectString))
            {

                connection.Open();

                String strCommand = "SELECT Worker.firstName, Worker.name, Worker.postName FROM Worker WHERE Worker.login = '" + login + "'";

                using (SqlCommand command = new SqlCommand(strCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        return $"{reader["firstName"]} {reader["name"]} {reader["postName"]}";
                    }

                    connection.Close();
                    return "";
                }
            }
        }

        public static void ChangeConnection(string nameConnection)
        {
            ConnectString = $"Data Source={nameConnection};Initial Catalog=PharmacyBD;Integrated Security=True;Connect Timeout=10;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

    }
}
