using System;
using System.Windows.Forms;
using UserRegistrationSystem.BL.Data;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.UI
{
    public partial class MainForm : Form
    {
        private readonly DbProvider<User> _usersProvider;
        private readonly DbProvider<Admin> _adminsProvider;
        private readonly User _currentUser;
        private readonly Admin _currentAdmin;


        public MainForm(DbProvider<User> provider, User user)
        {
            InitializeComponent();

            _adminsProvider = new DbProvider<Admin>();
            _usersProvider = provider ??
                throw new ArgumentNullException(nameof(provider));
            _currentUser = user ??
                throw new ArgumentNullException(nameof(user));
        }

        public MainForm(DbProvider<Admin> provider, Admin admin)
        {
            InitializeComponent();

            _usersProvider = new DbProvider<User>();
            _adminsProvider = provider ??
                throw new ArgumentNullException(nameof(provider));
            _currentAdmin = admin ??
                throw new ArgumentNullException(nameof(admin));
        }


        private IUser GetCurrentActiveUserType()
        {
            if (_currentUser != null)
                return _currentUser;

            if (_currentAdmin != null)
                return _currentAdmin;

            throw new InvalidOperationException();
        }


        private void UsersMenuItem_Click(object sender, EventArgs e)
        {
            new Catalog<User>(_usersProvider, _usersProvider.DbContext.Users, GetCurrentActiveUserType()).Show();
        }

        private void AdminsMenuItem_Click(object sender, EventArgs e)
        {
            new Catalog<Admin>(_adminsProvider, _adminsProvider.DbContext.Admins, GetCurrentActiveUserType()).Show();
        }

        private void ProfileMenu_Click(object sender, EventArgs e)
        {
            if (GetCurrentActiveUserType() is User)
            {
                new UserProfilePresentingForm(_currentUser).Show();
            }
            else if (GetCurrentActiveUserType() is Admin)
            {
                new AdminProfilePresentingForm(_currentAdmin).Show();
            }
        }


        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}