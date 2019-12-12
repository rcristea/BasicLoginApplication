using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace BasicLoginApplication {
    public partial class SignInForm : Form {
        private bool dragging = false;
        private Point point;
        private Point dragStart;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int Left, int Top, int Right, int Bottom, int Height, int Width);

        public SignInForm() {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

            }

            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            //TODO validate username and password with database
            string username = signInPanel.getUsername();
            string password = signInPanel.getPassword();

            bool invalid = false;
            
            var regexUsername = new Regex("^[a-zA-Z0-9]+$");
            if (!regexUsername.IsMatch(username)) {
                signInPanel.showUsernameInvalid(true);
                invalid = true;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            if (!hasNumber.IsMatch(password) || !hasUpperChar.IsMatch(password)
                || !hasMinimum8Chars.IsMatch(password)) {
                signInPanel.showPasswordInvalid(true);
                invalid = true;
            }

            if (!invalid) {
                //TODO search database for the user/pass and let them log in
                MessageBox.Show("Input validation successful");
            }
        }
    }
}
