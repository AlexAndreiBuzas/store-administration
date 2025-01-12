using StoreAdministration.Controllers;
using StoreAdministration.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace StoreAdministration.Views.UserView
{
    public partial class StoreForm : Form
    {
        private List<Product> originalProducts;

        public StoreForm()
        {
            InitializeComponent();
            RefreshProducts();

            this.FormClosing += RegisterForm_FormClosing;

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");

            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            refreshProductsButton.Text = Localisation.LanguageString.refreshProductsButton;
            logOutButton.Text = Localisation.LanguageString.logOutButton;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void RefreshProducts()
        {
            var controller = new ProductController(new ApplicationDbContext());
            originalProducts = await controller.GetProductsAsync();

            if (productsDataGridView != null)
            {
                var productData = originalProducts.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Description,
                    p.EntryDate,
                    p.ExpiryDate,
                    p.Quantity,
                    CategoryName = p.ProductCategory.Name
                }).ToList();

                if (productsDataGridView.InvokeRequired)
                {
                    productsDataGridView.Invoke(new Action(() =>
                    {
                        productsDataGridView.DataSource = productData;
                    }));
                }
                else
                {
                    productsDataGridView.DataSource = productData;
                }
            }
            else
            {
                MessageBox.Show("Products DataGridView is not initialized.");
            }
        }
        private void refreshProductsButton_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var logInForm = new LogInForm();

            logInForm.Show();
            this.Hide();
        }

        private async void productsSearchTextBox_TextChangedAsync(object sender, EventArgs e)
        {
            var controller = new ProductController(new ApplicationDbContext());
            var products = await controller.GetProductsAsync();
            var searchText = productsSearchTextBox?.Text?.ToLower();

            var filteredProducts = products.Where(p =>
                p != null &&
                (p.Name.ToLower().Contains(searchText) ||
                p.ProductCategory.Name.ToLower().Contains(searchText) ||
                p.Id.ToString().Contains(searchText) ||
                p.Quantity.ToString().Contains(searchText) ||
                p.EntryDate.HasValue && p.EntryDate.Value.ToString("d").Contains(searchText) ||
                p.ExpiryDate.HasValue && p.ExpiryDate.Value.ToString("d").Contains(searchText))).ToList();

            if (productsDataGridView != null)
            {
                if (productsDataGridView.InvokeRequired)
                {
                    productsDataGridView.Invoke(new Action(() =>
                    {
                        productsDataGridView.DataSource = filteredProducts.Select(p => new
                        {
                            p.Id,
                            p.Name,
                            p.Description,
                            p.EntryDate,
                            p.ExpiryDate,
                            p.Quantity,
                            CategoryName = p.ProductCategory.Name
                        }).ToList();
                    }));
                }
                else
                {
                    productsDataGridView.DataSource = filteredProducts.Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Description,
                        p.EntryDate,
                        p.ExpiryDate,
                        p.Quantity,
                        CategoryName = p.ProductCategory.Name
                    }).ToList();
                }
            }
            else
            {
                MessageBox.Show("Products DataGridView is not initialized.");
            }
        }

        private void productsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedProduct = originalProducts[e.RowIndex];
                var sellProductForm = new BuyProductForm(selectedProduct);

                sellProductForm.ShowDialog();
                RefreshProducts();
            }
        }
    }
}
