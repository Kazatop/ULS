namespace ULS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeePostLabel = new System.Windows.Forms.Label();
            this.EmployeePatronymicLabel = new System.Windows.Forms.Label();
            this.EmployeeLastNameLabel = new System.Windows.Forms.Label();
            this.EmployeeFirstNameLabel = new System.Windows.Forms.Label();
            this.EmployeePrivilegesLabel = new System.Windows.Forms.Label();
            this.EmployeeAccountIdLabel = new System.Windows.Forms.Label();
            this.EmployeePictureBox = new System.Windows.Forms.PictureBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.UnactiveInvoicesTabPage = new System.Windows.Forms.TabPage();
            this.ProcessUnactiveInvoiceButton = new System.Windows.Forms.Button();
            this.CreateUnactiveInvoiceButton = new System.Windows.Forms.Button();
            this.UnactiveDrugsInvoiceGridView = new System.Windows.Forms.DataGridView();
            this.UnactiveDrugsInvoiceLabel = new System.Windows.Forms.Label();
            this.UnactiveInvoiceLabel = new System.Windows.Forms.Label();
            this.UnactiveInvoiceGridView = new System.Windows.Forms.DataGridView();
            this.ActiveInvoicesTabPage = new System.Windows.Forms.TabPage();
            this.CompleteActiveInvoiceButton = new System.Windows.Forms.Button();
            this.ActiveDrugsInvoiceGridView = new System.Windows.Forms.DataGridView();
            this.ActiveDrugsInvoiceLabel = new System.Windows.Forms.Label();
            this.ActiveInvoiceLabel = new System.Windows.Forms.Label();
            this.ActiveInvoiceGridView = new System.Windows.Forms.DataGridView();
            this.CompletedInvoicesTabPage = new System.Windows.Forms.TabPage();
            this.CompletedInvoicesReportButton = new System.Windows.Forms.Button();
            this.CompletedDrugsInvoiceGridView = new System.Windows.Forms.DataGridView();
            this.CompletedDrugsInvoiceLabel = new System.Windows.Forms.Label();
            this.CompletedInvoiceLabel = new System.Windows.Forms.Label();
            this.CompletedInvoiceGridView = new System.Windows.Forms.DataGridView();
            this.AllInvoicesTabPage = new System.Windows.Forms.TabPage();
            this.AllInvoicesReportButton = new System.Windows.Forms.Button();
            this.AllDrugsInvoiceGridView = new System.Windows.Forms.DataGridView();
            this.AllDrugsInvoiceLabel = new System.Windows.Forms.Label();
            this.AllInvoiceLabel = new System.Windows.Forms.Label();
            this.AllInvoiceGridView = new System.Windows.Forms.DataGridView();
            this.StorageTabPage = new System.Windows.Forms.TabPage();
            this.StorageReportButton = new System.Windows.Forms.Button();
            this.StorageAddButton = new System.Windows.Forms.Button();
            this.StorageLabel = new System.Windows.Forms.Label();
            this.StorageGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePictureBox)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.UnactiveInvoicesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnactiveDrugsInvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnactiveInvoiceGridView)).BeginInit();
            this.ActiveInvoicesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveDrugsInvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveInvoiceGridView)).BeginInit();
            this.CompletedInvoicesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedDrugsInvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedInvoiceGridView)).BeginInit();
            this.AllInvoicesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllDrugsInvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllInvoiceGridView)).BeginInit();
            this.StorageTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.EmployeePostLabel);
            this.EmployeeGroupBox.Controls.Add(this.EmployeePatronymicLabel);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeLastNameLabel);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeFirstNameLabel);
            this.EmployeeGroupBox.Controls.Add(this.EmployeePrivilegesLabel);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeAccountIdLabel);
            this.EmployeeGroupBox.Controls.Add(this.EmployeePictureBox);
            this.EmployeeGroupBox.Location = new System.Drawing.Point(3, 4);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(514, 168);
            this.EmployeeGroupBox.TabIndex = 0;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "Вы вошли как";
            // 
            // EmployeePostLabel
            // 
            this.EmployeePostLabel.AutoSize = true;
            this.EmployeePostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeePostLabel.Location = new System.Drawing.Point(150, 120);
            this.EmployeePostLabel.Name = "EmployeePostLabel";
            this.EmployeePostLabel.Size = new System.Drawing.Size(103, 20);
            this.EmployeePostLabel.TabIndex = 6;
            this.EmployeePostLabel.Text = "Должность: ";
            // 
            // EmployeePatronymicLabel
            // 
            this.EmployeePatronymicLabel.AutoSize = true;
            this.EmployeePatronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeePatronymicLabel.Location = new System.Drawing.Point(150, 100);
            this.EmployeePatronymicLabel.Name = "EmployeePatronymicLabel";
            this.EmployeePatronymicLabel.Size = new System.Drawing.Size(91, 20);
            this.EmployeePatronymicLabel.TabIndex = 5;
            this.EmployeePatronymicLabel.Text = "Отчество: ";
            // 
            // EmployeeLastNameLabel
            // 
            this.EmployeeLastNameLabel.AutoSize = true;
            this.EmployeeLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeLastNameLabel.Location = new System.Drawing.Point(150, 80);
            this.EmployeeLastNameLabel.Name = "EmployeeLastNameLabel";
            this.EmployeeLastNameLabel.Size = new System.Drawing.Size(48, 20);
            this.EmployeeLastNameLabel.TabIndex = 4;
            this.EmployeeLastNameLabel.Text = "Имя: ";
            // 
            // EmployeeFirstNameLabel
            // 
            this.EmployeeFirstNameLabel.AutoSize = true;
            this.EmployeeFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeFirstNameLabel.Location = new System.Drawing.Point(150, 60);
            this.EmployeeFirstNameLabel.Name = "EmployeeFirstNameLabel";
            this.EmployeeFirstNameLabel.Size = new System.Drawing.Size(89, 20);
            this.EmployeeFirstNameLabel.TabIndex = 3;
            this.EmployeeFirstNameLabel.Text = "Фамилия: ";
            // 
            // EmployeePrivilegesLabel
            // 
            this.EmployeePrivilegesLabel.AutoSize = true;
            this.EmployeePrivilegesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeePrivilegesLabel.Location = new System.Drawing.Point(150, 40);
            this.EmployeePrivilegesLabel.Name = "EmployeePrivilegesLabel";
            this.EmployeePrivilegesLabel.Size = new System.Drawing.Size(109, 20);
            this.EmployeePrivilegesLabel.TabIndex = 2;
            this.EmployeePrivilegesLabel.Text = "Привилегии: ";
            // 
            // EmployeeAccountIdLabel
            // 
            this.EmployeeAccountIdLabel.AutoSize = true;
            this.EmployeeAccountIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeAccountIdLabel.Location = new System.Drawing.Point(150, 20);
            this.EmployeeAccountIdLabel.Name = "EmployeeAccountIdLabel";
            this.EmployeeAccountIdLabel.Size = new System.Drawing.Size(108, 20);
            this.EmployeeAccountIdLabel.TabIndex = 1;
            this.EmployeeAccountIdLabel.Text = "ID Аккаунта: ";
            // 
            // EmployeePictureBox
            // 
            this.EmployeePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeePictureBox.Location = new System.Drawing.Point(6, 20);
            this.EmployeePictureBox.MaximumSize = new System.Drawing.Size(137, 142);
            this.EmployeePictureBox.MinimumSize = new System.Drawing.Size(137, 142);
            this.EmployeePictureBox.Name = "EmployeePictureBox";
            this.EmployeePictureBox.Size = new System.Drawing.Size(137, 142);
            this.EmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePictureBox.TabIndex = 0;
            this.EmployeePictureBox.TabStop = false;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.UnactiveInvoicesTabPage);
            this.MainTabControl.Controls.Add(this.ActiveInvoicesTabPage);
            this.MainTabControl.Controls.Add(this.CompletedInvoicesTabPage);
            this.MainTabControl.Controls.Add(this.AllInvoicesTabPage);
            this.MainTabControl.Controls.Add(this.StorageTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(3, 178);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1050, 428);
            this.MainTabControl.TabIndex = 1;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // UnactiveInvoicesTabPage
            // 
            this.UnactiveInvoicesTabPage.Controls.Add(this.ProcessUnactiveInvoiceButton);
            this.UnactiveInvoicesTabPage.Controls.Add(this.CreateUnactiveInvoiceButton);
            this.UnactiveInvoicesTabPage.Controls.Add(this.UnactiveDrugsInvoiceGridView);
            this.UnactiveInvoicesTabPage.Controls.Add(this.UnactiveDrugsInvoiceLabel);
            this.UnactiveInvoicesTabPage.Controls.Add(this.UnactiveInvoiceLabel);
            this.UnactiveInvoicesTabPage.Controls.Add(this.UnactiveInvoiceGridView);
            this.UnactiveInvoicesTabPage.Location = new System.Drawing.Point(4, 22);
            this.UnactiveInvoicesTabPage.Name = "UnactiveInvoicesTabPage";
            this.UnactiveInvoicesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UnactiveInvoicesTabPage.Size = new System.Drawing.Size(1042, 402);
            this.UnactiveInvoicesTabPage.TabIndex = 0;
            this.UnactiveInvoicesTabPage.Text = "Входящие накладные";
            this.UnactiveInvoicesTabPage.UseVisualStyleBackColor = true;
            // 
            // ProcessUnactiveInvoiceButton
            // 
            this.ProcessUnactiveInvoiceButton.Location = new System.Drawing.Point(898, 73);
            this.ProcessUnactiveInvoiceButton.Name = "ProcessUnactiveInvoiceButton";
            this.ProcessUnactiveInvoiceButton.Size = new System.Drawing.Size(138, 41);
            this.ProcessUnactiveInvoiceButton.TabIndex = 5;
            this.ProcessUnactiveInvoiceButton.Text = "Обработать накладную";
            this.ProcessUnactiveInvoiceButton.UseVisualStyleBackColor = true;
            this.ProcessUnactiveInvoiceButton.Click += new System.EventHandler(this.ProcessUnactiveInvoiceButton_Click);
            // 
            // CreateUnactiveInvoiceButton
            // 
            this.CreateUnactiveInvoiceButton.Location = new System.Drawing.Point(898, 26);
            this.CreateUnactiveInvoiceButton.Name = "CreateUnactiveInvoiceButton";
            this.CreateUnactiveInvoiceButton.Size = new System.Drawing.Size(138, 41);
            this.CreateUnactiveInvoiceButton.TabIndex = 4;
            this.CreateUnactiveInvoiceButton.Text = "Создать накладную";
            this.CreateUnactiveInvoiceButton.UseVisualStyleBackColor = true;
            this.CreateUnactiveInvoiceButton.Click += new System.EventHandler(this.CreateUnactiveInvoiceButton_Click);
            // 
            // UnactiveDrugsInvoiceGridView
            // 
            this.UnactiveDrugsInvoiceGridView.AllowUserToAddRows = false;
            this.UnactiveDrugsInvoiceGridView.AllowUserToDeleteRows = false;
            this.UnactiveDrugsInvoiceGridView.AllowUserToResizeColumns = false;
            this.UnactiveDrugsInvoiceGridView.AllowUserToResizeRows = false;
            this.UnactiveDrugsInvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UnactiveDrugsInvoiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.UnactiveDrugsInvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnactiveDrugsInvoiceGridView.Location = new System.Drawing.Point(458, 26);
            this.UnactiveDrugsInvoiceGridView.MultiSelect = false;
            this.UnactiveDrugsInvoiceGridView.Name = "UnactiveDrugsInvoiceGridView";
            this.UnactiveDrugsInvoiceGridView.ReadOnly = true;
            this.UnactiveDrugsInvoiceGridView.RowHeadersVisible = false;
            this.UnactiveDrugsInvoiceGridView.Size = new System.Drawing.Size(434, 370);
            this.UnactiveDrugsInvoiceGridView.TabIndex = 3;
            // 
            // UnactiveDrugsInvoiceLabel
            // 
            this.UnactiveDrugsInvoiceLabel.AutoSize = true;
            this.UnactiveDrugsInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnactiveDrugsInvoiceLabel.Location = new System.Drawing.Point(454, 3);
            this.UnactiveDrugsInvoiceLabel.Name = "UnactiveDrugsInvoiceLabel";
            this.UnactiveDrugsInvoiceLabel.Size = new System.Drawing.Size(152, 20);
            this.UnactiveDrugsInvoiceLabel.TabIndex = 2;
            this.UnactiveDrugsInvoiceLabel.Text = "Товары накладной";
            // 
            // UnactiveInvoiceLabel
            // 
            this.UnactiveInvoiceLabel.AutoSize = true;
            this.UnactiveInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnactiveInvoiceLabel.Location = new System.Drawing.Point(6, 3);
            this.UnactiveInvoiceLabel.Name = "UnactiveInvoiceLabel";
            this.UnactiveInvoiceLabel.Size = new System.Drawing.Size(176, 20);
            this.UnactiveInvoiceLabel.TabIndex = 1;
            this.UnactiveInvoiceLabel.Text = "Входящие накладные";
            // 
            // UnactiveInvoiceGridView
            // 
            this.UnactiveInvoiceGridView.AllowUserToAddRows = false;
            this.UnactiveInvoiceGridView.AllowUserToDeleteRows = false;
            this.UnactiveInvoiceGridView.AllowUserToResizeColumns = false;
            this.UnactiveInvoiceGridView.AllowUserToResizeRows = false;
            this.UnactiveInvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UnactiveInvoiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.UnactiveInvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnactiveInvoiceGridView.Location = new System.Drawing.Point(7, 26);
            this.UnactiveInvoiceGridView.MultiSelect = false;
            this.UnactiveInvoiceGridView.Name = "UnactiveInvoiceGridView";
            this.UnactiveInvoiceGridView.ReadOnly = true;
            this.UnactiveInvoiceGridView.RowHeadersVisible = false;
            this.UnactiveInvoiceGridView.Size = new System.Drawing.Size(434, 370);
            this.UnactiveInvoiceGridView.TabIndex = 0;
            this.UnactiveInvoiceGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnactiveInvoiceGridView_CellClick);
            // 
            // ActiveInvoicesTabPage
            // 
            this.ActiveInvoicesTabPage.Controls.Add(this.CompleteActiveInvoiceButton);
            this.ActiveInvoicesTabPage.Controls.Add(this.ActiveDrugsInvoiceGridView);
            this.ActiveInvoicesTabPage.Controls.Add(this.ActiveDrugsInvoiceLabel);
            this.ActiveInvoicesTabPage.Controls.Add(this.ActiveInvoiceLabel);
            this.ActiveInvoicesTabPage.Controls.Add(this.ActiveInvoiceGridView);
            this.ActiveInvoicesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ActiveInvoicesTabPage.Name = "ActiveInvoicesTabPage";
            this.ActiveInvoicesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveInvoicesTabPage.Size = new System.Drawing.Size(1042, 402);
            this.ActiveInvoicesTabPage.TabIndex = 1;
            this.ActiveInvoicesTabPage.Text = "Текущие накладные";
            this.ActiveInvoicesTabPage.UseVisualStyleBackColor = true;
            // 
            // CompleteActiveInvoiceButton
            // 
            this.CompleteActiveInvoiceButton.Location = new System.Drawing.Point(898, 26);
            this.CompleteActiveInvoiceButton.Name = "CompleteActiveInvoiceButton";
            this.CompleteActiveInvoiceButton.Size = new System.Drawing.Size(138, 41);
            this.CompleteActiveInvoiceButton.TabIndex = 10;
            this.CompleteActiveInvoiceButton.Text = "Завершить накладную";
            this.CompleteActiveInvoiceButton.UseVisualStyleBackColor = true;
            this.CompleteActiveInvoiceButton.Click += new System.EventHandler(this.CompleteActiveInvoiceButton_Click);
            // 
            // ActiveDrugsInvoiceGridView
            // 
            this.ActiveDrugsInvoiceGridView.AllowUserToAddRows = false;
            this.ActiveDrugsInvoiceGridView.AllowUserToDeleteRows = false;
            this.ActiveDrugsInvoiceGridView.AllowUserToResizeColumns = false;
            this.ActiveDrugsInvoiceGridView.AllowUserToResizeRows = false;
            this.ActiveDrugsInvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActiveDrugsInvoiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.ActiveDrugsInvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveDrugsInvoiceGridView.Location = new System.Drawing.Point(458, 26);
            this.ActiveDrugsInvoiceGridView.MultiSelect = false;
            this.ActiveDrugsInvoiceGridView.Name = "ActiveDrugsInvoiceGridView";
            this.ActiveDrugsInvoiceGridView.ReadOnly = true;
            this.ActiveDrugsInvoiceGridView.RowHeadersVisible = false;
            this.ActiveDrugsInvoiceGridView.Size = new System.Drawing.Size(434, 370);
            this.ActiveDrugsInvoiceGridView.TabIndex = 9;
            // 
            // ActiveDrugsInvoiceLabel
            // 
            this.ActiveDrugsInvoiceLabel.AutoSize = true;
            this.ActiveDrugsInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveDrugsInvoiceLabel.Location = new System.Drawing.Point(454, 3);
            this.ActiveDrugsInvoiceLabel.Name = "ActiveDrugsInvoiceLabel";
            this.ActiveDrugsInvoiceLabel.Size = new System.Drawing.Size(152, 20);
            this.ActiveDrugsInvoiceLabel.TabIndex = 8;
            this.ActiveDrugsInvoiceLabel.Text = "Товары накладной";
            // 
            // ActiveInvoiceLabel
            // 
            this.ActiveInvoiceLabel.AutoSize = true;
            this.ActiveInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveInvoiceLabel.Location = new System.Drawing.Point(6, 3);
            this.ActiveInvoiceLabel.Name = "ActiveInvoiceLabel";
            this.ActiveInvoiceLabel.Size = new System.Drawing.Size(162, 20);
            this.ActiveInvoiceLabel.TabIndex = 7;
            this.ActiveInvoiceLabel.Text = "Текущие накладные";
            // 
            // ActiveInvoiceGridView
            // 
            this.ActiveInvoiceGridView.AllowUserToAddRows = false;
            this.ActiveInvoiceGridView.AllowUserToDeleteRows = false;
            this.ActiveInvoiceGridView.AllowUserToResizeColumns = false;
            this.ActiveInvoiceGridView.AllowUserToResizeRows = false;
            this.ActiveInvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActiveInvoiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.ActiveInvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveInvoiceGridView.Location = new System.Drawing.Point(7, 26);
            this.ActiveInvoiceGridView.MultiSelect = false;
            this.ActiveInvoiceGridView.Name = "ActiveInvoiceGridView";
            this.ActiveInvoiceGridView.ReadOnly = true;
            this.ActiveInvoiceGridView.RowHeadersVisible = false;
            this.ActiveInvoiceGridView.Size = new System.Drawing.Size(434, 370);
            this.ActiveInvoiceGridView.TabIndex = 6;
            this.ActiveInvoiceGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActiveInvoiceGridView_CellClick);
            // 
            // CompletedInvoicesTabPage
            // 
            this.CompletedInvoicesTabPage.Controls.Add(this.CompletedInvoicesReportButton);
            this.CompletedInvoicesTabPage.Controls.Add(this.CompletedDrugsInvoiceGridView);
            this.CompletedInvoicesTabPage.Controls.Add(this.CompletedDrugsInvoiceLabel);
            this.CompletedInvoicesTabPage.Controls.Add(this.CompletedInvoiceLabel);
            this.CompletedInvoicesTabPage.Controls.Add(this.CompletedInvoiceGridView);
            this.CompletedInvoicesTabPage.Location = new System.Drawing.Point(4, 22);
            this.CompletedInvoicesTabPage.Name = "CompletedInvoicesTabPage";
            this.CompletedInvoicesTabPage.Size = new System.Drawing.Size(1042, 402);
            this.CompletedInvoicesTabPage.TabIndex = 4;
            this.CompletedInvoicesTabPage.Text = "Завершённые накладные";
            this.CompletedInvoicesTabPage.UseVisualStyleBackColor = true;
            // 
            // CompletedInvoicesReportButton
            // 
            this.CompletedInvoicesReportButton.Location = new System.Drawing.Point(962, 3);
            this.CompletedInvoicesReportButton.Name = "CompletedInvoicesReportButton";
            this.CompletedInvoicesReportButton.Size = new System.Drawing.Size(75, 21);
            this.CompletedInvoicesReportButton.TabIndex = 8;
            this.CompletedInvoicesReportButton.Text = "Отчёт";
            this.CompletedInvoicesReportButton.UseVisualStyleBackColor = true;
            this.CompletedInvoicesReportButton.Click += new System.EventHandler(this.CompletedInvoicesReportButton_Click);
            // 
            // CompletedDrugsInvoiceGridView
            // 
            this.CompletedDrugsInvoiceGridView.AllowUserToAddRows = false;
            this.CompletedDrugsInvoiceGridView.AllowUserToDeleteRows = false;
            this.CompletedDrugsInvoiceGridView.AllowUserToResizeColumns = false;
            this.CompletedDrugsInvoiceGridView.AllowUserToResizeRows = false;
            this.CompletedDrugsInvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompletedDrugsInvoiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.CompletedDrugsInvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedDrugsInvoiceGridView.Location = new System.Drawing.Point(533, 26);
            this.CompletedDrugsInvoiceGridView.MultiSelect = false;
            this.CompletedDrugsInvoiceGridView.Name = "CompletedDrugsInvoiceGridView";
            this.CompletedDrugsInvoiceGridView.ReadOnly = true;
            this.CompletedDrugsInvoiceGridView.RowHeadersVisible = false;
            this.CompletedDrugsInvoiceGridView.Size = new System.Drawing.Size(503, 370);
            this.CompletedDrugsInvoiceGridView.TabIndex = 7;
            // 
            // CompletedDrugsInvoiceLabel
            // 
            this.CompletedDrugsInvoiceLabel.AutoSize = true;
            this.CompletedDrugsInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompletedDrugsInvoiceLabel.Location = new System.Drawing.Point(529, 3);
            this.CompletedDrugsInvoiceLabel.Name = "CompletedDrugsInvoiceLabel";
            this.CompletedDrugsInvoiceLabel.Size = new System.Drawing.Size(152, 20);
            this.CompletedDrugsInvoiceLabel.TabIndex = 6;
            this.CompletedDrugsInvoiceLabel.Text = "Товары накладной";
            // 
            // CompletedInvoiceLabel
            // 
            this.CompletedInvoiceLabel.AutoSize = true;
            this.CompletedInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompletedInvoiceLabel.Location = new System.Drawing.Point(6, 3);
            this.CompletedInvoiceLabel.Name = "CompletedInvoiceLabel";
            this.CompletedInvoiceLabel.Size = new System.Drawing.Size(205, 20);
            this.CompletedInvoiceLabel.TabIndex = 5;
            this.CompletedInvoiceLabel.Text = "Завершённые накладные";
            // 
            // CompletedInvoiceGridView
            // 
            this.CompletedInvoiceGridView.AllowUserToAddRows = false;
            this.CompletedInvoiceGridView.AllowUserToDeleteRows = false;
            this.CompletedInvoiceGridView.AllowUserToResizeColumns = false;
            this.CompletedInvoiceGridView.AllowUserToResizeRows = false;
            this.CompletedInvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompletedInvoiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.CompletedInvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedInvoiceGridView.Location = new System.Drawing.Point(7, 26);
            this.CompletedInvoiceGridView.MultiSelect = false;
            this.CompletedInvoiceGridView.Name = "CompletedInvoiceGridView";
            this.CompletedInvoiceGridView.ReadOnly = true;
            this.CompletedInvoiceGridView.RowHeadersVisible = false;
            this.CompletedInvoiceGridView.Size = new System.Drawing.Size(503, 370);
            this.CompletedInvoiceGridView.TabIndex = 4;
            this.CompletedInvoiceGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompletedInvoiceGridView_CellClick);
            // 
            // AllInvoicesTabPage
            // 
            this.AllInvoicesTabPage.Controls.Add(this.AllInvoicesReportButton);
            this.AllInvoicesTabPage.Controls.Add(this.AllDrugsInvoiceGridView);
            this.AllInvoicesTabPage.Controls.Add(this.AllDrugsInvoiceLabel);
            this.AllInvoicesTabPage.Controls.Add(this.AllInvoiceLabel);
            this.AllInvoicesTabPage.Controls.Add(this.AllInvoiceGridView);
            this.AllInvoicesTabPage.Location = new System.Drawing.Point(4, 22);
            this.AllInvoicesTabPage.Name = "AllInvoicesTabPage";
            this.AllInvoicesTabPage.Size = new System.Drawing.Size(1042, 402);
            this.AllInvoicesTabPage.TabIndex = 5;
            this.AllInvoicesTabPage.Text = "Все накладные";
            this.AllInvoicesTabPage.UseVisualStyleBackColor = true;
            // 
            // AllInvoicesReportButton
            // 
            this.AllInvoicesReportButton.Location = new System.Drawing.Point(962, 3);
            this.AllInvoicesReportButton.Name = "AllInvoicesReportButton";
            this.AllInvoicesReportButton.Size = new System.Drawing.Size(75, 21);
            this.AllInvoicesReportButton.TabIndex = 9;
            this.AllInvoicesReportButton.Text = "Отчёт";
            this.AllInvoicesReportButton.UseVisualStyleBackColor = true;
            this.AllInvoicesReportButton.Click += new System.EventHandler(this.AllInvoicesReportButton_Click);
            // 
            // AllDrugsInvoiceGridView
            // 
            this.AllDrugsInvoiceGridView.AllowUserToAddRows = false;
            this.AllDrugsInvoiceGridView.AllowUserToDeleteRows = false;
            this.AllDrugsInvoiceGridView.AllowUserToResizeColumns = false;
            this.AllDrugsInvoiceGridView.AllowUserToResizeRows = false;
            this.AllDrugsInvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllDrugsInvoiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.AllDrugsInvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllDrugsInvoiceGridView.Location = new System.Drawing.Point(533, 26);
            this.AllDrugsInvoiceGridView.MultiSelect = false;
            this.AllDrugsInvoiceGridView.Name = "AllDrugsInvoiceGridView";
            this.AllDrugsInvoiceGridView.ReadOnly = true;
            this.AllDrugsInvoiceGridView.RowHeadersVisible = false;
            this.AllDrugsInvoiceGridView.Size = new System.Drawing.Size(503, 370);
            this.AllDrugsInvoiceGridView.TabIndex = 7;
            // 
            // AllDrugsInvoiceLabel
            // 
            this.AllDrugsInvoiceLabel.AutoSize = true;
            this.AllDrugsInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllDrugsInvoiceLabel.Location = new System.Drawing.Point(529, 3);
            this.AllDrugsInvoiceLabel.Name = "AllDrugsInvoiceLabel";
            this.AllDrugsInvoiceLabel.Size = new System.Drawing.Size(152, 20);
            this.AllDrugsInvoiceLabel.TabIndex = 6;
            this.AllDrugsInvoiceLabel.Text = "Товары накладной";
            // 
            // AllInvoiceLabel
            // 
            this.AllInvoiceLabel.AutoSize = true;
            this.AllInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllInvoiceLabel.Location = new System.Drawing.Point(6, 3);
            this.AllInvoiceLabel.Name = "AllInvoiceLabel";
            this.AllInvoiceLabel.Size = new System.Drawing.Size(97, 20);
            this.AllInvoiceLabel.TabIndex = 5;
            this.AllInvoiceLabel.Text = "Накладные";
            // 
            // AllInvoiceGridView
            // 
            this.AllInvoiceGridView.AllowUserToAddRows = false;
            this.AllInvoiceGridView.AllowUserToDeleteRows = false;
            this.AllInvoiceGridView.AllowUserToResizeColumns = false;
            this.AllInvoiceGridView.AllowUserToResizeRows = false;
            this.AllInvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllInvoiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.AllInvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllInvoiceGridView.Location = new System.Drawing.Point(7, 26);
            this.AllInvoiceGridView.MultiSelect = false;
            this.AllInvoiceGridView.Name = "AllInvoiceGridView";
            this.AllInvoiceGridView.ReadOnly = true;
            this.AllInvoiceGridView.RowHeadersVisible = false;
            this.AllInvoiceGridView.Size = new System.Drawing.Size(503, 370);
            this.AllInvoiceGridView.TabIndex = 4;
            this.AllInvoiceGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllInvoiceGridView_CellClick);
            // 
            // StorageTabPage
            // 
            this.StorageTabPage.Controls.Add(this.StorageReportButton);
            this.StorageTabPage.Controls.Add(this.StorageAddButton);
            this.StorageTabPage.Controls.Add(this.StorageLabel);
            this.StorageTabPage.Controls.Add(this.StorageGridView);
            this.StorageTabPage.Location = new System.Drawing.Point(4, 22);
            this.StorageTabPage.Name = "StorageTabPage";
            this.StorageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StorageTabPage.Size = new System.Drawing.Size(1042, 402);
            this.StorageTabPage.TabIndex = 2;
            this.StorageTabPage.Text = "Склад";
            this.StorageTabPage.UseVisualStyleBackColor = true;
            // 
            // StorageReportButton
            // 
            this.StorageReportButton.Location = new System.Drawing.Point(898, 73);
            this.StorageReportButton.Name = "StorageReportButton";
            this.StorageReportButton.Size = new System.Drawing.Size(138, 41);
            this.StorageReportButton.TabIndex = 12;
            this.StorageReportButton.Text = "Отчёт";
            this.StorageReportButton.UseVisualStyleBackColor = true;
            this.StorageReportButton.Click += new System.EventHandler(this.StorageReportButton_Click);
            // 
            // StorageAddButton
            // 
            this.StorageAddButton.Location = new System.Drawing.Point(898, 26);
            this.StorageAddButton.Name = "StorageAddButton";
            this.StorageAddButton.Size = new System.Drawing.Size(138, 41);
            this.StorageAddButton.TabIndex = 11;
            this.StorageAddButton.Text = "Добавить товар";
            this.StorageAddButton.UseVisualStyleBackColor = true;
            this.StorageAddButton.Click += new System.EventHandler(this.StorageAddButton_Click);
            // 
            // StorageLabel
            // 
            this.StorageLabel.AutoSize = true;
            this.StorageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageLabel.Location = new System.Drawing.Point(6, 3);
            this.StorageLabel.Name = "StorageLabel";
            this.StorageLabel.Size = new System.Drawing.Size(58, 20);
            this.StorageLabel.TabIndex = 7;
            this.StorageLabel.Text = "Склад";
            // 
            // StorageGridView
            // 
            this.StorageGridView.AllowUserToAddRows = false;
            this.StorageGridView.AllowUserToDeleteRows = false;
            this.StorageGridView.AllowUserToResizeColumns = false;
            this.StorageGridView.AllowUserToResizeRows = false;
            this.StorageGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StorageGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.StorageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageGridView.Location = new System.Drawing.Point(7, 26);
            this.StorageGridView.MultiSelect = false;
            this.StorageGridView.Name = "StorageGridView";
            this.StorageGridView.ReadOnly = true;
            this.StorageGridView.RowHeadersVisible = false;
            this.StorageGridView.Size = new System.Drawing.Size(885, 370);
            this.StorageGridView.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1055, 618);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.EmployeeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "УЛСБ: Учёт лекарств склада больницы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.EmployeeGroupBox.ResumeLayout(false);
            this.EmployeeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePictureBox)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.UnactiveInvoicesTabPage.ResumeLayout(false);
            this.UnactiveInvoicesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnactiveDrugsInvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnactiveInvoiceGridView)).EndInit();
            this.ActiveInvoicesTabPage.ResumeLayout(false);
            this.ActiveInvoicesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveDrugsInvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveInvoiceGridView)).EndInit();
            this.CompletedInvoicesTabPage.ResumeLayout(false);
            this.CompletedInvoicesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedDrugsInvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedInvoiceGridView)).EndInit();
            this.AllInvoicesTabPage.ResumeLayout(false);
            this.AllInvoicesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllDrugsInvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllInvoiceGridView)).EndInit();
            this.StorageTabPage.ResumeLayout(false);
            this.StorageTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.PictureBox EmployeePictureBox;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage UnactiveInvoicesTabPage;
        private System.Windows.Forms.TabPage ActiveInvoicesTabPage;
        private System.Windows.Forms.Label EmployeeAccountIdLabel;
        private System.Windows.Forms.Label EmployeePostLabel;
        private System.Windows.Forms.Label EmployeePatronymicLabel;
        private System.Windows.Forms.Label EmployeeLastNameLabel;
        private System.Windows.Forms.Label EmployeeFirstNameLabel;
        private System.Windows.Forms.Label EmployeePrivilegesLabel;
        private System.Windows.Forms.TabPage StorageTabPage;
        private System.Windows.Forms.DataGridView UnactiveInvoiceGridView;
        private System.Windows.Forms.Label UnactiveInvoiceLabel;
        private System.Windows.Forms.Label UnactiveDrugsInvoiceLabel;
        private System.Windows.Forms.DataGridView UnactiveDrugsInvoiceGridView;
        private System.Windows.Forms.Button CreateUnactiveInvoiceButton;
        private System.Windows.Forms.Button ProcessUnactiveInvoiceButton;
        private System.Windows.Forms.Button CompleteActiveInvoiceButton;
        private System.Windows.Forms.DataGridView ActiveDrugsInvoiceGridView;
        private System.Windows.Forms.Label ActiveDrugsInvoiceLabel;
        private System.Windows.Forms.Label ActiveInvoiceLabel;
        private System.Windows.Forms.DataGridView ActiveInvoiceGridView;
        private System.Windows.Forms.TabPage CompletedInvoicesTabPage;
        private System.Windows.Forms.DataGridView CompletedDrugsInvoiceGridView;
        private System.Windows.Forms.Label CompletedDrugsInvoiceLabel;
        private System.Windows.Forms.Label CompletedInvoiceLabel;
        private System.Windows.Forms.DataGridView CompletedInvoiceGridView;
        private System.Windows.Forms.TabPage AllInvoicesTabPage;
        private System.Windows.Forms.DataGridView AllDrugsInvoiceGridView;
        private System.Windows.Forms.Label AllDrugsInvoiceLabel;
        private System.Windows.Forms.Label AllInvoiceLabel;
        private System.Windows.Forms.DataGridView AllInvoiceGridView;
        private System.Windows.Forms.Label StorageLabel;
        private System.Windows.Forms.DataGridView StorageGridView;
        private System.Windows.Forms.Button StorageAddButton;
        private System.Windows.Forms.Button CompletedInvoicesReportButton;
        private System.Windows.Forms.Button AllInvoicesReportButton;
        private System.Windows.Forms.Button StorageReportButton;
    }
}

