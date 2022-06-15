namespace ULS
{
    partial class StorageAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageAddForm));
            this.HospitalLabel = new System.Windows.Forms.Label();
            this.HospitalComboBox = new System.Windows.Forms.ComboBox();
            this.DrugComboBox = new System.Windows.Forms.ComboBox();
            this.DrugLabel = new System.Windows.Forms.Label();
            this.CountUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HospitalLabel
            // 
            this.HospitalLabel.AutoSize = true;
            this.HospitalLabel.Location = new System.Drawing.Point(13, 13);
            this.HospitalLabel.Name = "HospitalLabel";
            this.HospitalLabel.Size = new System.Drawing.Size(107, 13);
            this.HospitalLabel.TabIndex = 0;
            this.HospitalLabel.Text = "Выберите больницу";
            // 
            // HospitalComboBox
            // 
            this.HospitalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HospitalComboBox.FormattingEnabled = true;
            this.HospitalComboBox.Location = new System.Drawing.Point(16, 30);
            this.HospitalComboBox.Name = "HospitalComboBox";
            this.HospitalComboBox.Size = new System.Drawing.Size(170, 21);
            this.HospitalComboBox.TabIndex = 1;
            // 
            // DrugComboBox
            // 
            this.DrugComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrugComboBox.FormattingEnabled = true;
            this.DrugComboBox.Location = new System.Drawing.Point(192, 29);
            this.DrugComboBox.Name = "DrugComboBox";
            this.DrugComboBox.Size = new System.Drawing.Size(170, 21);
            this.DrugComboBox.TabIndex = 2;
            // 
            // DrugLabel
            // 
            this.DrugLabel.AutoSize = true;
            this.DrugLabel.Location = new System.Drawing.Point(189, 12);
            this.DrugLabel.Name = "DrugLabel";
            this.DrugLabel.Size = new System.Drawing.Size(107, 13);
            this.DrugLabel.TabIndex = 3;
            this.DrugLabel.Text = "Выберите препарат";
            // 
            // CountUpDown
            // 
            this.CountUpDown.Location = new System.Drawing.Point(368, 31);
            this.CountUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CountUpDown.Name = "CountUpDown";
            this.CountUpDown.Size = new System.Drawing.Size(120, 20);
            this.CountUpDown.TabIndex = 4;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(365, 14);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(110, 13);
            this.CountLabel.TabIndex = 5;
            this.CountLabel.Text = "Введите количество";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(413, 57);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.Location = new System.Drawing.Point(332, 57);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(75, 23);
            this.DeclineButton.TabIndex = 7;
            this.DeclineButton.Text = "Отменить";
            this.DeclineButton.UseVisualStyleBackColor = true;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // StorageAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 96);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountUpDown);
            this.Controls.Add(this.DrugLabel);
            this.Controls.Add(this.DrugComboBox);
            this.Controls.Add(this.HospitalComboBox);
            this.Controls.Add(this.HospitalLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StorageAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "УЛСБ: Добавление товара на склад";
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HospitalLabel;
        private System.Windows.Forms.ComboBox HospitalComboBox;
        private System.Windows.Forms.ComboBox DrugComboBox;
        private System.Windows.Forms.Label DrugLabel;
        private System.Windows.Forms.NumericUpDown CountUpDown;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeclineButton;
    }
}