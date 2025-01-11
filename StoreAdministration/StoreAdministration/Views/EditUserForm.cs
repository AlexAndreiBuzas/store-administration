using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreAdministration.Data;
using StoreAdministration.Models;

namespace StoreAdministration.Views
{
    public partial class EditUserForm : Form
    {

        private readonly ApplicationDbContext _context;
        private readonly int _userId;
        public EditUserForm(ApplicationDbContext context, int userId)
        {
            InitializeComponent();
            _context = context;
            _userId = userId;
        }

        private async void EditUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                var user = await _context.Users.FindAsync(_userId);
                if (user != null)
                {
                    usernameTextBox.Text = user.Username;
                    passwordTextBox.Text = user.Password;
                    roleTextBox.Text = user.Role;
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await _context.Users.FindAsync(_userId);
                if (user != null)
                {
                    user.Username = usernameTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.Role = roleTextBox.Text;

                    await _context.SaveChangesAsync();

                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
