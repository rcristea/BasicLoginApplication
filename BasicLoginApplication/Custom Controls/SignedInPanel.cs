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
    public partial class SignedInPanel : UserControl {
        public SignedInPanel() {
            InitializeComponent();
        }

        public void setWelcomeText(string username) {
            labelWelcome.Text = "Welcome " + username;
        }
    }
}
