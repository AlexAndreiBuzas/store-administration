namespace StoreAdministration.Views.UserView
{
    partial class StoreForm
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
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.manageMenu = new System.Windows.Forms.MenuStrip();
            this.refreshProductsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.logOutButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.manageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowDrop = true;
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 27);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 82;
            this.productsDataGridView.RowTemplate.Height = 33;
            this.productsDataGridView.Size = new System.Drawing.Size(795, 458);
            this.productsDataGridView.TabIndex = 4;
            // 
            // manageMenu
            // 
            this.manageMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.manageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshProductsButton,
            this.productsSearchTextBox,
            this.logOutButton});
            this.manageMenu.Location = new System.Drawing.Point(0, 0);
            this.manageMenu.Name = "manageMenu";
            this.manageMenu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.manageMenu.Size = new System.Drawing.Size(796, 25);
            this.manageMenu.TabIndex = 5;
            this.manageMenu.Text = "menuStrip1";
            // 
            // refreshProductsButton
            // 
            this.refreshProductsButton.Name = "refreshProductsButton";
            this.refreshProductsButton.Size = new System.Drawing.Size(108, 23);
            this.refreshProductsButton.Text = "Refresh Products";
            this.refreshProductsButton.Click += new System.EventHandler(this.refreshProductsButton_Click);
            // 
            // productsSearchTextBox
            // 
            this.productsSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productsSearchTextBox.Name = "productsSearchTextBox";
            this.productsSearchTextBox.Size = new System.Drawing.Size(177, 23);
            // 
            // logOutButton
            // 
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(62, 23);
            this.logOutButton.Text = "Log Out";
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 487);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.manageMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.manageMenu.ResumeLayout(false);
            this.manageMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.MenuStrip manageMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshProductsButton;
        private System.Windows.Forms.ToolStripTextBox productsSearchTextBox;
        private System.Windows.Forms.ToolStripMenuItem logOutButton;
    }
}