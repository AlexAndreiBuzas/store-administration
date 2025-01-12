namespace StoreAdministration.Views
{
    partial class AddProductForm
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
            this.productNameGroupBox = new System.Windows.Forms.GroupBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionBox = new System.Windows.Forms.GroupBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.entryDateGroupBox = new System.Windows.Forms.GroupBox();
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryDateGroupBox = new System.Windows.Forms.GroupBox();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityGroupBox = new System.Windows.Forms.GroupBox();
            this.quantityPiker = new System.Windows.Forms.NumericUpDown();
            this.ProductCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.productCategoryItem = new System.Windows.Forms.ComboBox();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.productNameGroupBox.SuspendLayout();
            this.productDescriptionBox.SuspendLayout();
            this.entryDateGroupBox.SuspendLayout();
            this.expiryDateGroupBox.SuspendLayout();
            this.quantityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPiker)).BeginInit();
            this.ProductCategoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productNameGroupBox
            // 
            this.productNameGroupBox.Controls.Add(this.productNameTextBox);
            this.productNameGroupBox.Location = new System.Drawing.Point(56, 21);
            this.productNameGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productNameGroupBox.Name = "productNameGroupBox";
            this.productNameGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productNameGroupBox.Size = new System.Drawing.Size(227, 40);
            this.productNameGroupBox.TabIndex = 0;
            this.productNameGroupBox.TabStop = false;
            this.productNameGroupBox.Text = "Product Name";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(3, 16);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.productNameTextBox.TabIndex = 0;
            // 
            // productDescriptionBox
            // 
            this.productDescriptionBox.Controls.Add(this.productDescriptionTextBox);
            this.productDescriptionBox.Location = new System.Drawing.Point(56, 63);
            this.productDescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productDescriptionBox.Name = "productDescriptionBox";
            this.productDescriptionBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productDescriptionBox.Size = new System.Drawing.Size(227, 95);
            this.productDescriptionBox.TabIndex = 1;
            this.productDescriptionBox.TabStop = false;
            this.productDescriptionBox.Text = "Product Description";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(3, 16);
            this.productDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productDescriptionTextBox.Multiline = true;
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(218, 72);
            this.productDescriptionTextBox.TabIndex = 0;
            // 
            // entryDateGroupBox
            // 
            this.entryDateGroupBox.Controls.Add(this.entryDatePicker);
            this.entryDateGroupBox.Location = new System.Drawing.Point(56, 161);
            this.entryDateGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entryDateGroupBox.Name = "entryDateGroupBox";
            this.entryDateGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entryDateGroupBox.Size = new System.Drawing.Size(227, 42);
            this.entryDateGroupBox.TabIndex = 1;
            this.entryDateGroupBox.TabStop = false;
            this.entryDateGroupBox.Text = "Entry Date";
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.Location = new System.Drawing.Point(3, 16);
            this.entryDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(218, 20);
            this.entryDatePicker.TabIndex = 0;
            // 
            // expiryDateGroupBox
            // 
            this.expiryDateGroupBox.Controls.Add(this.expiryDatePicker);
            this.expiryDateGroupBox.Location = new System.Drawing.Point(56, 206);
            this.expiryDateGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expiryDateGroupBox.Name = "expiryDateGroupBox";
            this.expiryDateGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expiryDateGroupBox.Size = new System.Drawing.Size(227, 42);
            this.expiryDateGroupBox.TabIndex = 2;
            this.expiryDateGroupBox.TabStop = false;
            this.expiryDateGroupBox.Text = "Expiry Date*";
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.Location = new System.Drawing.Point(3, 16);
            this.expiryDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(218, 20);
            this.expiryDatePicker.TabIndex = 0;
            // 
            // quantityGroupBox
            // 
            this.quantityGroupBox.Controls.Add(this.quantityPiker);
            this.quantityGroupBox.Location = new System.Drawing.Point(56, 252);
            this.quantityGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityGroupBox.Name = "quantityGroupBox";
            this.quantityGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityGroupBox.Size = new System.Drawing.Size(227, 42);
            this.quantityGroupBox.TabIndex = 2;
            this.quantityGroupBox.TabStop = false;
            this.quantityGroupBox.Text = "Quantity";
            // 
            // quantityPiker
            // 
            this.quantityPiker.Location = new System.Drawing.Point(3, 16);
            this.quantityPiker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityPiker.Name = "quantityPiker";
            this.quantityPiker.Size = new System.Drawing.Size(216, 20);
            this.quantityPiker.TabIndex = 1;
            // 
            // ProductCategoryGroupBox
            // 
            this.ProductCategoryGroupBox.Controls.Add(this.productCategoryItem);
            this.ProductCategoryGroupBox.Location = new System.Drawing.Point(56, 296);
            this.ProductCategoryGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductCategoryGroupBox.Name = "ProductCategoryGroupBox";
            this.ProductCategoryGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductCategoryGroupBox.Size = new System.Drawing.Size(227, 43);
            this.ProductCategoryGroupBox.TabIndex = 1;
            this.ProductCategoryGroupBox.TabStop = false;
            this.ProductCategoryGroupBox.Text = "Product Category";
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
            // saveProductButton
            // 
            this.saveProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveProductButton.Location = new System.Drawing.Point(56, 347);
            this.saveProductButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(227, 34);
            this.saveProductButton.TabIndex = 3;
            this.saveProductButton.Text = "Save Product";
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(337, 404);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.ProductCategoryGroupBox);
            this.Controls.Add(this.quantityGroupBox);
            this.Controls.Add(this.expiryDateGroupBox);
            this.Controls.Add(this.entryDateGroupBox);
            this.Controls.Add(this.productDescriptionBox);
            this.Controls.Add(this.productNameGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.productNameGroupBox.ResumeLayout(false);
            this.productNameGroupBox.PerformLayout();
            this.productDescriptionBox.ResumeLayout(false);
            this.productDescriptionBox.PerformLayout();
            this.entryDateGroupBox.ResumeLayout(false);
            this.expiryDateGroupBox.ResumeLayout(false);
            this.quantityGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityPiker)).EndInit();
            this.ProductCategoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productNameGroupBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.GroupBox productDescriptionBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.GroupBox entryDateGroupBox;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private System.Windows.Forms.GroupBox expiryDateGroupBox;
        private System.Windows.Forms.DateTimePicker expiryDatePicker;
        private System.Windows.Forms.GroupBox quantityGroupBox;
        private System.Windows.Forms.NumericUpDown quantityPiker;
        private System.Windows.Forms.GroupBox ProductCategoryGroupBox;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.ComboBox productCategoryItem;
    }
}