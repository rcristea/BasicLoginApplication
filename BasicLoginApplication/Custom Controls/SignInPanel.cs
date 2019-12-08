using System.Windows.Forms;

namespace BasicLoginApplication.Custom_Controls {
    public partial class SignInPanel : UserControl {
        public SignInPanel() {
            InitializeComponent();
            labelInvalid.Hide();
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

        public void showInvalid() {
            labelInvalid.Show();
        }

        public void hideInvalide() {
            labelInvalid.Hide();
        }

        private void textBoxCueUsername_MouseDown(object sender, MouseEventArgs e) {
            labelInvalid.Hide();
        }

        private void textBoxCuePassword_MouseDown(object sender, MouseEventArgs e) {
            labelInvalid.Hide();
        }
    }
}
