using System.Windows.Forms;

namespace BasicLoginApplication.Custom_Controls {
    /// <summary>
    ///     Used when the user has successfully signed in.
    /// </summary>
    public partial class SignedInPanel : UserControl {
        /// <summary>
        ///     Creates a new SignedInPanel.
        /// </summary>
        public SignedInPanel() {
            InitializeComponent();
        }

        /// <summary>
        ///     Used to set the text of the label to the user's username.
        /// </summary>
        /// <param name="username">The user's username.</param>
        public void setWelcomeText(string username) {
            labelWelcome.Text = "Welcome " + username;
        }
    }
}
