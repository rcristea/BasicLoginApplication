using System.Windows.Forms;

namespace BasicLoginApplication.Custom_Controls {
    public partial class SignInPanel : UserControl {
        public SignInPanel() {
            InitializeComponent();
            labelInvalid.Hide();
            labelUsernameInvalid.Hide();
            labelPasswordInvalid.Hide();
        }

        public string getUsername() {
            return textBoxCueUsername.Text;
        }

        public string getPassword() {
            return textBoxCuePassword.Text;
        }

        public bool rememberMe() {
            return checkBoxRememberMe.Checked;
        }

        public void showInvalid(bool show) {
            if (show) {
                labelInvalid.Show();
            } else {
                labelInvalid.Hide();
            }
        }

        public void showUsernameInvalid(bool show) {
            if (show) {
                labelUsernameInvalid.Show();
            } else {
                labelUsernameInvalid.Hide();
            }
        }

        public void showPasswordInvalid(bool show) {
            if (show) {
                labelPasswordInvalid.Show();
            } else {
                labelPasswordInvalid.Hide();
            }
        }

        private void textBoxCueUsername_MouseDown(object sender, MouseEventArgs e) {
            labelInvalid.Hide();
            labelUsernameInvalid.Hide();
        }

        private void textBoxCuePassword_MouseDown(object sender, MouseEventArgs e) {
            labelInvalid.Hide();
            labelPasswordInvalid.Hide();
        }
    }
}
