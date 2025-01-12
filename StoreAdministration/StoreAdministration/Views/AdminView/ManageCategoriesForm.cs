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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAdministration.Views
{
    public partial class ManageCategoriesForm : Form
    {
        private readonly CategoryController _categoryController;

        public ManageCategoriesForm()
        {
            InitializeComponent();
            _categoryController = new CategoryController(new ApplicationDbContext());
            LoadProductCategories();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");

            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            CategoryNameGroupBox.Text = Localisation.LanguageString.CategoryNameGroupBox;
            saveCategoryButton.Text = Localisation.LanguageString.saveCategoryButton;
            deleteCategory.Text = Localisation.LanguageString.deleteCategory;
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

        private async void SaveCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(productCategoryTextBox.Text))
                {
                    throw new InvalidOperationException("Category name cannot be empty.");
                }

                var category = new ProductCategory
                {
                    Name = productCategoryTextBox.Text
                };

                await _categoryController.AddCategoryAsync(category);

                MessageBox.Show("Category saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void DeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (productCategoryItem.SelectedItem == null)
                {
                    throw new InvalidOperationException("No category selected.");
                }

                var selectedCategory = (dynamic)productCategoryItem.SelectedItem;
                int categoryId = selectedCategory.Id;

                await _categoryController.DeleteCategoryAsync(categoryId);

                MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
