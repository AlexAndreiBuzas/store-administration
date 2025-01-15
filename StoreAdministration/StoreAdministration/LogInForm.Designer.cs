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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.englishLanguageButton = new System.Windows.Forms.ToolStripButton();
            this.romanianLanguageButton = new System.Windows.Forms.ToolStripButton();
            this.usernameGroupBox.SuspendLayout();
            this.passwordGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameGroupBox
            // 
            this.usernameGroupBox.Controls.Add(this.usernameTextBox);
            this.usernameGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.usernameGroupBox.Location = new System.Drawing.Point(52, 41);
            this.usernameGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameGroupBox.Name = "usernameGroupBox";
            this.usernameGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameGroupBox.Size = new System.Drawing.Size(246, 43);
            this.usernameGroupBox.TabIndex = 0;
            this.usernameGroupBox.TabStop = false;
            this.usernameGroupBox.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(3, 16);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(242, 20);
            this.usernameTextBox.TabIndex = 0;
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
            this.passwordGroupBox.TabIndex = 1;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Password";
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
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(52, 144);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(246, 25);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerButton.Location = new System.Drawing.Point(52, 190);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(246, 25);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "If you don\'t have an account you can:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishLanguageButton,
            this.romanianLanguageButton});
            this.toolStrip1.Location = new System.Drawing.Point(316, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(32, 246);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // englishLanguageButton
            // 
            this.englishLanguageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.englishLanguageButton.Image = global::StoreAdministration.Properties.Resources._197374;
            this.englishLanguageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.englishLanguageButton.Name = "englishLanguageButton";
            this.englishLanguageButton.Size = new System.Drawing.Size(29, 20);
            this.englishLanguageButton.Text = "toolStripButton1";
            this.englishLanguageButton.Click += new System.EventHandler(this.englishLanguageButton_Click);
            // 
            // romanianLanguageButton
            // 
            this.romanianLanguageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.romanianLanguageButton.Image = global::StoreAdministration.Properties.Resources._4855777;
            this.romanianLanguageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.romanianLanguageButton.Name = "romanianLanguageButton";
            this.romanianLanguageButton.Size = new System.Drawing.Size(29, 20);
            this.romanianLanguageButton.Text = "toolStripButton2";
            this.romanianLanguageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.romanianLanguageButton.Click += new System.EventHandler(this.romanianLanguageButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 246);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.usernameGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.usernameGroupBox.ResumeLayout(false);
            this.usernameGroupBox.PerformLayout();
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton englishLanguageButton;
        private System.Windows.Forms.ToolStripButton romanianLanguageButton;
    }
}

