namespace StoreAdministration.Views
{
    partial class SellProductForm
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productQuantityGroupBox = new System.Windows.Forms.GroupBox();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.quantityGroupBox = new System.Windows.Forms.GroupBox();
            this.quantityPicker = new System.Windows.Forms.NumericUpDown();
            this.saleCompletionButton = new System.Windows.Forms.Button();
            this.productNameGroupBox.SuspendLayout();
            this.productQuantityGroupBox.SuspendLayout();
            this.quantityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameGroupBox
            // 
            this.productNameGroupBox.Controls.Add(this.productNameLabel);
            this.productNameGroupBox.Location = new System.Drawing.Point(107, 52);
            this.productNameGroupBox.Name = "productNameGroupBox";
            this.productNameGroupBox.Size = new System.Drawing.Size(454, 62);
            this.productNameGroupBox.TabIndex = 1;
            this.productNameGroupBox.TabStop = false;
            this.productNameGroupBox.Text = "Product Name";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(6, 27);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(207, 25);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name Label";
            // 
            // productQuantityGroupBox
            // 
            this.productQuantityGroupBox.Controls.Add(this.productQuantityLabel);
            this.productQuantityGroupBox.Location = new System.Drawing.Point(107, 120);
            this.productQuantityGroupBox.Name = "productQuantityGroupBox";
            this.productQuantityGroupBox.Size = new System.Drawing.Size(454, 62);
            this.productQuantityGroupBox.TabIndex = 2;
            this.productQuantityGroupBox.TabStop = false;
            this.productQuantityGroupBox.Text = "Product Quantity";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Location = new System.Drawing.Point(6, 27);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(231, 25);
            this.productQuantityLabel.TabIndex = 0;
            this.productQuantityLabel.Text = "Product Quantity Label";
            // 
            // quantityGroupBox
            // 
            this.quantityGroupBox.Controls.Add(this.quantityPicker);
            this.quantityGroupBox.Location = new System.Drawing.Point(107, 188);
            this.quantityGroupBox.Name = "quantityGroupBox";
            this.quantityGroupBox.Size = new System.Drawing.Size(227, 80);
            this.quantityGroupBox.TabIndex = 3;
            this.quantityGroupBox.TabStop = false;
            this.quantityGroupBox.Text = "Quantity";
            // 
            // quantityPicker
            // 
            this.quantityPicker.Location = new System.Drawing.Point(6, 30);
            this.quantityPicker.Name = "quantityPicker";
            this.quantityPicker.Size = new System.Drawing.Size(202, 31);
            this.quantityPicker.TabIndex = 1;
            // 
            // saleCompletionButton
            // 
            this.saleCompletionButton.Location = new System.Drawing.Point(339, 297);
            this.saleCompletionButton.Name = "saleCompletionButton";
            this.saleCompletionButton.Size = new System.Drawing.Size(222, 65);
            this.saleCompletionButton.TabIndex = 4;
            this.saleCompletionButton.Text = "Sale Completion";
            this.saleCompletionButton.UseVisualStyleBackColor = true;
            this.saleCompletionButton.Click += new System.EventHandler(this.SaleCompletionButton_Click);
            // 
            // SellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 374);
            this.Controls.Add(this.saleCompletionButton);
            this.Controls.Add(this.quantityGroupBox);
            this.Controls.Add(this.productQuantityGroupBox);
            this.Controls.Add(this.productNameGroupBox);
            this.Name = "SellProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sell Product";
            this.productNameGroupBox.ResumeLayout(false);
            this.productNameGroupBox.PerformLayout();
            this.productQuantityGroupBox.ResumeLayout(false);
            this.productQuantityGroupBox.PerformLayout();
            this.quantityGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productNameGroupBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.GroupBox productQuantityGroupBox;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.GroupBox quantityGroupBox;
        private System.Windows.Forms.NumericUpDown quantityPicker;
        private System.Windows.Forms.Button saleCompletionButton;
    }
}