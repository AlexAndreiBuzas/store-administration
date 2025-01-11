namespace StoreAdministration
{
    partial class LogInForm
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
            this.usernameGroupBox = new System.Windows.Forms.GroupBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameGroupBox.SuspendLayout();
            this.passwordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameGroupBox
            // 
            this.usernameGroupBox.Controls.Add(this.usernameTextBox);
            this.usernameGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.usernameGroupBox.Location = new System.Drawing.Point(103, 79);
            this.usernameGroupBox.Name = "usernameGroupBox";
            this.usernameGroupBox.Size = new System.Drawing.Size(492, 82);
            this.usernameGroupBox.TabIndex = 0;
            this.usernameGroupBox.TabStop = false;
            this.usernameGroupBox.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(6, 30);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(480, 31);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.passwordTextBox);
            this.passwordGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordGroupBox.Location = new System.Drawing.Point(103, 176);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(492, 82);
            this.passwordGroupBox.TabIndex = 1;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(6, 30);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(480, 31);
            this.passwordTextBox.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(103, 276);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(492, 49);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerButton.Location = new System.Drawing.Point(103, 365);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(492, 49);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "If you don\'t have an account you can:";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.usernameGroupBox);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.usernameGroupBox.ResumeLayout(false);
            this.usernameGroupBox.PerformLayout();
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox usernameGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
    }
}

