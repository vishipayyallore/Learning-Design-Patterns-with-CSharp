using MongoData.DataStore.Utilities;
using MongoDB.Driver;

namespace MongoData.DataStore
{

    public class MongoDataStore
    {
        #region Variables.
        private static readonly MongoClient DataStoreClient;
        private static readonly IMongoDatabase DesignPatternDatabase;
        #endregion

        private MongoDataStore() { }

        static MongoDataStore()
        {
            var mongoDbConnectionString = ConfigurationHelper.GetConfigurationValue("MongoDbConnectionString");
            DataStoreClient = new MongoClient(mongoDbConnectionString);

            //Data Base
            var mongoDbDatabaseName = ConfigurationHelper.GetConfigurationValue("MongoDbDatabaseName");
            DesignPatternDatabase = DataStoreClient.GetDatabase(mongoDbDatabaseName);
        }

        #region Properties
        public static MongoDataStore DataStoreInstance { get; } = new MongoDataStore();

        public MongoClient MongoDataStoreClient => DataStoreClient;

        public IMongoDatabase DatabaseInstance => DesignPatternDatabase;
        #endregion
    }

}
