using MongoDb.DataStore.Utilities;
using MongoDB.Driver;

namespace MongoDb.DataStore
{
    public class MongoDataStore
    {
        #region Variables.
        private static readonly MongoClient DataStoreClient;
        #endregion

        private MongoDataStore() { }

        static MongoDataStore()
        {
            var mongoDbConnectionString = ConfigurationHelper.GetConfigurationValue("MongoDbConnectionString");
            DataStoreClient = new MongoClient(mongoDbConnectionString);
        }

        #region Properties
        public static MongoDataStore DataStore { get; } = new MongoDataStore();

        public MongoClient MongoDataStoreClient => DataStoreClient;
        #endregion
    }

}
