using System;
using System.Windows.Forms;

namespace BasicLoginApplication {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SignInForm());
            Application.Run(new TestForm());
        }
    }
}
