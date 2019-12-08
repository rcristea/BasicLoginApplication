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
    }
}
