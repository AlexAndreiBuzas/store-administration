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
using System.Xml.Linq;

namespace StoreAdministration.Views
{
    public partial class SalesHistoryForm : Form
    {
        public SalesHistoryForm()
        {
            InitializeComponent();
            RefreshSalesHistory();
            LanguageManager.LanguageChanged += ApplyTranslation;

            ApplyTranslation();
        }
        private void ApplyTranslation()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(LanguageManager.CurrentLanguage);

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

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshSalesHistory();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
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

        private async void ExportButton_Click(object sender, EventArgs e)
        {
            var controller = new SalesHistoryController(new ApplicationDbContext());
            var salesHistory = await controller.GetSalesHistoryAsync();

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "XML files (*.xml)|*.xml",
                FileName = "SaveSalesHistoryXML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WriteXmlFileLinq(saveFileDialog.FileName, salesHistory);
                MessageBox.Show("Sales history exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WriteXmlFileLinq(string fileName, List<SalesHistory> salesHistory)
        {
            XDocument doc = new XDocument(
                new XElement("SalesHistories",
                    from s in salesHistory
                    select new XElement("SalesHistory",
                        new XAttribute("Id", s.Id),
                        new XElement("ProductId", s.Product?.Id ?? 0),
                        new XElement("ProductName", s.Product?.Name ?? "Unknown Product"),
                        new XElement("Quantity", s.Quantity),
                        new XElement("CategoryName", s.Product?.ProductCategory?.Name ?? "Unknown Category"),
                        new XElement("SaleDate", s.SaleDate?.ToString("o") ?? "No Date")
                    )
                )
            );

            doc.Save(fileName);
        }
    }
}
