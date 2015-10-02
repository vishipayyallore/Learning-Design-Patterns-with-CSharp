using MongoData.DataStore;
using MongoData.DesignPattern.DataModels;
using MongoDB.Driver;

namespace MongoData.BuildVehicles.DataStore
{

    public class BuildVehiclesContext
    {

        private static IMongoDatabase _mongoDatabase;
        private static readonly MongoDataStore MongoDataStoreInstance = MongoDataStore.DataStoreInstance;

        public BuildVehiclesContext()
        {
            _mongoDatabase = MongoDataStoreInstance.DatabaseInstance;
        }

        public IMongoCollection<Door> Doors => _mongoDatabase.GetCollection<Door>("doors");
    }

}
