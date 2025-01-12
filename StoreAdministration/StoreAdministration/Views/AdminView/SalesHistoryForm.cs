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
    public partial class SalesHistoryForm : Form
    {
        public SalesHistoryForm()
        {
            InitializeComponent();
            RefreshSalesHistory();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");

            ApplyTranslation();
        }
        private void ApplyTranslation()
        {
            refreshButton.Text = Localisation.LanguageString.refreshButton;
        }

        private async void RefreshSalesHistory()
        {
            var controller = new SalesHistoryController(new ApplicationDbContext());
            var salesHistory = await controller.GetSalesHistoryAsync();

            if (salesHistoryGridView != null)
            {
                if (salesHistoryGridView.InvokeRequired)
                {
                    salesHistoryGridView.Invoke(new Action(() =>
                    {
                        salesHistoryGridView.DataSource = salesHistory.Select(s => new
                        {
                            s.Id,
                            ProductId = s.Product.Id,
                            ProductName = s.Product.Name,
                            s.Quantity,
                            CategoryName = s.Product.ProductCategory.Name,
                            s.SaleDate
                        }).ToList();
                    }));
                }
                else
                {
                    salesHistoryGridView.DataSource = salesHistory.Select(s => new
                    {
                        s.Id,
                        ProductId = s.Product?.Id ?? 0,
                        ProductName = s.Product?.Name ?? "Unknown Product",
                        s.Quantity,
                        CategoryName = s.Product?.ProductCategory?.Name ?? "Unknown Category",
                        s.SaleDate
                    }).ToList();
                }
            }
            else
            {
                MessageBox.Show("Sales History DataGridView is not initialized.");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshSalesHistory();
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var controller = new SalesHistoryController(new ApplicationDbContext());
            var salesHistory = await controller.GetSalesHistoryAsync();
            var searchText = searchTextBox?.Text?.ToLower();

            var filteredSalesHistory = salesHistory.Where(s =>
                s.Product != null &&
                (s.Product.Name.ToLower().Contains(searchText) ||
                s.Product.ProductCategory.Name.ToLower().Contains(searchText) ||
                s.Product.Id.ToString().Contains(searchText) ||
                s.Quantity.ToString().Contains(searchText) ||
                s.SaleDate.HasValue && s.SaleDate.Value.ToString("d").Contains(searchText))).ToList();

            if (salesHistoryGridView != null)
            {
                if (salesHistoryGridView.InvokeRequired)
                {
                    salesHistoryGridView.Invoke(new Action(() =>
                    {
                        salesHistoryGridView.DataSource = filteredSalesHistory.Select(s => new
                        {
                            s.Id,
                            ProductId = s.Product.Id,
                            ProductName = s.Product.Name,
                            s.Quantity,
                            CategoryName = s.Product.ProductCategory.Name,
                            s.SaleDate
                        }).ToList();
                    }));
                }
                else
                {
                    salesHistoryGridView.DataSource = filteredSalesHistory.Select(s => new
                    {
                        s.Id,
                        ProductId = s.Product.Id,
                        ProductName = s.Product.Name,
                        s.Quantity,
                        CategoryName = s.Product.ProductCategory.Name,
                        s.SaleDate
                    }).ToList();
                }
            }
            else
            {
                MessageBox.Show("Sales History DataGridView is not initialized.");
            }
        }
    }
}
