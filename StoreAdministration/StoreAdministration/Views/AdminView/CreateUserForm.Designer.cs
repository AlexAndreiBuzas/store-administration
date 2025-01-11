namespace StoreAdministration.Views.AdminView
{
    partial class CreateUserForm
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
            this.AddUserButton = new System.Windows.Forms.Button();
            this.confirmPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.createUsernameGroupBox = new System.Windows.Forms.GroupBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.roleGroupBox = new System.Windows.Forms.GroupBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.confirmPasswordGroupBox.SuspendLayout();
            this.createPasswordGroupBox.SuspendLayout();
            this.createUsernameGroupBox.SuspendLayout();
            this.roleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddUserButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddUserButton.Location = new System.Drawing.Point(103, 451);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(492, 48);
            this.AddUserButton.TabIndex = 10;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // confirmPasswordGroupBox
            // 
            this.confirmPasswordGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.confirmPasswordGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.confirmPasswordGroupBox.Location = new System.Drawing.Point(103, 263);
            this.confirmPasswordGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordGroupBox.Name = "confirmPasswordGroupBox";
            this.confirmPasswordGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.confirmPasswordGroupBox.Size = new System.Drawing.Size(492, 81);
            this.confirmPasswordGroupBox.TabIndex = 9;
            this.confirmPasswordGroupBox.TabStop = false;
            this.confirmPasswordGroupBox.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(6, 31);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(480, 31);
            this.confirmPasswordTextBox.TabIndex = 0;
            // 
            // createPasswordGroupBox
            // 
            this.createPasswordGroupBox.Controls.Add(this.passwordTextBox);
            this.createPasswordGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.createPasswordGroupBox.Location = new System.Drawing.Point(103, 174);
            this.createPasswordGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.createPasswordGroupBox.Name = "createPasswordGroupBox";
            this.createPasswordGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.createPasswordGroupBox.Size = new System.Drawing.Size(492, 81);
            this.createPasswordGroupBox.TabIndex = 8;
            this.createPasswordGroupBox.TabStop = false;
            this.createPasswordGroupBox.Text = "Create Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(6, 31);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(480, 31);
            this.passwordTextBox.TabIndex = 0;
            // 
            // createUsernameGroupBox
            // 
            this.createUsernameGroupBox.Controls.Add(this.usernameTextBox);
            this.createUsernameGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.createUsernameGroupBox.Location = new System.Drawing.Point(103, 83);
            this.createUsernameGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.createUsernameGroupBox.Name = "createUsernameGroupBox";
            this.createUsernameGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.createUsernameGroupBox.Size = new System.Drawing.Size(492, 83);
            this.createUsernameGroupBox.TabIndex = 7;
            this.createUsernameGroupBox.TabStop = false;
            this.createUsernameGroupBox.Text = "Create Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(6, 31);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(480, 31);
            this.usernameTextBox.TabIndex = 0;
            // 
            // roleGroupBox
            // 
            this.roleGroupBox.Controls.Add(this.roleComboBox);
            this.roleGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.roleGroupBox.Location = new System.Drawing.Point(103, 352);
            this.roleGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.roleGroupBox.Name = "roleGroupBox";
            this.roleGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.roleGroupBox.Size = new System.Drawing.Size(492, 81);
            this.roleGroupBox.TabIndex = 10;
            this.roleGroupBox.TabStop = false;
            this.roleGroupBox.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(7, 31);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(479, 33);
            this.roleComboBox.TabIndex = 1;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 579);
            this.Controls.Add(this.roleGroupBox);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.confirmPasswordGroupBox);
            this.Controls.Add(this.createPasswordGroupBox);
            this.Controls.Add(this.createUsernameGroupBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create User";
            this.confirmPasswordGroupBox.ResumeLayout(false);
            this.confirmPasswordGroupBox.PerformLayout();
            this.createPasswordGroupBox.ResumeLayout(false);
            this.createPasswordGroupBox.PerformLayout();
            this.createUsernameGroupBox.ResumeLayout(false);
            this.createUsernameGroupBox.PerformLayout();
            this.roleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.GroupBox confirmPasswordGroupBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.GroupBox createPasswordGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox createUsernameGroupBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.GroupBox roleGroupBox;
        private System.Windows.Forms.ComboBox roleComboBox;
    }
}