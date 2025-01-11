using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreAdministration.Controllers;
using StoreAdministration.Data;
using StoreAdministration.Views;

namespace StoreAdministration
{
    public partial class MainForm : Form
    {

        private readonly ApplicationDbContext _context;
        private readonly UserController _userController;
        public MainForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _userController = new UserController(_context);
        }

        private void openUserManagementFormButton_Click(object sender, EventArgs e)
        {
            var userManagementForm = new UserManagementForm(_userController);
            userManagementForm.Show();
        }
    }
}
