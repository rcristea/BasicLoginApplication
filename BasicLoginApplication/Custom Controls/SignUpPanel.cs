using System;
using System.Windows.Forms;

namespace BasicLoginApplication.Custom_Controls {
    public partial class SignUpPanel : UserControl {
        public SignUpPanel() {
            InitializeComponent();
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxShowPassword.Checked) {
                textBoxCuePassword1.PasswordChar = '\0';
                textBoxCuePassword2.PasswordChar = '\0';
            }
            else {
                textBoxCuePassword1.PasswordChar = '●';
                textBoxCuePassword2.PasswordChar = '●';
            }
        }

        private void textBoxCueEmail_MouseDown(object sender, MouseEventArgs e) {
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        private void textBoxCueUsername_MouseDown(object sender, MouseEventArgs e) {
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        private void textBoxCuePassword1_MouseDown(object sender, MouseEventArgs e) {
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        private void textBoxCuePassword2_MouseDown(object sender, MouseEventArgs e) {
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        private bool passwordsMatch() {
            return textBoxCuePassword1.Text == textBoxCuePassword2.Text;
        }

        public void showInvalidEmail(bool invalid) {
            if (invalid) labelInvalidEmail.Show();
            else labelInvalidEmail.Hide();
        }

        public void showUsernameTaken(bool invalid) {
            if (invalid) labelUsernameTaken.Show();
            else labelUsernameTaken.Hide();
        }

        public void showInvalidPassword(bool invalid) {
            if (invalid) labelInvalidPassword.Show();
            else labelInvalidPassword.Hide();
        }

        public void showPasswordMatch() {
            if (textBoxCuePassword1 != textBoxCuePassword2) {
                labelPasswordDoesNotMatch.Show();
            } else {
                labelPasswordDoesNotMatch.Hide();
            }
        }

        public string getEmail() {
            return textBoxCueEmail.Text;
        }

        public string getUsername() {
            return textBoxCueUsername.Text;
        }

        public string getPassword() {
            return passwordsMatch() ? textBoxCuePassword1.Text : null;
        }
    }
}
