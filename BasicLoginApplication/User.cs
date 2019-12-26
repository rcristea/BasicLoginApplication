using MongoDB.Bson.Serialization.Attributes;
using System;
using System.IO;
using System.Linq;
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
    ///     Used for password encryption and decryption
    /// </summary>
    static class Cipher {
        private const int Keysize = 256;
        private const int DerivationIterations = 1000;


        /// <summary>
        ///     Encrypts the provided password using the provided key.
        /// </summary>
        /// <param name="plainText">The password.</param>
        /// <param name="passPhrase">The key.</param>
        /// <returns>The encrypted password.</returns>
        public static string Encrypt(string plainText, string passPhrase) { 
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations)) {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged()) {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes)) {
                        using (var memoryStream = new MemoryStream()) {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)) {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Decrypts the encrypted password.
        /// </summary>
        /// <param name="cipherText">The encrypted password.</param>
        /// <param name="passPhrase">The key used dudring encryption.</param>
        /// <returns>The decrypted password.</returns>
        public static string Decrypt(string cipherText, string passPhrase) {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations)) {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged()) {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes)) {
                        using (var memoryStream = new MemoryStream(cipherTextBytes)) {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)) {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Generates randomBytes used for salt and initial vector.
        /// </summary>
        /// <returns>The random bytes generated.</returns>
        private static byte[] Generate256BitsOfRandomEntropy() {
            var randomBytes = new byte[32];
            using (var rngCsp = new RNGCryptoServiceProvider()) {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
