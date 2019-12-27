using System.Windows.Forms;

namespace BasicLoginApplication.Custom_Controls {
    /// <summary>
    ///     The sign in panel where the user inputs their information to log into the application.
    /// </summary>
    public partial class SignInPanel : UserControl {
        /// <summary>
        ///     Creates a new Sign In Panel and hides the invalid username and password label.
        /// </summary>
        public SignInPanel() {
            InitializeComponent();
            labelInvalid.Hide();
        }

        /// <summary>
        ///     Gets the username that was entered into the custom text box.
        /// </summary>
        /// <returns>The username entered.</returns>
        public string getUsername() {
            return textBoxCueUsername.Text;
        }

        /// <summary>
        ///     Gets the password that was eneters in the the custom text box.
        /// </summary>
        /// <returns>The password entered.</returns>
        public string getPassword() {
            return textBoxCuePassword.Text;
        }

        /// <summary>
        ///     Checks if the remember me check box is checked or not.
        /// </summary>
        /// <returns>True if checked, false otherwise.</returns>
        public bool rememberMe() {
            return checkBoxRememberMe.Checked;
        }

        /// <summary>
        ///     Sets the text of the custom username text box.
        /// </summary>
        /// <remarks>
        ///     This is used when the application launches and checks to see if the user wanted to be remembered.
        /// </remarks>
        /// <param name="username">The username to enter.</param>
        public void setUsername(string username) {
            textBoxCueUsername.Text = username;
        }

        /// <summary>
        ///     Set the text of the custom password text box.
        /// </summary>
        /// <param name="password">The password to enter.</param>
        public void setPassword(string password) {
            textBoxCuePassword.Text = password;
        }

        /// <summary>
        ///     Shows the label if the username and password are invalid.
        /// </summary>
        /// <param name="isInvalid">True if the username and password are invalid. False otherwise.</param>
        public void showInvalid(bool isInvalid) {
            if (isInvalid) {
                labelInvalid.Show();
            }
            else {
                labelInvalid.Hide();
            }
        }

        /// <summary>
        ///     Hides the invalid label if the username textbox is clicked.
        /// </summary>
        /// <param name="sender">The textBoxCueUsername control.</param>
        /// <param name="e">The mouse down event.</param>
        private void textBoxCueUsername_MouseDown(object sender, MouseEventArgs e) {
            labelInvalid.Hide();
        }

        /// <summary>
        ///     Hides the invalid label if the password textbox is clicked.
        /// </summary>
        /// <param name="sender">The textBoxCuePassword control.</param>
        /// <param name="e">The mouse down event.</param>
        private void textBoxCuePassword_MouseDown(object sender, MouseEventArgs e) {
            labelInvalid.Hide();
        }
    }
}
