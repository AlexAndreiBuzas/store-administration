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
using StoreAdministration.Controllers;
using StoreAdministration.Data;

namespace StoreAdministration.Views
{
    public partial class AddProductForm : Form
    {
        private readonly ProductController _productController;

        public AddProductForm()
        {
            InitializeComponent();
            _productController = new ProductController(new ApplicationDbContext());
            LoadProductCategories();
        }


        private async void LoadProductCategories()
        {
            using (var appDbContext = new ApplicationDbContext())
            {
                var categories = await appDbContext.ProductCategories
                    .Select(pc => new { pc.Id, pc.Name })
                    .ToListAsync();

                productCategoryItem.DataSource = categories;
                productCategoryItem.ValueMember = "Id";
                productCategoryItem.DisplayMember = "Name";
            }
        }

        private async void SaveProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(productNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(productDescriptionTextBox.Text) ||
                    entryDatePicker.Value == null || expiryDatePicker.Value == null ||
                    quantityPiker.Value <= 0 || productCategoryItem.SelectedValue == null)
                {
                    throw new InvalidOperationException("One or more controls are not properly initialized or have invalid values.");
                }

                var product = new Product
                {
                    Name = productNameTextBox.Text,
                    Description = productDescriptionTextBox.Text,
                    EntryDate = entryDatePicker.Value,
                    ExpiryDate = expiryDatePicker.Value,
                    Quantity = (int)quantityPiker.Value,
                    CategoryId = (int)productCategoryItem.SelectedValue
                };

                await _productController.AddProductAsync(product);

                MessageBox.Show("Product saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }  
}
