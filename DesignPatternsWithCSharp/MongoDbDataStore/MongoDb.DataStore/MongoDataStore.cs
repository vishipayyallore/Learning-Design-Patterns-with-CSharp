using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDb.DataStore.Utilities;
using MongoDB.Driver;

namespace MongoDb.DataStore
{
    public class MongoDataStore
    {


        private static readonly MongoClient DataStoreClient;

        private MongoDataStore()
        {
        }

        static MongoDataStore()
        {
            var mongoDbConnectionString = ConfigurationHelper.GetConfigurationValue("MongoDbConnectionString");
            DataStoreClient = new MongoClient(mongoDbConnectionString);
        }

        public static MongoDataStore DataStore { get; } = new MongoDataStore();

        public MongoClient MongoDataStoreClient => DataStoreClient;

    }

}
