using StoreAdministration.Controllers;
using StoreAdministration.Data;
using StoreAdministration.Models;
using StoreAdministration.Views.AdminView;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAdministration.Views
{
    public partial class UserManagementForm : Form
    {
        private readonly ApplicationDbContext _context;
        UserController userController = new UserController(new ApplicationDbContext());

        public UserManagementForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();

            LanguageManager.LanguageChanged += ApplyTranslation;

            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(LanguageManager.CurrentLanguage);

            addButton.Text = Localisation.LanguageString.addButton;
            updateButton.Text = Localisation.LanguageString.updateButton;
            deleteButton.Text = Localisation.LanguageString.deleteButton;
            
        }

        private async void UserManagementForm_Load(object sender, EventArgs e)
        {
            await LoadUsers();
        }

        private async Task LoadUsers()
        {
            var users = await Task.Run(() => _context.Users.ToList());

            MessageBox.Show($"Found {users.Count} users.");

            usersDataGridView.DataSource = null;
            usersDataGridView.DataSource = users;
            usersDataGridView.AutoGenerateColumns = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("AddButton clicked.");

            var createUserForm = new CreateUserForm();
            createUserForm.Show();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("UpdateButton clicked.");

            if (usersDataGridView.SelectedRows.Count > 0)
            {
                var selectedUser = usersDataGridView.SelectedRows[0].DataBoundItem as User;
                if (selectedUser != null)
                {
                    var editForm = new EditUserForm(_context, selectedUser.Id);
                    editForm.ShowDialog();
                    await LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("DeleteButton clicked.");

            if (usersDataGridView.SelectedRows.Count > 0)
            {
                var selectedUser = usersDataGridView.SelectedRows[0].DataBoundItem as User;

                if (selectedUser != null)
                {
                    var confirmResult = MessageBox.Show(
                        "Are you sure you want to delete this user?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            using (var context = new ApplicationDbContext())
                            {
                                var userToDelete = await context.Users.FindAsync(selectedUser.Id);
                                if (userToDelete != null)
                                {
                                    context.Users.Remove(userToDelete);
                                    await context.SaveChangesAsync();

                                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("User not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            await LoadUsers();
                        }
                        catch (Exception ex)
                        {
                            Trace.WriteLine($"Failed to delete user: {ex.Message}");
                            MessageBox.Show($"Failed to delete user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected user is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
