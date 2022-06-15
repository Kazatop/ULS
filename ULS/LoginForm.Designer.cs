namespace ULS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.PasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginMenuStrip = new System.Windows.Forms.MenuStrip();
            this.подключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПроверитьПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ИзменитьПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPictureBox)).BeginInit();
            this.LoginMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(40, 37);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(236, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(40, 67);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(236, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoginPictureBox.Image")));
            this.LoginPictureBox.Location = new System.Drawing.Point(13, 37);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(21, 20);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPictureBox.TabIndex = 2;
            this.LoginPictureBox.TabStop = false;
            // 
            // PasswordPictureBox
            // 
            this.PasswordPictureBox.Image = global::ULS.Properties.Resources.padlock;
            this.PasswordPictureBox.Location = new System.Drawing.Point(13, 67);
            this.PasswordPictureBox.Name = "PasswordPictureBox";
            this.PasswordPictureBox.Size = new System.Drawing.Size(21, 20);
            this.PasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordPictureBox.TabIndex = 3;
            this.PasswordPictureBox.TabStop = false;
            // 
            // LoginMenuStrip
            // 
            this.LoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеToolStripMenuItem});
            this.LoginMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.LoginMenuStrip.Name = "LoginMenuStrip";
            this.LoginMenuStrip.Size = new System.Drawing.Size(304, 24);
            this.LoginMenuStrip.TabIndex = 4;
            this.LoginMenuStrip.Text = "menuStrip1";
            // 
            // подключениеToolStripMenuItem
            // 
            this.подключениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ПроверитьПодключениеToolStripMenuItem,
            this.ИзменитьПодключениеToolStripMenuItem});
            this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
            this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.подключениеToolStripMenuItem.Text = "Подключение";
            // 
            // ПроверитьПодключениеToolStripMenuItem
            // 
            this.ПроверитьПодключениеToolStripMenuItem.Name = "ПроверитьПодключениеToolStripMenuItem";
            this.ПроверитьПодключениеToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ПроверитьПодключениеToolStripMenuItem.Text = "Проверить подключение";
            this.ПроверитьПодключениеToolStripMenuItem.Click += new System.EventHandler(this.ПроверитьПодключениеToolStripMenuItem_Click);
            // 
            // ИзменитьПодключениеToolStripMenuItem
            // 
            this.ИзменитьПодключениеToolStripMenuItem.Name = "ИзменитьПодключениеToolStripMenuItem";
            this.ИзменитьПодключениеToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ИзменитьПодключениеToolStripMenuItem.Text = "Изменить подключение";
            this.ИзменитьПодключениеToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьПодключениеToolStripMenuItem_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(201, 93);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.AutoSize = true;
            this.PasswordCheckBox.Location = new System.Drawing.Point(40, 97);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.PasswordCheckBox.TabIndex = 6;
            this.PasswordCheckBox.Text = "Показать пароль";
            this.PasswordCheckBox.UseVisualStyleBackColor = true;
            this.PasswordCheckBox.CheckedChanged += new System.EventHandler(this.PasswordCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(304, 129);
            this.Controls.Add(this.PasswordCheckBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordPictureBox);
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.LoginMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "УЛСБ: Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPictureBox)).EndInit();
            this.LoginMenuStrip.ResumeLayout(false);
            this.LoginMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox LoginPictureBox;
        private System.Windows.Forms.PictureBox PasswordPictureBox;
        private System.Windows.Forms.MenuStrip LoginMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem подключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПроверитьПодключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ИзменитьПодключениеToolStripMenuItem;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox PasswordCheckBox;
    }
}