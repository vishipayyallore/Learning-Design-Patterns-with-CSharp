using MongoData.DataStore;
using MongoData.DataStore.Utilities;
using MongoData.DesignPattern.DataModels;
using MongoDB.Driver;

namespace MongoData.BuildVehicles.DataStore
{

    public class BuildVehiclesContext
    {
        #region Properties.
        private static IMongoDatabase _mongoDatabase;
        private static readonly MongoDataStore MongoDataStoreInstance = MongoDataStore.DataStoreInstance;
        private static string _doorCollectionName;
        #endregion

        public BuildVehiclesContext()
        {
            _doorCollectionName = ConfigurationHelper.GetConfigurationValue("DoorCollectionName");
            _mongoDatabase = MongoDataStoreInstance.DatabaseInstance;
        }

        #region Properties
        public IMongoCollection<Door> Doors => _mongoDatabase.GetCollection<Door>(_doorCollectionName);
        #endregion
    }

}
