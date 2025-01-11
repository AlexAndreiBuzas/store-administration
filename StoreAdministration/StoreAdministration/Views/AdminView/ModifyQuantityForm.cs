using StoreAdministration.Controllers;
using StoreAdministration.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAdministration.Views
{
    public partial class ModifyQuantityForm : Form
    {
        private readonly ProductController _productController;

        public ModifyQuantityForm()
        {
            InitializeComponent();
            _productController = new ProductController(new ApplicationDbContext());
            LoadProducts();
        }

        private async void LoadProducts()
        {
            using (var appDbContext = new ApplicationDbContext())
            {
                var products = await appDbContext.Products
                    .Select(p => new { p.Id, p.Name })
                    .ToListAsync();

                productNameItem.DataSource = products;
                productNameItem.ValueMember = "Id";
                productNameItem.DisplayMember = "Name";
            }
        }

        private async void SaveProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (productNameItem.SelectedValue == null || newQuantityPiker.Value <= 0)
                {
                    throw new InvalidOperationException("Product must be selected and quantity must be greater than zero.");
                }

                int productId = (int)productNameItem.SelectedValue;
                int newQuantity = (int)newQuantityPiker.Value;

                using (var appDbContext = new ApplicationDbContext())
                {
                    var product = await appDbContext.Products.FindAsync(productId);
                    if (product != null)
                    {
                        product.Quantity = newQuantity;
                        await _productController.UpdateProductAsync(product);

                        MessageBox.Show("Product quantity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
