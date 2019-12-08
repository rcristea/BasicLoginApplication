using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoginApplication {
    class User {
        private string email;
        private string username;
        private string password;
        private static RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

        public User(string email, string username, string password) {
            this.email = email;
            this.username = username;
            setPassword(password);
        }

        public string getPassword() {
            return this.password;
        }

        private void setPassword(string password) {
            try {
                UnicodeEncoding byteConverter = new UnicodeEncoding();
                byte[] passwordBytes = byteConverter.GetBytes(password);
                byte[] encryptedPassword;

                encryptedPassword = encrypt(passwordBytes, RSA.ExportParameters(false), false);

                this.password = byteConverter.GetString(encryptedPassword);
            } catch (ArgumentNullException) {
                Console.WriteLine("Encrpython failed.");
            }
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
