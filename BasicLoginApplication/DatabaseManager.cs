using System;
using MongoDB.Driver;
using System.Collections.Generic;

namespace BasicLoginApplication {
    class DatabaseManager {
        private string ConnectionString = "mongodb+srv://admin:B0JtTZs55hdOXc65@cluster0-wogqp.mongodb.net/test?retryWrites=true&w=majority";
        private MongoClient Client;
        private IMongoDatabase Database;
        private IMongoCollection<User> Collection;

        public DatabaseManager () {
            Client = new MongoClient(ConnectionString);
            Database = Client.GetDatabase("BasicLoginApplicationUsers");
            Collection = Database.GetCollection<User>("users");
        }

        public async void addDocument(User user) {
            await Collection.InsertOneAsync(user);
        }

        public async void removeDocument(User user) {
            await Collection.DeleteOneAsync(user.Email);
        }

        private User getDocument(string query) {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("Username", query);
            return Collection.Find(filter).FirstOrDefault();
        }

        public bool isValidUser(string username, string password) {
            User user = getDocument(username) == null ? new User("", "", "") : getDocument(username);

            string encryptedPassword = User.encryptPassword(password);
            if (user.Password == encryptedPassword) {
                return true;
            }

            return false;
        }
    }
}
