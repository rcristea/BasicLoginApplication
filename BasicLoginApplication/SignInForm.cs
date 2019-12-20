using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace BasicLoginApplication {
    public partial class SignInForm : Form {
        private DatabaseManager dm = new DatabaseManager();
        private bool dragging = false;
        private Point point;
        private Point dragStart;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int Left, int Top, int Right, int Bottom, int Height, int Width);

        public SignInForm() {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            signUpPanel.Hide();
            buttonSignup.Hide();
            labelBackButton.Hide();
        }

        private void gradient_MouseDown(object sender, MouseEventArgs e) {
            this.dragging = true;
            this.point = Cursor.Position;
            this.dragStart = this.Location;
        }

        private void gradient_MouseMove(object sender, MouseEventArgs e) {
            if (dragging) {
                Point dif = Point.Subtract(Cursor.Position, new Size(this.point));
                this.Location = Point.Add(this.dragStart, new Size(dif));
            }
        }

        private void gradient_MouseUp(object sender, MouseEventArgs e) {
            this.dragging = false;
        }

        private void buttonClose1_MouseDown(object sender, MouseEventArgs e) {
            if (signInPanel.rememberMe()) {
                //TODO if they checked remember me i need to create a text file with the username and password (encrypted) in a text file
            }

            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            string username = signInPanel.getUsername();
            string password = signInPanel.getPassword();

            if (dm.isValidUser(username, password)) {
                MessageBox.Show("Signed In!");
            } else {
                signInPanel.showInvalid(true);
            }
        }

        private void labelSignUpButton_MouseHover(object sender, EventArgs e) {
            Font label = labelSignUpButton.Font;
            labelSignUpButton.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Regular);
        }

        private void labelSignUpButton_MouseLeave(object sender, EventArgs e) {
            Font label = labelSignUpButton.Font;
            labelSignUpButton.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Underline);
        }

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

        private void labelBackButton_MouseHover(object sender, EventArgs e) {
            Font label = labelBackButton.Font;
            labelBackButton.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Regular);
        }

        private void labelBackButton_MouseLeave(object sender, EventArgs e) {
            Font label = labelBackButton.Font;
            labelBackButton.Font = new Font(label.Name, label.SizeInPoints, FontStyle.Underline);
        }

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

        private void buttonSignup_MouseDown(object sender, MouseEventArgs e) {
            DatabaseManager dm = new DatabaseManager();
            bool validInput = true;
            string email = signUpPanel.getEmail();
            string username = signUpPanel.getUsername();
            string password = signUpPanel.getPassword();

            try {
                MailAddress mail = new MailAddress(email);
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

            if (!hasNumber.IsMatch(password) || !hasUpperChar.IsMatch(password) || !hasMinimum8Chars.IsMatch(password)) {
                signUpPanel.showInvalidPassword(true);
                validInput = false;
            }

            if (validInput) {
                User user = new User(email, username, password);
                user.encryptPassword();
                dm.addDocument(user);

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

            
        }
    }
}
