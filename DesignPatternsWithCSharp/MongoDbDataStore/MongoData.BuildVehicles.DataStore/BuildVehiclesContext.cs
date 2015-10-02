using MongoData.DataStore;
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

        //public IMongoCollection<ClientFile> ClientFiles
        //{
        //    get { return _mongoDatabase.GetCollection<ClientFile>("clients"); }
        //}
    }

}
