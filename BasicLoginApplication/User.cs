using MongoDB.Bson.Serialization.Attributes;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BasicLoginApplication {
    [BsonIgnoreExtraElements]
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
            set { this.password = value;  }
        }

        private static string key = "AH!PS^B0%FGH$we4";

        public User(string email, string username, string password) {
            Email = email;
            Username = username;
            Password = password;
        }

        public static string encryptPassword(string password) {
            return Cipher.Encrypt(password, User.key);
        }

        public void encryptPassword() {
            Password = Cipher.Encrypt(Password, key);
        }

        public override string ToString() {
            return "Email: " + Email + " Username: " + Username + " Password: " + Password;
        }
    }

    static class Cipher {
        private const string vector = "2Hyjp$khk9a$b31s";
        private const int keySize = 256;
        private static UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public static string Encrypt(string password, string key) {
            byte[] vectorBytes = ByteConverter.GetBytes(vector);
            byte[] passwordBytes = ByteConverter.GetBytes(password);

            PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(key, null);
            byte[] keyBytes = passwordDeriveBytes.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            symmetricKey.BlockSize = 256;
            symmetricKey.Padding = PaddingMode.Zeros;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, vectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(passwordBytes, 0, passwordBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();

            return Convert.ToBase64String(cipherTextBytes);
        }
    }
}
