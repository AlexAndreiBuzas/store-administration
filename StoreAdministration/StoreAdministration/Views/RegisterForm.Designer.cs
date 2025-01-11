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
            this.label1 = new System.Windows.Forms.Label();
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
            this.createUsernameGroupBox.Location = new System.Drawing.Point(98, 78);
            this.createUsernameGroupBox.Name = "createUsernameGroupBox";
            this.createUsernameGroupBox.Size = new System.Drawing.Size(492, 82);
            this.createUsernameGroupBox.TabIndex = 1;
            this.createUsernameGroupBox.TabStop = false;
            this.createUsernameGroupBox.Text = "Create Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(6, 30);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(480, 31);
            this.usernameTextBox.TabIndex = 0;
            // 
            // createPasswordGroupBox
            // 
            this.createPasswordGroupBox.Controls.Add(this.passwordTextBox);
            this.createPasswordGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.createPasswordGroupBox.Location = new System.Drawing.Point(98, 181);
            this.createPasswordGroupBox.Name = "createPasswordGroupBox";
            this.createPasswordGroupBox.Size = new System.Drawing.Size(492, 81);
            this.createPasswordGroupBox.TabIndex = 2;
            this.createPasswordGroupBox.TabStop = false;
            this.createPasswordGroupBox.Text = "Create Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(6, 30);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(480, 31);
            this.passwordTextBox.TabIndex = 0;
            // 
            // confirmPasswordGroupBox
            // 
            this.confirmPasswordGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.confirmPasswordGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.confirmPasswordGroupBox.Location = new System.Drawing.Point(98, 268);
            this.confirmPasswordGroupBox.Name = "confirmPasswordGroupBox";
            this.confirmPasswordGroupBox.Size = new System.Drawing.Size(492, 81);
            this.confirmPasswordGroupBox.TabIndex = 3;
            this.confirmPasswordGroupBox.TabStop = false;
            this.confirmPasswordGroupBox.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(6, 30);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(480, 31);
            this.confirmPasswordTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "If you have an account you can:";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.registerButton.Location = new System.Drawing.Point(98, 377);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(492, 49);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Location = new System.Drawing.Point(98, 466);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(492, 49);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(697, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.confirmPasswordGroupBox);
            this.Controls.Add(this.createPasswordGroupBox);
            this.Controls.Add(this.createUsernameGroupBox);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
    }
}