namespace StoreAdministration
{
    partial class MainForm
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
            this.openUserManagementFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openUserManagementFormButton
            // 
            this.openUserManagementFormButton.Location = new System.Drawing.Point(255, 171);
            this.openUserManagementFormButton.Name = "openUserManagementFormButton";
            this.openUserManagementFormButton.Size = new System.Drawing.Size(75, 23);
            this.openUserManagementFormButton.TabIndex = 0;
            this.openUserManagementFormButton.Text = "Users";
            this.openUserManagementFormButton.UseVisualStyleBackColor = true;
            this.openUserManagementFormButton.Click += new System.EventHandler(this.openUserManagementFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 234);
            this.Controls.Add(this.openUserManagementFormButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Store";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openUserManagementFormButton;
    }
}

