using System;
using System.Windows.Forms;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.UI
{
    public partial class AdminProfilePresentingForm : Form
    {
        public AdminProfilePresentingForm(Admin admin)
        {
            InitializeComponent();

            if (admin == null)
                throw new ArgumentNullException(nameof(admin));

            NameLabel.Text = admin.Name;
            PasswordLabel.Text = GetProtectedPassword(admin.Password);
            KeyLabel.Text = admin.IdentificationKey;
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