using System;
using System.Windows.Forms;

namespace BasicLoginApplication.Custom_Controls {
    /// <summary>
    ///     Sign Up panel that takes user input for creating a new account.
    /// </summary>
    public partial class SignUpPanel : UserControl {
        /// <summary>
        ///     Creates a new SignUpPanel.
        /// </summary>
        /// <remarks>
        ///     Hides the invalid inpt labels when the panel is first created.
        /// </remarks>
        public SignUpPanel() {
            InitializeComponent();
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        /// <summary>
        ///     Changes the password character of the password textboxes depending if the show check box is checked or not.
        ///     Basically changes between plain text to the circle character to hide the password.
        /// </summary>
        /// <param name="sender">The checkBoxShowPassword control.</param>
        /// <param name="e">The check changed event.</param>
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

        /// <summary>
        ///     Hides the invalid labels if the email text box is clicked.
        /// </summary>
        /// <param name="sender">the textBoxCueEmail control.</param>
        /// <param name="e">The mouse down event.</param>
        private void textBoxCueEmail_MouseDown(object sender, MouseEventArgs e) {
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        /// <summary>
        ///     Hides the invalid labels if the username text box is cliked.
        /// </summary>
        /// <param name="sender">The textBoxCueUsername control.</param>
        /// <param name="e">The mouse down event.</param>
        private void textBoxCueUsername_MouseDown(object sender, MouseEventArgs e) {
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        /// <summary>
        ///     HIdes the invalid labels if the enter password box is clicked.
        /// </summary>
        /// <param name="sender">The enter password text box control.</param>
        /// <param name="e">The mouse down event.</param>
        private void textBoxCuePassword1_MouseDown(object sender, MouseEventArgs e) {
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        /// <summary>
        ///     Hides the invalid labels if the reenter password text box is clicked.
        /// </summary>
        /// <param name="sender">The reenter password control.</param>
        /// <param name="e">The mouse down event.</param>
        private void textBoxCuePassword2_MouseDown(object sender, MouseEventArgs e) {
            labelInvalidEmail.Hide();
            labelUsernameTaken.Hide();
            labelInvalidPassword.Hide();
            labelPasswordDoesNotMatch.Hide();
        }

        /// <summary>
        ///     Checks if the passwords in enter password and reenter password are the same. Used for the passwords do not match error label.
        /// </summary>
        /// <returns>True if the passwords are the same, false otherwise.</returns>
        private bool passwordsMatch() {
            return textBoxCuePassword1.Text == textBoxCuePassword2.Text;
        }

        /// <summary>
        ///     Shows the invalid label if the paramater is true.
        /// </summary>
        /// <param name="invalid">True if the label should be shown. False otherwise.</param>
        public void showInvalidEmail(bool invalid) {
            if (invalid) labelInvalidEmail.Show();
            else labelInvalidEmail.Hide();
        }

        /// <summary>
        ///     Shows the username taken error if the parameter is true.
        /// </summary>
        /// <param name="invalid">True if the label should be shown. False otherwise.</param>
        public void showUsernameTaken(bool invalid) {
            if (invalid) labelUsernameTaken.Show();
            else labelUsernameTaken.Hide();
        }

        /// <summary>
        ///     Shows the invalid password if the parameter is true.
        /// </summary>
        /// <param name="invalid">True of the label should be shown, false otherwise.</param>
        public void showInvalidPassword(bool invalid) {
            if (invalid) labelInvalidPassword.Show();
            else labelInvalidPassword.Hide();
        }

        /// <summary>
        ///     Shows the passwords do not match label if the passwords do not match.
        /// </summary>
        public void showPasswordMatch() {
            if (!passwordsMatch()) {
                labelPasswordDoesNotMatch.Show();
            } else {
                labelPasswordDoesNotMatch.Hide();
            }
        }

        /// <summary>
        ///     Get the email enterd in the textbox.
        /// </summary>
        /// <returns>The email entered.</returns>
        public string getEmail() {
            return textBoxCueEmail.Text;
        }

        /// <summary>
        ///     Gets the username eneted in the textbox.
        /// </summary>
        /// <returns>The username entered.</returns>
        public string getUsername() {
            return textBoxCueUsername.Text;
        }

        /// <summary>
        ///     Gets the passwords if the passwords match.
        /// </summary>
        /// <returns>The password eneted in the textbox if the passwords match. Null otherwise.</returns>
        public string getPassword() {
            return passwordsMatch() ? textBoxCuePassword1.Text : null;
        }
    }
}
