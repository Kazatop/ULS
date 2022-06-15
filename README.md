# ULS - Учёт лекарств склада больницы

**Описание**:  Программа для учёта лекарств больницы. Имеет возможность авторизации, просмотра позиций, добавления этих же позиций 

  - **Технологический стек**: Indicate the technological nature of the software, including primary programming language(s) and whether the software is intended as standalone or as a module in a framework or other ecosystem.
  - **Статус**:  Alpha, Beta, 1.1, etc. It's OK to write a sentence, too. The goal is to let interested people know where this project is at. This is also a good place to link to the [CHANGELOG](CHANGELOG.md).
  - **Ссылка на продукт или демо-экземпляр**
  - Describe what sets this apart from related-projects. Linking to another doc or page is OK if this can't be expressed in a sentence or two.


**Скриншот рабочего окна приложения**: If the software has visual components, place a screenshot after the description; e.g.,

![](https://raw.githubusercontent.com/cfpb/open-source-project-template/main/screenshot.png)


## Зависимости

Опишите все зависимости, которые должны быть установлены для работы этого программного обеспечения.
Сюда входят языки программирования, базы данных или другие механизмы хранения, инструменты сборки, фреймворки и так далее.
Если требуются определенные версии другого программного обеспечения или известно, что они не работают, сообщите об этом.
_Желательно, отразить диаграмму размещения, компонентов или классов_

## Установка

Подробные инструкции по установке, настройке и запуску проекта (необходимо для проверки работоспособности кода).
В качестве альтернативы можно указать ссылку на отдельный документ [INSTALL](INSTALL.md).

## Конфигурация

Если программное обеспечение требует настройки, подробно опишите его здесь или в другой документации, по ссылке.

## Применение

Как использовать ПО

## Проверка ПО

Если программное обеспечение включает автоматизированные тесты, подробно опишите, как запускать эти тесты.

## Проблемы

Задокументируйте любые известные существенные недостатки программного обеспечения.

## Получение справочной информации

Опишите, как получить помощь с этим программным обеспечением (это могут быть ссылки на систему отслеживания проблем, вики, список рассылки и т. д.)

**Другое**

Если у вас есть вопросы, проблемы, отчеты об ошибках и т. д., сообщите о проблеме в системе отслеживания проблем этого репозитория.

## Приглашение к сотрудничеству

В этом разделе должно быть представлены предложения по дальнейшему развитию проекта, или описаны ключевые задачи, на которых в настоящее время реализуются или проектируются; например, обращение о отправке отзывах о функциях, предложения по исправлению определенных ошибок, участие в создании важных частей и т. д.


----

## Open source licensing info
1. [TERMS](TERMS.md)
2. [LICENSE](LICENSE)
3. [CFPB Source Code Policy](https://github.com/cfpb/source-code-policy/)


----

## Источники и справочники
перечислите
1. Проекты, которые вас вдохновили
2. Связанные проекты
3. Книги, статьи, доклады или другие источники, которые повлияли на создание проекта.

## База данных
    public static class Database
    {
        public static string connectionPath = @"Data Source=localhost;Initial Catalog=ULS;Integrated Security=True"; //Переменная подключения
        public static int accountId;

        public static void ChangeConnectionPath(string newSource)
        {
            connectionPath = $"Data Source={newSource};Initial Catalog=ULS;Integrated Security=True";
        }

        public static bool LoginConfirmation(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath)) //Использование подключения
            {
                connection.Open();

                string databaseCommand = "SELECT Login, Password, ID FROM Accounts"; //Создание команды

                using (SqlCommand command = new SqlCommand(databaseCommand, connection)) //Инициализация команды
                using (SqlDataReader reader = command.ExecuteReader()) //Инициализация ридера
                {
                    bool confirm = false;

                    while (reader.Read()) //Обязательное чтение, иначе работать не будет
                    {
                        if (reader["Login"].ToString() == login && reader["Password"].ToString() == password) //Чтение
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
    }
    
## Заполнение DataTable    
    public static void DisplayAllUnactiveInvoices(DataGridView dataGrid) //Получение ссылки на таблицу для обратной отправки заполненой
    {
        using (SqlConnection connection = new SqlConnection(connectionPath))
        {
            connection.Open();
            DataTable dataTable = new DataTable(); //Создание таблицы для заполнения

            string command = "SELECT Invoice.ID AS Номер, ID_Invoice AS 'Номер накладной', Date AS Дата FROM Unactive_Invoice, Invoice WHERE Unactive_Invoice.ID = Invoice.ID";

            SqlDataAdapter adapter = new SqlDataAdapter(command, connection); //Создание адаптера
            adapter.Fill(dataTable); //Заполнение таблицы адаптером
            dataGrid.DataSource = dataTable; //Присвоение ссылки таблицей на заполненную
            connection.Close();
        }
    }
    
## Получения списка больниц
    public static List<string> HospitalNames() //Создание списка
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
        
## Инициализация списка
    Employee employee = Database.EmployeeGetInformation();

## Создание класса / структуры для списка
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string patronymic;
        public string photoPath;
        public string privileges;
        public string post;
    }
    
## Создание отчёта в Excel
    public class ExportMicrosoftOffice
    {
        public static void ExportExcel(DataGridView dataGrid, DataGridView dataGrid2)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            //worksheet.Select();

            worksheet.Name = "Накладные";
            for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.Sheets.Add();
            worksheet = workbook.Sheets["Лист2"];
            worksheet.Name = "Позиции накладной";

            for (int i = 1; i < dataGrid2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGrid2.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGrid2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid2.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGrid2.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
    
## Код для импорта ID с сервисов и клиентов
    USE Database
    INSERT INTO ClientService (ClientID, ServiceID, StartTime)
    SELECT client.ID, service.ID, НазваниеТаблицы.[DateTime] FROM НазваниеТаблицы, [Client] c, [Service] s
    WHERE НазваниеТаблицы.[Service]=s.Title AND НазваниеТаблицы.client=c.FirstName


    USE Database
    INSERT INTO ClientService(ClientID, ServiceID, StartTime)
    SELECT Client.ID, Service.ID, Sheet1$.StartTime FROM Client, Service, Sheet1$ 
    WHERE Sheet1$.Client = Client.FirstName AND Sheet1$.Service = Service.Title