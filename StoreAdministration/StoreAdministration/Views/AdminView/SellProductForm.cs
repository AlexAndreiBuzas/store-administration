using StoreAdministration.Controllers;
using StoreAdministration.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAdministration.Views
{
    public partial class SellProductForm : Form
    {
        private Product _product;
        private readonly ProductController _productController;
        private readonly SalesHistoryController _salesHistoryController;

        public SellProductForm(Product product)
        {
            InitializeComponent();
            _product = product;
            _productController = new ProductController(new ApplicationDbContext());
            _salesHistoryController = new SalesHistoryController(new ApplicationDbContext());
            UpdateProductDetails();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");

            ApplyTranslation();
        }

        void ApplyTranslation()
        {
            saleCompletionButton.Text = Localisation.LanguageString.saleCompletionButton;
            productNameGroupBox.Text = Localisation.LanguageString.productNameGroupBox;
            productQuantityGroupBox.Text = Localisation.LanguageString.productQuantityGroupBox;
            quantityGroupBox.Text = Localisation.LanguageString.quantityGroupBox;
        }

        private void UpdateProductDetails()
        {
            productNameLabel.Text = _product.Name;
            productQuantityLabel.Text = _product.Quantity.ToString();
            quantityPicker.Maximum = _product.Quantity;
        }

        private async void SaleCompletionButton_Click(object sender, EventArgs e)
        {
            int quantityToSubtract = (int)quantityPicker.Value;

            if (quantityToSubtract > _product.Quantity)
            {
                MessageBox.Show("Cannot subtract more products than are in stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _product.Quantity -= quantityToSubtract;

            if (_product.Quantity == 0)
            {
                await _productController.DeleteProductAsync(_product.Id);
                MessageBox.Show("Product sold out and removed from inventory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await _productController.UpdateProductAsync(_product);
                UpdateProductDetails();
                MessageBox.Show("Sale completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var salesHistory = new SalesHistory
            {
                ProductId = _product.Id,
                Quantity = quantityToSubtract,
                SaleDate = DateTime.Now
            };
            await _salesHistoryController.AddSalesHistoryAsync(salesHistory);

            this.Close();
        }
    }
}
