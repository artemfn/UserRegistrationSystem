using System.Windows.Forms;
using System;

namespace UserRegistrationSystem.UI
{
    public static class Message
    {
        private const string LOGINMESSAGETITTLE = "Log in";
        private const string REGISTRATIONMESSAGETITTLE = "Registration";
        private const string CATALOGTITTLEMESSAGE = "Catalog";
        private const string USERDIDNOTFINDMESSAGE = "User did not find! Would you like to add new user?";
        private const string ADMINDIDNOTFINDMESSAGE = "Admin did not find! Would you like to log in as user?";
        private const string NOTRIGHTIDENTIFICATIONKEYMESSAGE = "You need to enter your identification key to registrate new admin!";
        private const string NOTRIGHTROLLMESSAGE = "You need to be admin to use this function";


        public static DialogResult Show(MessageType type)
        {
            if (type == MessageType.UserDidNotFond)
                return MessageBox.Show(USERDIDNOTFINDMESSAGE, LOGINMESSAGETITTLE,
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            else if (type == MessageType.AdminDidNotFind)
                return MessageBox.Show(ADMINDIDNOTFINDMESSAGE, LOGINMESSAGETITTLE,
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            else if (type == MessageType.NotRightKey)
                return MessageBox.Show(NOTRIGHTIDENTIFICATIONKEYMESSAGE, REGISTRATIONMESSAGETITTLE,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (type == MessageType.NotRightRoll)
                return MessageBox.Show(NOTRIGHTROLLMESSAGE, CATALOGTITTLEMESSAGE,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            throw new ArgumentException(nameof(type));
        }
    }
}