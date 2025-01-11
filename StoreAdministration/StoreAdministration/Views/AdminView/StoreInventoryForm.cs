using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreAdministration.Controllers;
using StoreAdministration.Data;
using StoreAdministration.Views;

namespace StoreAdministration
{
    public partial class StoreInventoryForm : Form
    {
        private List<Product> originalProducts;

        public StoreInventoryForm()
        {
            InitializeComponent();
            RefreshProducts();
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

        private void RefreshProductsButton_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private async void ProductsSearchTextBox_TextChanged(object sender, EventArgs e)
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

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();

            addProductForm.ShowDialog();
            RefreshProducts();
        }

        private void ModifyProductQuantityButton_Click(object sender, EventArgs e)
        {
            ModifyQuantityForm modifyQuantityForm = new ModifyQuantityForm();

            modifyQuantityForm.ShowDialog();
            RefreshProducts();
        }
        private void ManageCategoriesButton_Click(object sender, EventArgs e)
        {
            ManageCategoriesForm manageCategoriesForm = new ManageCategoriesForm();

            manageCategoriesForm.ShowDialog();
            RefreshProducts();
        }

        private void productsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedProduct = originalProducts[e.RowIndex];
                SellProductForm sellProductForm = new SellProductForm(selectedProduct);

                sellProductForm.ShowDialog();
                RefreshProducts();
            }
        }

        private void viewSalesHistoryButton_Click(object sender, EventArgs e)
        {
            SalesHistoryForm salesHistoryForm = new SalesHistoryForm();

            salesHistoryForm.ShowDialog();
            RefreshProducts();
        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            var userManagementForm = new UserManagementForm();

            userManagementForm.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var logInForm = new LogInForm();

            logInForm.Show();
            this.Hide();
        }
    }
}
