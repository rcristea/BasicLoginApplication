using System;
using System.Security.Cryptography;
using System.Text;

namespace BasicLoginApplication {
    class User {
        private string email;
        public string Email {
            get { return this.email; }
            set { this.email = value; }
        }
        private string username;
        public string Username {
            get { return this.username; }
            set { this.username = value; }
        }
        private string password;
        public string Password {
            get { return this.password;  }
            set { this.password = setPassword(value);  }
        }

        private static RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

        public User(string email, string username, string password) {
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }

        public string getPassword() {
            return this.Password;
        }

        private string setPassword(string password) {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            byte[] encryptedPassword = null;
            try {
                byte[] passwordBytes = byteConverter.GetBytes(password);
                encryptedPassword = encrypt(passwordBytes, RSA.ExportParameters(false), false);
            } catch (ArgumentNullException) {
                Console.WriteLine("Encrpython failed.");
            }

            return byteConverter.GetString(encryptedPassword);
        }


        private byte[] encrypt(byte[] data, RSAParameters key, bool doAEPPadding) {
            try {
                byte[] encryptedData;
                RSA.ImportParameters(key);
                encryptedData = RSA.Encrypt(data, doAEPPadding);
                return encryptedData;
            } catch (CryptographicException e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
