namespace StoreAdministration.Views
{
    partial class ManageCategoriesForm
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
            this.CategoryNameGroupBox = new System.Windows.Forms.GroupBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.productCategoryItem = new System.Windows.Forms.ComboBox();
            this.saveCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.CategoryNameGroupBox.SuspendLayout();
            this.CategoriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryNameGroupBox
            // 
            this.CategoryNameGroupBox.Controls.Add(this.productCategoryTextBox);
            this.CategoryNameGroupBox.Location = new System.Drawing.Point(54, 35);
            this.CategoryNameGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryNameGroupBox.Name = "CategoryNameGroupBox";
            this.CategoryNameGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryNameGroupBox.Size = new System.Drawing.Size(227, 40);
            this.CategoryNameGroupBox.TabIndex = 1;
            this.CategoryNameGroupBox.TabStop = false;
            this.CategoryNameGroupBox.Text = "Category Name";
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.Location = new System.Drawing.Point(3, 16);
            this.productCategoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(218, 20);
            this.productCategoryTextBox.TabIndex = 0;
            // 
            // CategoriesGroupBox
            // 
            this.CategoriesGroupBox.Controls.Add(this.productCategoryItem);
            this.CategoriesGroupBox.Location = new System.Drawing.Point(54, 152);
            this.CategoriesGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoriesGroupBox.Name = "CategoriesGroupBox";
            this.CategoriesGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoriesGroupBox.Size = new System.Drawing.Size(227, 43);
            this.CategoriesGroupBox.TabIndex = 2;
            this.CategoriesGroupBox.TabStop = false;
            this.CategoriesGroupBox.Text = "Categories";
            // 
            // productCategoryItem
            // 
            this.productCategoryItem.FormattingEnabled = true;
            this.productCategoryItem.Location = new System.Drawing.Point(3, 16);
            this.productCategoryItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productCategoryItem.Name = "productCategoryItem";
            this.productCategoryItem.Size = new System.Drawing.Size(218, 21);
            this.productCategoryItem.TabIndex = 1;
            // 
            // saveCategoryButton
            // 
            this.saveCategoryButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveCategoryButton.Location = new System.Drawing.Point(54, 83);
            this.saveCategoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveCategoryButton.Name = "saveCategoryButton";
            this.saveCategoryButton.Size = new System.Drawing.Size(227, 34);
            this.saveCategoryButton.TabIndex = 4;
            this.saveCategoryButton.Text = "Save Category";
            this.saveCategoryButton.UseVisualStyleBackColor = false;
            this.saveCategoryButton.Click += new System.EventHandler(this.SaveCategoryButton_Click);
            // 
            // deleteCategory
            // 
            this.deleteCategory.BackColor = System.Drawing.Color.Red;
            this.deleteCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCategory.Location = new System.Drawing.Point(54, 203);
            this.deleteCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(227, 34);
            this.deleteCategory.TabIndex = 5;
            this.deleteCategory.Text = "Delete Category";
            this.deleteCategory.UseVisualStyleBackColor = false;
            this.deleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // ManageCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 277);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.saveCategoryButton);
            this.Controls.Add(this.CategoriesGroupBox);
            this.Controls.Add(this.CategoryNameGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageCategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Categories";
            this.CategoryNameGroupBox.ResumeLayout(false);
            this.CategoryNameGroupBox.PerformLayout();
            this.CategoriesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CategoryNameGroupBox;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.GroupBox CategoriesGroupBox;
        private System.Windows.Forms.ComboBox productCategoryItem;
        private System.Windows.Forms.Button saveCategoryButton;
        private System.Windows.Forms.Button deleteCategory;
    }
}