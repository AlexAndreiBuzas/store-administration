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
            this.productNameGroupBox.Location = new System.Drawing.Point(113, 40);
            this.productNameGroupBox.Name = "productNameGroupBox";
            this.productNameGroupBox.Size = new System.Drawing.Size(454, 76);
            this.productNameGroupBox.TabIndex = 0;
            this.productNameGroupBox.TabStop = false;
            this.productNameGroupBox.Text = "Product Name";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(6, 30);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(432, 31);
            this.productNameTextBox.TabIndex = 0;
            // 
            // productDescriptionBox
            // 
            this.productDescriptionBox.Controls.Add(this.productDescriptionTextBox);
            this.productDescriptionBox.Location = new System.Drawing.Point(113, 122);
            this.productDescriptionBox.Name = "productDescriptionBox";
            this.productDescriptionBox.Size = new System.Drawing.Size(454, 182);
            this.productDescriptionBox.TabIndex = 1;
            this.productDescriptionBox.TabStop = false;
            this.productDescriptionBox.Text = "Product Description";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(6, 30);
            this.productDescriptionTextBox.Multiline = true;
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(432, 135);
            this.productDescriptionTextBox.TabIndex = 0;
            // 
            // entryDateGroupBox
            // 
            this.entryDateGroupBox.Controls.Add(this.entryDatePicker);
            this.entryDateGroupBox.Location = new System.Drawing.Point(113, 310);
            this.entryDateGroupBox.Name = "entryDateGroupBox";
            this.entryDateGroupBox.Size = new System.Drawing.Size(454, 81);
            this.entryDateGroupBox.TabIndex = 1;
            this.entryDateGroupBox.TabStop = false;
            this.entryDateGroupBox.Text = "Entry Date";
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.Location = new System.Drawing.Point(6, 31);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(432, 31);
            this.entryDatePicker.TabIndex = 0;
            // 
            // expiryDateGroupBox
            // 
            this.expiryDateGroupBox.Controls.Add(this.expiryDatePicker);
            this.expiryDateGroupBox.Location = new System.Drawing.Point(113, 397);
            this.expiryDateGroupBox.Name = "expiryDateGroupBox";
            this.expiryDateGroupBox.Size = new System.Drawing.Size(454, 81);
            this.expiryDateGroupBox.TabIndex = 2;
            this.expiryDateGroupBox.TabStop = false;
            this.expiryDateGroupBox.Text = "Expiry Date*";
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.Location = new System.Drawing.Point(6, 30);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(432, 31);
            this.expiryDatePicker.TabIndex = 0;
            // 
            // quantityGroupBox
            // 
            this.quantityGroupBox.Controls.Add(this.quantityPiker);
            this.quantityGroupBox.Location = new System.Drawing.Point(113, 484);
            this.quantityGroupBox.Name = "quantityGroupBox";
            this.quantityGroupBox.Size = new System.Drawing.Size(454, 80);
            this.quantityGroupBox.TabIndex = 2;
            this.quantityGroupBox.TabStop = false;
            this.quantityGroupBox.Text = "Quantity";
            // 
            // quantityPiker
            // 
            this.quantityPiker.Location = new System.Drawing.Point(6, 30);
            this.quantityPiker.Name = "quantityPiker";
            this.quantityPiker.Size = new System.Drawing.Size(432, 31);
            this.quantityPiker.TabIndex = 1;
            // 
            // ProductCategoryGroupBox
            // 
            this.ProductCategoryGroupBox.Controls.Add(this.productCategoryItem);
            this.ProductCategoryGroupBox.Location = new System.Drawing.Point(113, 570);
            this.ProductCategoryGroupBox.Name = "ProductCategoryGroupBox";
            this.ProductCategoryGroupBox.Size = new System.Drawing.Size(454, 82);
            this.ProductCategoryGroupBox.TabIndex = 1;
            this.ProductCategoryGroupBox.TabStop = false;
            this.ProductCategoryGroupBox.Text = "Product Category";
            // 
            // productCategoryItem
            // 
            this.productCategoryItem.FormattingEnabled = true;
            this.productCategoryItem.Location = new System.Drawing.Point(6, 30);
            this.productCategoryItem.Name = "productCategoryItem";
            this.productCategoryItem.Size = new System.Drawing.Size(432, 33);
            this.productCategoryItem.TabIndex = 1;
            // 
            // saveProductButton
            // 
            this.saveProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveProductButton.Location = new System.Drawing.Point(113, 667);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(454, 65);
            this.saveProductButton.TabIndex = 3;
            this.saveProductButton.Text = "Save Product";
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(674, 777);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.ProductCategoryGroupBox);
            this.Controls.Add(this.quantityGroupBox);
            this.Controls.Add(this.expiryDateGroupBox);
            this.Controls.Add(this.entryDateGroupBox);
            this.Controls.Add(this.productDescriptionBox);
            this.Controls.Add(this.productNameGroupBox);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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