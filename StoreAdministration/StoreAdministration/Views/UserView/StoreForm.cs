using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreAdministration.Controllers;
using StoreAdministration.Data;

namespace StoreAdministration.Views.UserView
{
    public partial class StoreForm : Form
    {
        private List<Product> originalProducts;

        public StoreForm()
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
        private void refreshProductsButton_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void viewSalesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var logInForm = new LogInForm();

            logInForm.Show();
            this.Hide();
        }
    }
}
