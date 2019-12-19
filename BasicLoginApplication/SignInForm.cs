using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

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
    }
}
