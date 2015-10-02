using MongoData.DataStore;
using MongoData.DesignPattern.DataModels;
using MongoDB.Driver;

namespace MongoData.BuildVehicles.DataStore
{

    public class BuildVehiclesContext
    {
        #region Properties.
        private static IMongoDatabase _mongoDatabase;
        private static readonly MongoDataStore MongoDataStoreInstance = MongoDataStore.DataStoreInstance;
        #endregion

        public BuildVehiclesContext()
        {
            _mongoDatabase = MongoDataStoreInstance.DatabaseInstance;
        }

        #region Properties
        public IMongoCollection<Door> Doors => _mongoDatabase.GetCollection<Door>("doors");
        #endregion
    }

}
