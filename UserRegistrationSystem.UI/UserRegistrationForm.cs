using System.Windows.Forms;
using System;
using UserRegistrationSystem.BL.Model;
using System.Drawing;
using UserRegistrationSystem.BL.Data;
using System.Collections.Generic;

namespace UserRegistrationSystem.UI
{
    public partial class UserRegistrationForm : Form
    {
        private readonly DbProvider<User> _dbProvider;


        public UserRegistrationForm(DbProvider<User> provider)
        {
            InitializeComponent();

            _dbProvider = provider ??
                throw new ArgumentNullException(nameof(provider));

            IsForRegistration = true;
        }


        public bool IsForRegistration { get; set; }


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
            if (IsEmpty(EmailTextBox, EmailLabel) || !EmailTextBox.Text.Contains("@"))
                return;
            if (IsEmpty(PhoneNumberTextBox, PhoneNumberLabel) || PhoneNumberTextBox.Text.Length != 10)
                return;
            if (IsEmpty(BirthDateTextBox, BirthDateLabel))
                return;
            if (PhoneNumberTextBox.Text.Length != 10)
            {
                PhoneNumberLabel.ForeColor = Color.Red;
                return;
            }
            if (!DateTime.TryParse(BirthDateTextBox.Text, out DateTime date))
            {
                BirthDateLabel.ForeColor = Color.Red;
                return;
            }


            var user = new User()
            {
                Name = NameTextBox.Text,
                Password = PasswordTextBox.Text,
                Email = EmailTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                BirthDate = date.ToString()
            };

            _dbProvider.Save(user);


            Hide();
            if (IsForRegistration)
                new MainForm(_dbProvider, user).ShowDialog();
            Close();
        }


        private void NameTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(NameLabel);

        private void PasswordTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(PasswordLabel);

        private void EmailTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(EmailLabel);

        private void PhoneNumberTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(PhoneNumberLabel);

        private void BirthDateTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(BirthDateLabel);


        private void UserRegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsForRegistration)
            {
                Hide();
                new UserLoginForm().ShowDialog();
                Close();
            }
        }
    }
}