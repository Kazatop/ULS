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
    
## Заполнение DataTable    
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