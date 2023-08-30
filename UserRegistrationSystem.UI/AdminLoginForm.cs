using System.Drawing;
using System.Windows.Forms;
using UserRegistrationSystem.BL.Data;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.UI
{
    public partial class AdminLoginForm : Form
    {
        private readonly DbProvider<Admin> _dbProvider = new DbProvider<Admin>();

        private Admin _currentAdmin;


        public AdminLoginForm()
        {
            InitializeComponent();

            _dbProvider.IsEnabled = true;
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


        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if (IsEmpty(NameTextBox, NameLabel))
                return;
            if (IsEmpty(PasswordTextBox, PasswordLabel))
                return;
            if (IsEmpty(KeyTextBox, KeyLabel))
                return;


            _currentAdmin = _dbProvider.Find(NameTextBox.Text, PasswordTextBox.Text, KeyTextBox.Text);

            if (_currentAdmin != null)
            {
                Hide();
                new MainForm(_dbProvider, _currentAdmin).ShowDialog();
                Close();
            }
            else
            {
                if (Message.Show(MessageType.AdminDidNotFind) == DialogResult.Yes)
                {
                    Hide();
                    new UserLoginForm().ShowDialog();
                    Close();
                }
            }
        }


        private void NameTextBox_Click(object sender, System.EventArgs e)
            => UpdateLabel(NameLabel);

        private void PasswordTextBox_Click(object sender, System.EventArgs e)
            => UpdateLabel(PasswordLabel);

        private void KeyTextBox_Click(object sender, System.EventArgs e)
            => UpdateLabel(KeyLabel);


        private void AdminLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            new UserLoginForm().ShowDialog();
            Close();
        }
    }
}