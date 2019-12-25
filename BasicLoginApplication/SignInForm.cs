using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace BasicLoginApplication {
    /// <summary>
    ///     The main GUI frame for the entire application.
    /// </summary>
    public partial class SignInForm : Form {
        private DatabaseManager dm = new DatabaseManager();
        private bool dragging = false;
        private Point point;
        private Point dragStart;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int Left, int Top, int Right, int Bottom, int Height, int Width);
        
        /// <summary>
        ///     Initializes all controls for the application.
        /// </summary>
        /// <remarks>
        ///     The region creates the curved borders around the edge.
        ///     All controls not pertaining to the main sign in page are hidden.
        /// </remarks>
        public SignInForm() {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            signUpPanel.Hide();
            buttonSignup.Hide();
            labelBackButton.Hide();
            successfulSignUpPanel.Hide();
            labelButtonClose.Hide();
            signedInPanel.Hide();
            buttonDeleteAccount.Hide();
            buttonSignOut.Hide();
        }

        /// <summary>
        ///     Starts the dragging sequnce to move the window when clicking on the background.
        /// </summary>
        /// <param name="sender">The gradient</param>
        /// <param name="e">The mouse down event</param>
        private void gradient_MouseDown(object sender, MouseEventArgs e) {
            this.dragging = true;
            this.point = Cursor.Position;
            this.dragStart = this.Location;
        }

        /// <summary>
        ///     Moves the window while the mouse is dragging the background.
        /// </summary>
        /// <param name="sender">The gradient.</param>
        /// <param name="e">The mouse move event.</param>
        private void gradient_MouseMove(object sender, MouseEventArgs e) {
            if (dragging) {
                Point dif = Point.Subtract(Cursor.Position, new Size(this.point));
                this.Location = Point.Add(this.dragStart, new Size(dif));
            }
        }

        /// <summary>
        ///     Stops the dragging sequnce after the mouse is released.
        /// </summary>
        /// <param name="sender">The gradient.</param>
        /// <param name="e">The mouse up event.</param>
        private void gradient_MouseUp(object sender, MouseEventArgs e) {
            this.dragging = false;
        }

        /// <summary>
        ///     Closes the application when the black X is clicked.
        /// </summary>
        /// <remarks>
        ///     Will also write the username and encrytped password to a text file. This is used when the application is opened to
        ///     retain the user's username and password.
        /// </remarks>
        /// <param name="sender">The black X button.</param>
        /// <param name="e">The mouse down event.</param>
        private void buttonClose1_MouseDown(object sender, MouseEventArgs e) {
            if (signInPanel.rememberMe()) {
                //TODO if they checked remember me i need to create a text file with the username and password (encrypted) in a text file
            }

            Application.Exit();
        }

        /// <summary>
        ///     Signs the user int, provided valid input. Otherwise it will display the appropriate error labels.
        /// </summary>
        /// <param name="sender">The login button.</param>
        /// <param name="e">The click event</param>
        private void buttonLogin_Click(object sender, EventArgs e) {
            string username = signInPanel.getUsername();
            string password = signInPanel.getPassword();

            if (dm.isValidUser(username, password)) {
                signInPanel.Hide();
                labelNotAMemeber.Hide();
                labelSignUpButton.Hide();
                buttonLogin.Hide();

                signedInPanel.setWelcomeText(username);
                signedInPanel.Show();
                buttonSignOut.Show();
                buttonDeleteAccount.Show();
            } else {
                signInPanel.showInvalid(true);
            }
        }

        /// <summary>
        ///     Changes the font type of the sign up button to regular.
        /// </summary>
        /// <param name="sender">The labelSignUpButton.</param>
        /// <param name="e">The mouse hover event.</param>
        private void labelSignUpButton_MouseHover(object sender, EventArgs e) {
            Font label = labelSignUpButton.Font;
            labelSignUpButton.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Regular);
        }

        /// <summary>
        ///     Changes the font type of the sign up button to underlined.
        /// </summary>
        /// <param name="sender">The labelSignUpButton.</param>
        /// <param name="e">The mouseLeave event.</param>
        private void labelSignUpButton_MouseLeave(object sender, EventArgs e) {
            Font label = labelSignUpButton.Font;
            labelSignUpButton.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Underline);
        }

        /// <summary>
        ///     Displays the signup page when clicked.
        /// </summary>
        /// <param name="sender">The labelSignUpButton.</param>
        /// <param name="e">The mouse down event.</param>
        private void labelSignUpButton_MouseDown(object sender, MouseEventArgs e) {
            signInPanel.Hide();
            buttonLogin.Hide();
            labelNotAMemeber.Hide();
            labelSignUpButton.Hide();

            signInPanel.showInvalid(false);

            signUpPanel.Show();
            buttonSignup.Show();
            labelBackButton.Show();
        }

        /// <summary>
        ///     Changes the font style of the back button to regular.
        /// </summary>
        /// <param name="sender">The labelBackButton.</param>
        /// <param name="e">The mouse hover event.</param>
        private void labelBackButton_MouseHover(object sender, EventArgs e) {
            Font label = labelBackButton.Font;
            labelBackButton.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Regular);
        }

        /// <summary>
        ///     Changes the font style of the back button to underlined.
        /// </summary>
        /// <param name="sender">The labelBackButton.</param>
        /// <param name="e">The mouse leave event.</param>
        private void labelBackButton_MouseLeave(object sender, EventArgs e) {
            Font label = labelBackButton.Font;
            labelBackButton.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Underline);
        }

        /// <summary>
        ///     Returns the user to the signin page when the back button is clicked.
        /// </summary>
        /// <param name="sender">The back button.</param>
        /// <param name="e">The mouse down event.</param>
        private void labelBackButton_MouseDown(object sender, MouseEventArgs e) {
            signInPanel.Show();
            buttonLogin.Show();
            labelNotAMemeber.Show();
            labelSignUpButton.Show();

            signUpPanel.showInvalidEmail(false);
            signUpPanel.showUsernameTaken(false);
            signUpPanel.showInvalidPassword(false);

            signUpPanel.Hide();
            buttonSignup.Hide();
            labelBackButton.Hide();
        }

        /// <summary>
        ///     Signs the user up and stores their information into the database.
        /// </summary>
        /// <remarks>
        ///     The input is also validated here. If something is wrong the user will not be added and the proper error labels
        ///     are displayed.
        /// </remarks>
        /// <param name="sender">The buttonSignUp.</param>
        /// <param name="e">The mouse down event.</param>
        private void buttonSignup_MouseDown(object sender, MouseEventArgs e) {
            DatabaseManager dm = new DatabaseManager();
            bool validInput = true;
            string email = signUpPanel.getEmail();
            string username = signUpPanel.getUsername();
            string password = signUpPanel.getPassword();

            try {
                MailAddress mail = new MailAddress(email);
            }
            catch (ArgumentException) {
                validInput = false;
                signUpPanel.showInvalidEmail(true);
            }
            catch (FormatException) {
                validInput = false;
                signUpPanel.showInvalidEmail(true);
            }

            if (dm.getDocument(username) != null) {
                validInput = false;
                signUpPanel.showUsernameTaken(true);
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            if (password == null) password = "";

            if (!hasNumber.IsMatch(password) || !hasUpperChar.IsMatch(password) || !hasMinimum8Chars.IsMatch(password)) {
                signUpPanel.showInvalidPassword(true);
                validInput = false;
            }

            signUpPanel.showPasswordMatch();

            if (validInput) {
                User user = new User(email, username, password);
                user.encryptPassword();
                dm.addDocument(user);

                signUpPanel.Hide();
                buttonSignup.Hide();
                labelBackButton.Hide();

                successfulSignUpPanel.Show();
                labelButtonClose.Show();
            }

        }
        
        /// <summary>
        ///     Returns the user to the sign in page after they successfully signed up.
        /// </summary>
        /// <param name="sender">The labelButtonClose.</param>
        /// <param name="e">The mouse down event.</param>
        private void labelButtonClose_MouseDown(object sender, MouseEventArgs e) {
            successfulSignUpPanel.Hide();
            labelButtonClose.Hide();

            signUpPanel.showInvalidEmail(false);
            signUpPanel.showUsernameTaken(false);
            signUpPanel.showInvalidPassword(false);

            signInPanel.Show();
            buttonLogin.Show();
            labelNotAMemeber.Show();
            labelNotAMemeber.Show();
            labelSignUpButton.Show();
        }

        /// <summary>
        ///     Changes the font of the close button to regular when hovering over it.
        /// </summary>
        /// <param name="sender">The labelButtonClose.</param>
        /// <param name="e">The mouse hover event.</param>
        private void labelButtonClose_MouseHover(object sender, EventArgs e) {
            Font label = labelButtonClose.Font;
            labelButtonClose.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Regular);
        }

        /// <summary>
        ///     Changes the font of the close button to underlined.
        /// </summary>
        /// <param name="sender">The labelButtonClose.</param>
        /// <param name="e">The mouse leave event.</param>
        private void labelButtonClose_MouseLeave(object sender, EventArgs e) {
            Font label = labelButtonClose.Font;
            labelButtonClose.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Underline);
        }

        /// <summary>
        ///     Returns the user to the signin page.
        /// </summary>
        /// <param name="sender">The buttonSignOut.</param>
        /// <param name="e">The mouse down event.</param>
        private void buttonSignOut_MouseDown(object sender, MouseEventArgs e) {
            signedInPanel.Hide();
            buttonSignOut.Hide();
            buttonDeleteAccount.Hide();

            signInPanel.Show();
            buttonLogin.Show();
            labelNotAMemeber.Show();
            labelSignUpButton.Show();
        }

        /// <summary>
        ///     Deletes the user from the database.
        /// </summary>
        /// <remarks>
        ///     When the user deletes the account their confirmation is shown with a message box.
        /// </remarks>
        /// <param name="sender">The buttonDeleteAccount.</param>
        /// <param name="e">The mouse down event.</param>
        private void buttonDeleteAccount_MouseDown(object sender, MouseEventArgs e) {
            DatabaseManager dm = new DatabaseManager();
            dm.removeDocument(signInPanel.getUsername());

            signedInPanel.Hide();
            buttonSignOut.Hide();
            buttonDeleteAccount.Hide();

            signInPanel.Show();
            buttonLogin.Show();
            labelNotAMemeber.Show();
            labelSignUpButton.Show();

            MessageBox.Show("Account Deleted!");
        }
    }
}
