using MongoDB.Bson.Serialization.Attributes;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BasicLoginApplication {
    [BsonIgnoreExtraElements]
    /// <summary>
    ///     Data model for the Mongo Database.
    /// </summary>
    /// <remarks>
    ///     This class will store an email, username, and password that will be used to represent a user
    ///     in the database. User will also handle encrypting passwords before being put in the database.
    /// </remarks>
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

        /// <summary>
        ///     Creates a user with the email, username, and password provided.
        /// </summary>
        /// <param name="email">The user's email.</param>
        /// <param name="username">The user's username.</param>
        /// <param name="password">The user's password.</param>
        public User(string email, string username, string password) {
            Email = email;
            Username = username;
            Password = password;
        }

        /// <summary>
        ///     Encrypts the provided password using the Cipher class.
        /// </summary>
        /// <param name="password">The provided password.</param>
        /// <returns>The encrypted password.</returns>
        public static string encryptPassword(string password) {
            return Cipher.Encrypt(password, User.key);
        }

        /// <summary>
        ///     Encrypts the password of this user.
        /// </summary>
        public void encryptPassword() {
            Password = Cipher.Encrypt(Password, key);
        }

        /// <summary>
        ///     Returns a string representation of the user.
        /// </summary>
        /// <returns>The string</returns>
        public override string ToString() {
            return "Email: " + Email + " Username: " + Username + " Password: " + Password;
        }
    }

    /// <summary>
    ///     Used for password encryption
    /// </summary>
    static class Cipher {
        private const string vector = "2Hyjp$khk9a$b31s";
        private const int keySize = 256;
        private static UnicodeEncoding ByteConverter = new UnicodeEncoding();

        /// <summary>
        ///     Encrypts the provided password using the provided key.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="key">The key.</param>
        /// <returns>The encrypted password.</returns>
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
