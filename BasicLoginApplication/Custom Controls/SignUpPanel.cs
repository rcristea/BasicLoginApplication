using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void textBoxCuePassword2_TextChanged(object sender, EventArgs e) {
            if (textBoxCuePassword1 != textBoxCuePassword2) {
                labelPasswordDoesNotMatch.Show();
            }
            else {
                labelPasswordDoesNotMatch.Hide();
            }
        }

        private void showInvalidEmail(bool invalid) {
            if (invalid) labelInvalidEmail.Show();
            else labelInvalidEmail.Hide();
        }

        private void showUsernameTaken(bool invalid) {
            if (invalid) labelUsernameTaken.Show();
            else labelUsernameTaken.Hide();
        }

        private void showInvalidPassword(bool invalid) {
            if (invalid) labelInvalidPassword.Show();
            else labelInvalidPassword.Hide();
        }
    }
}
