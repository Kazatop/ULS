namespace ULS
{
    partial class ChangeConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeConnectionForm));
            this.ChangeConnectionTextBox = new System.Windows.Forms.TextBox();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeConnectionTextBox
            // 
            this.ChangeConnectionTextBox.Location = new System.Drawing.Point(12, 12);
            this.ChangeConnectionTextBox.Name = "ChangeConnectionTextBox";
            this.ChangeConnectionTextBox.Size = new System.Drawing.Size(356, 20);
            this.ChangeConnectionTextBox.TabIndex = 0;
            // 
            // DeclineButton
            // 
            this.DeclineButton.Location = new System.Drawing.Point(211, 41);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(75, 23);
            this.DeclineButton.TabIndex = 2;
            this.DeclineButton.Text = "Отмена";
            this.DeclineButton.UseVisualStyleBackColor = true;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(293, 41);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Применить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ChangeConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(381, 76);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.ChangeConnectionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "УЛСБ: Изменение подключения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChangeConnectionTextBox;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}