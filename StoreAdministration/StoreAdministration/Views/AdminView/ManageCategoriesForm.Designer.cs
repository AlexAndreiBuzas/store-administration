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
            this.CategoryNameGroupBox.Location = new System.Drawing.Point(103, 85);
            this.CategoryNameGroupBox.Name = "CategoryNameGroupBox";
            this.CategoryNameGroupBox.Size = new System.Drawing.Size(454, 76);
            this.CategoryNameGroupBox.TabIndex = 1;
            this.CategoryNameGroupBox.TabStop = false;
            this.CategoryNameGroupBox.Text = "Category Name";
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.Location = new System.Drawing.Point(6, 30);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(432, 31);
            this.productCategoryTextBox.TabIndex = 0;
            // 
            // CategoriesGroupBox
            // 
            this.CategoriesGroupBox.Controls.Add(this.productCategoryItem);
            this.CategoriesGroupBox.Location = new System.Drawing.Point(103, 338);
            this.CategoriesGroupBox.Name = "CategoriesGroupBox";
            this.CategoriesGroupBox.Size = new System.Drawing.Size(454, 82);
            this.CategoriesGroupBox.TabIndex = 2;
            this.CategoriesGroupBox.TabStop = false;
            this.CategoriesGroupBox.Text = "Categories";
            // 
            // productCategoryItem
            // 
            this.productCategoryItem.FormattingEnabled = true;
            this.productCategoryItem.Location = new System.Drawing.Point(6, 30);
            this.productCategoryItem.Name = "productCategoryItem";
            this.productCategoryItem.Size = new System.Drawing.Size(432, 33);
            this.productCategoryItem.TabIndex = 1;
            // 
            // saveCategoryButton
            // 
            this.saveCategoryButton.Location = new System.Drawing.Point(335, 198);
            this.saveCategoryButton.Name = "saveCategoryButton";
            this.saveCategoryButton.Size = new System.Drawing.Size(222, 65);
            this.saveCategoryButton.TabIndex = 4;
            this.saveCategoryButton.Text = "Save Category";
            this.saveCategoryButton.UseVisualStyleBackColor = true;
            this.saveCategoryButton.Click += new System.EventHandler(this.SaveCategoryButton_Click);
            // 
            // deleteCategory
            // 
            this.deleteCategory.Location = new System.Drawing.Point(335, 455);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(222, 65);
            this.deleteCategory.TabIndex = 5;
            this.deleteCategory.Text = "Delete Category";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // ManageCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 532);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.saveCategoryButton);
            this.Controls.Add(this.CategoriesGroupBox);
            this.Controls.Add(this.CategoryNameGroupBox);
            this.Name = "ManageCategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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