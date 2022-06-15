namespace ULS
{
    partial class InvoiceCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceCreationForm));
            this.HospitalComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DrugsListBox = new System.Windows.Forms.ListBox();
            this.HospitalLabel = new System.Windows.Forms.Label();
            this.DrugSelectionLabel = new System.Windows.Forms.Label();
            this.DrugComboBox = new System.Windows.Forms.ComboBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HospitalComboBox
            // 
            this.HospitalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HospitalComboBox.FormattingEnabled = true;
            this.HospitalComboBox.Location = new System.Drawing.Point(15, 29);
            this.HospitalComboBox.Name = "HospitalComboBox";
            this.HospitalComboBox.Size = new System.Drawing.Size(247, 21);
            this.HospitalComboBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(268, 68);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.Location = new System.Drawing.Point(187, 236);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(75, 23);
            this.DeclineButton.TabIndex = 3;
            this.DeclineButton.Text = "Отменить";
            this.DeclineButton.UseVisualStyleBackColor = true;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(268, 236);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DrugsListBox
            // 
            this.DrugsListBox.FormattingEnabled = true;
            this.DrugsListBox.Location = new System.Drawing.Point(15, 96);
            this.DrugsListBox.Name = "DrugsListBox";
            this.DrugsListBox.Size = new System.Drawing.Size(328, 134);
            this.DrugsListBox.TabIndex = 5;
            // 
            // HospitalLabel
            // 
            this.HospitalLabel.AutoSize = true;
            this.HospitalLabel.Location = new System.Drawing.Point(12, 13);
            this.HospitalLabel.Name = "HospitalLabel";
            this.HospitalLabel.Size = new System.Drawing.Size(107, 13);
            this.HospitalLabel.TabIndex = 7;
            this.HospitalLabel.Text = "Выберите больницу";
            // 
            // DrugSelectionLabel
            // 
            this.DrugSelectionLabel.AutoSize = true;
            this.DrugSelectionLabel.Location = new System.Drawing.Point(12, 53);
            this.DrugSelectionLabel.Name = "DrugSelectionLabel";
            this.DrugSelectionLabel.Size = new System.Drawing.Size(107, 13);
            this.DrugSelectionLabel.TabIndex = 8;
            this.DrugSelectionLabel.Text = "Выберите препарат";
            // 
            // DrugComboBox
            // 
            this.DrugComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrugComboBox.FormattingEnabled = true;
            this.DrugComboBox.Location = new System.Drawing.Point(15, 69);
            this.DrugComboBox.Name = "DrugComboBox";
            this.DrugComboBox.Size = new System.Drawing.Size(121, 21);
            this.DrugComboBox.TabIndex = 9;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(139, 53);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(119, 13);
            this.CountLabel.TabIndex = 10;
            this.CountLabel.Text = "Напишите количество";
            // 
            // CountUpDown
            // 
            this.CountUpDown.Location = new System.Drawing.Point(142, 69);
            this.CountUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CountUpDown.Name = "CountUpDown";
            this.CountUpDown.Size = new System.Drawing.Size(120, 20);
            this.CountUpDown.TabIndex = 11;
            // 
            // InvoiceCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(357, 270);
            this.Controls.Add(this.CountUpDown);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.DrugComboBox);
            this.Controls.Add(this.DrugSelectionLabel);
            this.Controls.Add(this.HospitalLabel);
            this.Controls.Add(this.DrugsListBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HospitalComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "УЛСБ: Создать накладную";
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HospitalComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ListBox DrugsListBox;
        private System.Windows.Forms.Label HospitalLabel;
        private System.Windows.Forms.Label DrugSelectionLabel;
        private System.Windows.Forms.ComboBox DrugComboBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.NumericUpDown CountUpDown;
    }
}