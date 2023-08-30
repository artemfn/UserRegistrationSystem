using System;
using System.Windows.Forms;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.UI
{
    public partial class UserProfilePresentingForm : Form
    {
        public UserProfilePresentingForm(User user)
        {
            InitializeComponent();

            if (user == null )
                throw new ArgumentNullException(nameof(user));


            NameLabel.Text = user.Name;
            PasswordLabel.Text = GetProtectedPassword(user.Password);
            EmailLabel.Text = user.Email;
            PhoneNumberLabel.Text = user.PhoneNumber;
            BirthDateLabel.Text = user.BirthDate;
        }


        private string GetProtectedPassword(string password)
        {
            var length = password.Length;
            var protectiveStartPoint = length / 2;
            var protectedPassword = password.Substring(0, protectiveStartPoint);

            for (int i = protectiveStartPoint; i < length; i++)
            {
                protectedPassword += "*";
            }

            return protectedPassword;
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms[nameof(MainForm)].Hide();
            new UserLoginForm().ShowDialog();
        }
    }
}