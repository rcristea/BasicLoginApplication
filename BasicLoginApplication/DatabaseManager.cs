using MongoDB.Driver;

namespace BasicLoginApplication {
    class DatabaseManager {
        private string ConnectionString = "mongodb+srv://admin:B0JtTZs55hdOXc65@cluster0-wogqp.mongodb.net/test?retryWrites=true&w=majority";
        private MongoClient Client;
        private IMongoDatabase Database;
        private IMongoCollection<User> Collection;

        public DatabaseManager () {
            this.Client = new MongoClient(ConnectionString);
            this.Database = Client.GetDatabase("BasicLoginApplicationUsers");
            this.Collection = Database.GetCollection<User>("users");
        }

        public void addDocument(User user) {
            this.Collection.InsertOne(user);
        }

        public void removeDocument(User user) {
            this.Collection.DeleteOne(user.Email);
        }
    }
}
