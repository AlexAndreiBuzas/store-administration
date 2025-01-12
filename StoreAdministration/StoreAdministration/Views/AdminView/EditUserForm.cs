using Authentication;
using StoreAdministration.Data;
using System;
using System.Data.Entity;
using System.Threading;
using System.Windows.Forms;

namespace StoreAdministration.Views
{
    public partial class EditUserForm : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly int _userId;
        private readonly PasswordHasher _passwordHasher;

        public EditUserForm(ApplicationDbContext context, int userId)
        {
            InitializeComponent();
            _context = context;
            _userId = userId;
            _passwordHasher = new PasswordHasher();


            roleComboBox.Items.Add("Admin");
            roleComboBox.Items.Add("User");

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");

            ApplyTranslation();
        }

        void ApplyTranslation()
        {
            createUsernameGroupBox.Text = Localisation.LanguageString.createUsernameGroupBox;
            passwordGroupBox.Text = Localisation.LanguageString.passwordGroupBox;
            roleGroupBox.Text = Localisation.LanguageString.roleGroupBox;
            saveButton.Text = Localisation.LanguageString.saveButton;
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
                    roleComboBox.Items.Add(user.Role);
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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                string role = roleComboBox.SelectedItem.ToString();

                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Id != _userId);
                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string hashedPassword = _passwordHasher.HashPassword(passwordTextBox.Text);

                var user = await _context.Users.FindAsync(_userId);
                if (user != null)
                {
                    user.Username = username;
                    user.Password = hashedPassword;
                    user.Role = role;

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
