using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UserRegistrationSystem.BL.Data;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.UI
{
    public partial class UserLoginForm : Form
    {
        private readonly string _loginHistoryFilePath = "LogInHistory";

        private readonly JsonSerializationProvider<List<NamePasswordPair>> _serializationProvider = new JsonSerializationProvider<List<NamePasswordPair>>();
        private readonly DbProvider<User> _dbProvider = new DbProvider<User>();

        private User _currentUser;


        public UserLoginForm()
        {
            InitializeComponent();

            _dbProvider.IsEnabled = true;

            NameTextBox.Text = _serializationProvider.Load(_loginHistoryFilePath)?.LastOrDefault().Name ?? string.Empty;
            PasswordTextBox.Text = _serializationProvider.Load(_loginHistoryFilePath)?.LastOrDefault().Password ?? string.Empty;
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

        private void UpdateLabel(Label label)
        {
            label.ForeColor = Color.Black;
        }

        private void UpdateCurrentUserData()
        {
            var list = _serializationProvider.Load(_loginHistoryFilePath) ?? new List<NamePasswordPair>();
            {
                new NamePasswordPair()
                {
                    Name = _currentUser.Name,
                    Password = _currentUser.Password
                };
            };

            _serializationProvider.Delete(_loginHistoryFilePath);
            _serializationProvider.Save(list, _loginHistoryFilePath);
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IsEmpty(NameTextBox, NameLabel))
                return;
            if (IsEmpty(PasswordTextBox, PasswordLabel))
                return;


            _currentUser = _dbProvider.Find(NameTextBox.Text, PasswordTextBox.Text);

            if (_currentUser != null)
            {
                Hide();
                new MainForm(_dbProvider, _currentUser).ShowDialog();
                Close();

                UpdateCurrentUserData();
            }
            else
            {
                if (Message.Show(MessageType.UserDidNotFond) == DialogResult.Yes)
                {
                    Hide();
                    new UserRegistrationForm(_dbProvider).ShowDialog();
                    Close();
                }
            }
        }


        private void NewUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new UserRegistrationForm(_dbProvider).ShowDialog();
            Close();
        }

        private void AdminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new AdminLoginForm().ShowDialog();
            Close();
        }


        private void NameTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(NameLabel);

        private void PasswordTextBox_Click(object sender, EventArgs e)
            => UpdateLabel(PasswordLabel);


        private void UserLoginForm_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();
    }
}