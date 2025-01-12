namespace StoreAdministration.Views
{
    partial class EditUserForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.createUsernameGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.roleGroupBox = new System.Windows.Forms.GroupBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.createUsernameGroupBox.SuspendLayout();
            this.passwordGroupBox.SuspendLayout();
            this.roleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(5, 16);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(238, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(62, 40);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(64, 101);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordLabel.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(5, 17);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(238, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(52, 196);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(246, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // createUsernameGroupBox
            // 
            this.createUsernameGroupBox.Controls.Add(this.usernameTextBox);
            this.createUsernameGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.createUsernameGroupBox.Location = new System.Drawing.Point(52, 40);
            this.createUsernameGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createUsernameGroupBox.Name = "createUsernameGroupBox";
            this.createUsernameGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createUsernameGroupBox.Size = new System.Drawing.Size(246, 43);
            this.createUsernameGroupBox.TabIndex = 8;
            this.createUsernameGroupBox.TabStop = false;
            this.createUsernameGroupBox.Text = "Username";
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.passwordTextBox);
            this.passwordGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordGroupBox.Location = new System.Drawing.Point(52, 92);
            this.passwordGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordGroupBox.Size = new System.Drawing.Size(246, 43);
            this.passwordGroupBox.TabIndex = 9;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Password";
            // 
            // roleGroupBox
            // 
            this.roleGroupBox.Controls.Add(this.roleComboBox);
            this.roleGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.roleGroupBox.Location = new System.Drawing.Point(52, 143);
            this.roleGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleGroupBox.Name = "roleGroupBox";
            this.roleGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleGroupBox.Size = new System.Drawing.Size(246, 42);
            this.roleGroupBox.TabIndex = 11;
            this.roleGroupBox.TabStop = false;
            this.roleGroupBox.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(4, 16);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(240, 21);
            this.roleComboBox.TabIndex = 1;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 257);
            this.Controls.Add(this.roleGroupBox);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.createUsernameGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.createUsernameGroupBox.ResumeLayout(false);
            this.createUsernameGroupBox.PerformLayout();
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.roleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox createUsernameGroupBox;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.GroupBox roleGroupBox;
        private System.Windows.Forms.ComboBox roleComboBox;
    }
}