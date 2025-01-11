﻿namespace StoreAdministration.Views
{
    partial class ModifyQuantityForm
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
            this.ProductCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.productNameItem = new System.Windows.Forms.ComboBox();
            this.newQuantityGroupBox = new System.Windows.Forms.GroupBox();
            this.newQuantityPiker = new System.Windows.Forms.NumericUpDown();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.ProductCategoryGroupBox.SuspendLayout();
            this.newQuantityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newQuantityPiker)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCategoryGroupBox
            // 
            this.ProductCategoryGroupBox.Controls.Add(this.productNameItem);
            this.ProductCategoryGroupBox.Location = new System.Drawing.Point(113, 59);
            this.ProductCategoryGroupBox.Name = "ProductCategoryGroupBox";
            this.ProductCategoryGroupBox.Size = new System.Drawing.Size(454, 82);
            this.ProductCategoryGroupBox.TabIndex = 2;
            this.ProductCategoryGroupBox.TabStop = false;
            this.ProductCategoryGroupBox.Text = "Product Name";
            // 
            // productNameItem
            // 
            this.productNameItem.FormattingEnabled = true;
            this.productNameItem.Location = new System.Drawing.Point(6, 30);
            this.productNameItem.Name = "productNameItem";
            this.productNameItem.Size = new System.Drawing.Size(432, 33);
            this.productNameItem.TabIndex = 1;
            // 
            // newQuantityGroupBox
            // 
            this.newQuantityGroupBox.Controls.Add(this.newQuantityPiker);
            this.newQuantityGroupBox.Location = new System.Drawing.Point(113, 147);
            this.newQuantityGroupBox.Name = "newQuantityGroupBox";
            this.newQuantityGroupBox.Size = new System.Drawing.Size(454, 80);
            this.newQuantityGroupBox.TabIndex = 3;
            this.newQuantityGroupBox.TabStop = false;
            this.newQuantityGroupBox.Text = "New Quantity";
            // 
            // newQuantityPiker
            // 
            this.newQuantityPiker.Location = new System.Drawing.Point(6, 30);
            this.newQuantityPiker.Name = "newQuantityPiker";
            this.newQuantityPiker.Size = new System.Drawing.Size(432, 31);
            this.newQuantityPiker.TabIndex = 1;
            // 
            // saveProductButton
            // 
            this.saveProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveProductButton.Location = new System.Drawing.Point(113, 243);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(454, 65);
            this.saveProductButton.TabIndex = 4;
            this.saveProductButton.Text = "Save Product";
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // ModifyQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 358);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.newQuantityGroupBox);
            this.Controls.Add(this.ProductCategoryGroupBox);
            this.Name = "ModifyQuantityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Quantity";
            this.ProductCategoryGroupBox.ResumeLayout(false);
            this.newQuantityGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newQuantityPiker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductCategoryGroupBox;
        private System.Windows.Forms.ComboBox productNameItem;
        private System.Windows.Forms.GroupBox newQuantityGroupBox;
        private System.Windows.Forms.NumericUpDown newQuantityPiker;
        private System.Windows.Forms.Button saveProductButton;
    }
}