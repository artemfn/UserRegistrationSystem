using System.Windows.Forms;
using System;
using UserRegistrationSystem.BL.Data;
using UserRegistrationSystem.BL.Model;
using System.Drawing;

namespace UserRegistrationSystem.UI
{
    public partial class AdminRegistrationForm : Form
    {
        private readonly DbProvider<Admin> _provider;
        private readonly Admin _currentAdmin;
        private readonly string _currentKey;


        public AdminRegistrationForm(DbProvider<Admin> provider, Admin admin)
        {
            InitializeComponent();

            _provider = provider ??
                throw new ArgumentNullException(nameof(provider));
            _currentAdmin = admin ??
                throw new ArgumentNullException(nameof(admin));

            _currentKey = Guid.NewGuid().ToString().Substring(0, 7);
            KeyTextBox.Text = _currentKey;
        }


        private bool IsEmpty(TextBox checkedTextBox, Label changedLabel)
        {
            if (string.IsNullOrEmpty(checkedTextBox.Text))
            {
                changedLabel.ForeColor = Color.Red;
                return true;
            }

            return false;
        }

        public void UpdateLabel(Label label)
        {
            label.ForeColor = Color.Black;
        }


        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (IsEmpty(NameTextBox, NameLabel))
                return;
            if (IsEmpty(PasswordTextBox, PasswordLabel))
                return;
            if (IsEmpty(AdminKeyTextBox, AdminKeyLabel))
                return;


            if (AdminKeyTextBox.Text != _currentAdmin.IdentificationKey)
            {
                Message.Show(MessageType.NotRightKey);
                return;
            }

            
            _provider.Save(new Admin()
            {
                Name = NameTextBox.Text,
                Password = PasswordTextBox.Text,
                IdentificationKey = _currentKey
            });


            Close();
        }


        private void NameTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(NameLabel);

        private void PasswordTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(PasswordLabel);

        private void KeyTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(KeyLabel);

        private void AdminKeyTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(AdminKeyLabel);

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
            => KeyTextBox.Text = _currentKey;
    }
}
