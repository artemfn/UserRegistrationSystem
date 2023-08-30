using System;
using System.Data.Entity;
using System.Windows.Forms;
using UserRegistrationSystem.BL.Data;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.UI
{
    public partial class Catalog<T> : Form
        where T : class, IUser
    {
        private readonly DbProvider<T> _provider;
        private readonly DbSet<T> _set;
        private readonly IUser _userType;


        public Catalog(DbProvider<T> provider, DbSet<T> set, IUser userType)
        {
            InitializeComponent();

            _provider = provider ??
                throw new ArgumentNullException(nameof(provider));
            _set = set ??
                throw new ArgumentNullException(nameof(set));
            _userType = userType ??
                throw new ArgumentNullException(nameof(userType));

            _set.Load();
            DataGridView.DataSource = _set.Local.ToBindingList();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_userType is Admin admin)
            {
                if (_provider is DbProvider<User> usersProvider)
                {
                    new UserRegistrationForm(usersProvider)
                    {
                        IsForRegistration = false
                    }
                    .ShowDialog();
                }
                else if (_provider is DbProvider<Admin> adminsProvider)
                {
                    new AdminRegistrationForm(adminsProvider, admin).ShowDialog();
                }
            }
            else
            {
                Message.Show(MessageType.NotRightRoll);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_userType is Admin)
            {
                var id = DataGridView.SelectedRows[0].Cells[0].Value;

                if (_provider is DbProvider<User> usersProvider)
                {
                    var user = usersProvider.DbContext.Users.Find(id);
                    usersProvider.Delete(user);
                }
                else if (_provider is DbProvider<Admin> adminsProvider)
                {
                    var admin = adminsProvider.DbContext.Admins.Find(id);
                    adminsProvider.Delete(admin);
                }
            }
            else
            {
                Message.Show(MessageType.NotRightRoll);
            }
        }
    }
}
