using StoreAdministration.Controllers;
using StoreAdministration.Data;
using StoreAdministration.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAdministration.Views
{
    public partial class UserManagementForm : Form
    {
        private readonly ApplicationDbContext _context;

        public UserManagementForm(UserController userController)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();

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
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
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
