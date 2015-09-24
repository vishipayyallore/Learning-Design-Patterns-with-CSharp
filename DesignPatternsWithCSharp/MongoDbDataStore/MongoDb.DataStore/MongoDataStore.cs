using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDb.DataStore
{
    public class MongoDataStore
    {

        private static readonly MongoClient _MongoClient;

        private MongoDataStore()
        {
        }

        static MongoDataStore()
        {
            var mongoDbConnectionString = ConfigurationHelper.GetConfigurationValue("MongoDbConnectionString");
            _MongoClient = new MongoClient(mongoDbConnectionString);
        }
        //var mongoClient = new MongoClient(mongoDbConnectionString);
    }

}
