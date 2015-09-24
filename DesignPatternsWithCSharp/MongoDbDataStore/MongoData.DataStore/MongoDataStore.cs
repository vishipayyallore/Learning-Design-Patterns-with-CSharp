using MongoData.DataStore.Utilities;
using MongoDB.Driver;

namespace MongoData.DataStore
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
        public static MongoDataStore DataStoreInstance { get; } = new MongoDataStore();

        public MongoClient MongoDataStoreClient => DataStoreClient;
        #endregion
    }

}
