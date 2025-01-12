namespace StoreAdministration
{
    partial class RegisterForm
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
            this.createUsernameGroupBox = new System.Windows.Forms.GroupBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.createPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.haveAccount = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.createUsernameGroupBox.SuspendLayout();
            this.createPasswordGroupBox.SuspendLayout();
            this.confirmPasswordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createUsernameGroupBox
            // 
            this.createUsernameGroupBox.Controls.Add(this.usernameTextBox);
            this.createUsernameGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.createUsernameGroupBox.Location = new System.Drawing.Point(49, 41);
            this.createUsernameGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createUsernameGroupBox.Name = "createUsernameGroupBox";
            this.createUsernameGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createUsernameGroupBox.Size = new System.Drawing.Size(246, 43);
            this.createUsernameGroupBox.TabIndex = 1;
            this.createUsernameGroupBox.TabStop = false;
            this.createUsernameGroupBox.Text = "Create Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(3, 16);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(242, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // createPasswordGroupBox
            // 
            this.createPasswordGroupBox.Controls.Add(this.passwordTextBox);
            this.createPasswordGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.createPasswordGroupBox.Location = new System.Drawing.Point(49, 94);
            this.createPasswordGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createPasswordGroupBox.Name = "createPasswordGroupBox";
            this.createPasswordGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createPasswordGroupBox.Size = new System.Drawing.Size(246, 42);
            this.createPasswordGroupBox.TabIndex = 2;
            this.createPasswordGroupBox.TabStop = false;
            this.createPasswordGroupBox.Text = "Create Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(3, 16);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(242, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // confirmPasswordGroupBox
            // 
            this.confirmPasswordGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.confirmPasswordGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.confirmPasswordGroupBox.Location = new System.Drawing.Point(49, 139);
            this.confirmPasswordGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordGroupBox.Name = "confirmPasswordGroupBox";
            this.confirmPasswordGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordGroupBox.Size = new System.Drawing.Size(246, 42);
            this.confirmPasswordGroupBox.TabIndex = 3;
            this.confirmPasswordGroupBox.TabStop = false;
            this.confirmPasswordGroupBox.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(3, 16);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(242, 20);
            this.confirmPasswordTextBox.TabIndex = 0;
            // 
            // haveAccount
            // 
            this.haveAccount.AutoSize = true;
            this.haveAccount.Location = new System.Drawing.Point(50, 228);
            this.haveAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveAccount.Name = "haveAccount";
            this.haveAccount.Size = new System.Drawing.Size(161, 13);
            this.haveAccount.TabIndex = 7;
            this.haveAccount.Text = "If you have an account you can:";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.registerButton.Location = new System.Drawing.Point(49, 196);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(246, 25);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Location = new System.Drawing.Point(49, 242);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(246, 25);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(348, 309);
            this.Controls.Add(this.haveAccount);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.confirmPasswordGroupBox);
            this.Controls.Add(this.createPasswordGroupBox);
            this.Controls.Add(this.createUsernameGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.createUsernameGroupBox.ResumeLayout(false);
            this.createUsernameGroupBox.PerformLayout();
            this.createPasswordGroupBox.ResumeLayout(false);
            this.createPasswordGroupBox.PerformLayout();
            this.confirmPasswordGroupBox.ResumeLayout(false);
            this.confirmPasswordGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox createUsernameGroupBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.GroupBox createPasswordGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox confirmPasswordGroupBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label haveAccount;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
    }
}