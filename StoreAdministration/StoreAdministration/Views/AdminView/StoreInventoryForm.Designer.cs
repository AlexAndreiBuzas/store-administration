namespace StoreAdministration
{
    partial class StoreInventoryForm
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
            this.manageProductsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageCategoriesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProductQuantityButton = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesHistoryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshProductsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.userManagementButton = new System.Windows.Forms.ToolStripMenuItem();
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
            this.productsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 46);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 82;
            this.productsDataGridView.RowTemplate.Height = 33;
            this.productsDataGridView.Size = new System.Drawing.Size(1628, 960);
            this.productsDataGridView.TabIndex = 0;
            this.productsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentDoubleClick);
            // 
            // manageMenu
            // 
            this.manageMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.manageMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.manageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductsButton,
            this.userManagementButton,
            this.productsSearchTextBox,
            this.refreshProductsButton,
            this.logOutButton});
            this.manageMenu.Location = new System.Drawing.Point(0, 0);
            this.manageMenu.Name = "manageMenu";
            this.manageMenu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.manageMenu.Size = new System.Drawing.Size(1628, 43);
            this.manageMenu.TabIndex = 3;
            this.manageMenu.Text = "menuStrip1";
            // 
            // manageProductsButton
            // 
            this.manageProductsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageCategoriesButton,
            this.addNewProductButton,
            this.modifyProductQuantityButton,
            this.viewSalesHistoryButton});
            this.manageProductsButton.Name = "manageProductsButton";
            this.manageProductsButton.Size = new System.Drawing.Size(220, 39);
            this.manageProductsButton.Text = "Manage Products";
            // 
            // ManageCategoriesButton
            // 
            this.ManageCategoriesButton.Name = "ManageCategoriesButton";
            this.ManageCategoriesButton.Size = new System.Drawing.Size(411, 44);
            this.ManageCategoriesButton.Text = "Manage Categories";
            this.ManageCategoriesButton.Click += new System.EventHandler(this.ManageCategoriesButton_Click);
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(411, 44);
            this.addNewProductButton.Text = "Add New Product";
            this.addNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // modifyProductQuantityButton
            // 
            this.modifyProductQuantityButton.Name = "modifyProductQuantityButton";
            this.modifyProductQuantityButton.Size = new System.Drawing.Size(411, 44);
            this.modifyProductQuantityButton.Text = "Modify Product Quantity";
            this.modifyProductQuantityButton.Click += new System.EventHandler(this.ModifyProductQuantityButton_Click);
            // 
            // viewSalesHistoryButton
            // 
            this.viewSalesHistoryButton.Name = "viewSalesHistoryButton";
            this.viewSalesHistoryButton.Size = new System.Drawing.Size(411, 44);
            this.viewSalesHistoryButton.Text = "View Sales History";
            this.viewSalesHistoryButton.Click += new System.EventHandler(this.viewSalesHistoryButton_Click);
            // 
            // refreshProductsButton
            // 
            this.refreshProductsButton.Name = "refreshProductsButton";
            this.refreshProductsButton.Size = new System.Drawing.Size(212, 39);
            this.refreshProductsButton.Text = "Refresh Products";
            this.refreshProductsButton.Click += new System.EventHandler(this.RefreshProductsButton_Click);
            // 
            // productsSearchTextBox
            // 
            this.productsSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productsSearchTextBox.Name = "productsSearchTextBox";
            this.productsSearchTextBox.Size = new System.Drawing.Size(350, 39);
            this.productsSearchTextBox.TextChanged += new System.EventHandler(this.ProductsSearchTextBox_TextChanged);
            // 
            // userManagementButton
            // 
            this.userManagementButton.Name = "userManagementButton";
            this.userManagementButton.Size = new System.Drawing.Size(231, 39);
            this.userManagementButton.Text = "User Management";
            this.userManagementButton.Click += new System.EventHandler(this.userManagementButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(120, 39);
            this.logOutButton.Text = "Log Out";
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // StoreInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 1017);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.manageMenu);
            this.MainMenuStrip = this.manageMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StoreInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Administration";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.manageMenu.ResumeLayout(false);
            this.manageMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.MenuStrip manageMenu;
        private System.Windows.Forms.ToolStripMenuItem manageProductsButton;
        private System.Windows.Forms.ToolStripMenuItem refreshProductsButton;
        private System.Windows.Forms.ToolStripTextBox productsSearchTextBox;
        private System.Windows.Forms.ToolStripMenuItem addNewProductButton;
        private System.Windows.Forms.ToolStripMenuItem modifyProductQuantityButton;
        private System.Windows.Forms.ToolStripMenuItem ManageCategoriesButton;
        private System.Windows.Forms.ToolStripMenuItem viewSalesHistoryButton;
        private System.Windows.Forms.ToolStripMenuItem userManagementButton;
        private System.Windows.Forms.ToolStripMenuItem logOutButton;
    }
}

