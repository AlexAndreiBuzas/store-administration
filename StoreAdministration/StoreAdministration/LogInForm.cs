using System;
using System.Windows.Forms;
using Authentication;
using StoreAdministration.Controllers;
using StoreAdministration.Data;
using StoreAdministration.Views.UserView;

namespace StoreAdministration
{
    public partial class LogInForm : Form
    {
        private readonly UserController _userController;
        private readonly PasswordHasher _passwordHasher;

        public LogInForm()
        {
            InitializeComponent();

            var dbContext = new ApplicationDbContext();
            _userController = new UserController(dbContext);
            _passwordHasher = new PasswordHasher();

            this.FormClosing += RegisterForm_FormClosing;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            var user = await _userController.GetUserByUsernameAsync(username);

            if (user != null)
            {
                if (_passwordHasher.VerifyPassword(password, user.Password))
                {
                    MessageBox.Show("Login successful.");

                    if (user.Role == "Admin")
                    {
                        var storeInventoryForm = new StoreInventoryForm();
                        storeInventoryForm.Show();
                    }
                    else if (user.Role == "User")
                    {
                        var storeForm = new StoreForm();
                        storeForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid password.");
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
