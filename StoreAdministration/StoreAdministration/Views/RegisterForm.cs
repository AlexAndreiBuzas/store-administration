using Authentication;
using StoreAdministration.Controllers;
using StoreAdministration.Data;
using StoreAdministration.Models;
using System;
using System.Threading;
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

            this.FormClosing += RegisterForm_FormClosing;

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");

            ApplyTranslation();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ApplyTranslation()
        {
            createPasswordGroupBox.Text = Localisation.LanguageString.createPasswordGroupBox;
            createUsernameGroupBox.Text = Localisation.LanguageString.createUsernameGroupBox;
            confirmPasswordGroupBox.Text = Localisation.LanguageString.confirmPasswordGroupBox;
            registerButton.Text = Localisation.LanguageString.registerButton;
            loginButton.Text = Localisation.LanguageString.loginButton;
            haveAccount.Text = Localisation.LanguageString.haveAccount;
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
