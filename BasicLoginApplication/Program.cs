using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicLoginApplication {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm());
            */

            DatabaseManager dm = new DatabaseManager();
            User u = new User("email@example.com", "username", "P4ssM0rd");
            dm.addDocument(u);
        }
    }
}
