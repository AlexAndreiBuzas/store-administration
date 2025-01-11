using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authentication;
using StoreAdministration.Controllers;
using StoreAdministration.Data;
using StoreAdministration.Models;

namespace StoreAdministration.Views.AdminView
{
    public partial class CreateUserForm : Form
    {
        private readonly UserController _userController;
        private readonly PasswordHasher _passwordHasher;

        public CreateUserForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            _userController = new UserController(dbContext);
            _passwordHasher = new PasswordHasher();
        }

        private async void AddUserButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string role = roleTextBox.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            var user = await _userController.GetUserByUsernameAsync(username);
            if (user != null)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            string hashedPassword = _passwordHasher.HashPassword(password);

            var newUser = new User
            {
                Username = username,
                Password = hashedPassword,
                Role = role
            };

            await _userController.AddUserAsync(newUser);

            MessageBox.Show("User registered successfully.");
  
        }
    }
}
