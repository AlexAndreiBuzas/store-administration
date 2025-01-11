﻿namespace StoreAdministration.Views
{
    partial class SalesHistoryForm
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
            this.salesHistoryGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesHistoryGridView
            // 
            this.salesHistoryGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.salesHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesHistoryGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.salesHistoryGridView.Location = new System.Drawing.Point(0, 42);
            this.salesHistoryGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesHistoryGridView.Name = "salesHistoryGridView";
            this.salesHistoryGridView.RowHeadersWidth = 82;
            this.salesHistoryGridView.RowTemplate.Height = 33;
            this.salesHistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.salesHistoryGridView.Size = new System.Drawing.Size(1400, 819);
            this.salesHistoryGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchTextBox,
            this.refreshButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1400, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshButton
            // 
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(174, 44);
            this.refreshButton.Text = "Refresh Sales";
            this.refreshButton.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(396, 39);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // SalesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 873);
            this.Controls.Add(this.salesHistoryGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalesHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales History";
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesHistoryGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshButton;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
    }
}