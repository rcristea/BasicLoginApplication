using MongoDB.Driver;

namespace BasicLoginApplication {
    /// <summary>
    ///     Connects and mananges the database.
    /// </summary>
    class DatabaseManager {
        private string ConnectionString = "mongodb+srv://admin:B0JtTZs55hdOXc65@cluster0-wogqp.mongodb.net/test?retryWrites=true&w=majority";
        private MongoClient Client;
        private IMongoDatabase Database;
        private IMongoCollection<User> Collection;

        /// <summary>
        ///     Connects to the MongoDB database
        /// </summary>
        public DatabaseManager () {
            Client = new MongoClient(ConnectionString);
            Database = Client.GetDatabase("BasicLoginApplicationUsers");
            Collection = Database.GetCollection<User>("users");
        }

        /// <summary>
        ///     Adds a new document to the database.
        /// </summary>
        /// <param name="user">The data to be added.</param>
        public async void addDocument(User user) {
            user.Username = user.Username.ToLower();
            await Collection.InsertOneAsync(user);
        }

        /// <summary>
        ///     Removes a document that matches the username.
        /// </summary>
        /// <param name="username">The username of the document to be deleted.</param>
        public async void removeDocument(string username) {
            await Collection.DeleteOneAsync(u => u.Username == username);
        }

        /// <summary>
        ///     Retreives a document from the database.
        /// </summary>
        /// <param name="query">The username string to look for.</param>
        /// <returns>The user object found in the database, if its not found it returns null.</returns>
        public User getDocument(string query) {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("Username", query);
            return Collection.Find(filter).FirstOrDefault();
        }

        /// <summary>
        ///     Checks to see if the username and password match any in the database.
        /// </summary>
        /// <param name="username">The username to match.</param>
        /// <param name="password">The password to match.</param>
        /// <returns>True if there is a document with matching username and password, false otherwise.</returns>
        public bool isValidUser(string username, string password) {
            username = username.ToLower();
            User user = getDocument(username) == null ? new User("", "", "") : getDocument(username);

            string decrypted = Cipher.Decrypt(user.Password, "AH!PS^B0%FGH$we4");
            if (password == decrypted) {
                return true;
            }

            return false;
        }
    }
}
