using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDb.DataStore.Utilities
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
