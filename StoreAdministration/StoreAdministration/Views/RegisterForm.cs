using Authentication;
using StoreAdministration.Controllers;
using StoreAdministration.Data;
using StoreAdministration.Models;
using System;
using System.Windows.Forms;

namespace StoreAdministration
{
    public partial class RegisterForm : Form
    {
        private readonly UserController _userController;
        private readonly PasswordHasher _passwordHasher;

        public RegisterForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            _userController = new UserController(dbContext);
            _passwordHasher = new PasswordHasher();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

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
                Role = "User"
            };

            await _userController.AddUserAsync(newUser);

            MessageBox.Show("User registered successfully.");
            var logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }
    }
}
