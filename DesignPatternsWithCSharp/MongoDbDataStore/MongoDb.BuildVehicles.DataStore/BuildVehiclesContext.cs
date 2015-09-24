using MongoData.DataStore.Utilities;
using MongoDB.Driver;

namespace MongoData.BuildVehicles.DataStore
{

    public class BuildVehiclesContext
    {

        private static IMongoDatabase _mongoDatabase;

        public BuildVehiclesContext()
        {
            var mongoDbConnectionString = ConfigurationHelper.GetConfigurationValue("MongoDbConnectionString");
            var mongoDbDatabaseName = ConfigurationHelper.GetConfigurationValue("MongoDbDatabaseName");

            var mongoClient = new MongoClient(mongoDbConnectionString);
            _mongoDatabase = mongoClient.GetDatabase(mongoDbDatabaseName);
        }

    }

}
