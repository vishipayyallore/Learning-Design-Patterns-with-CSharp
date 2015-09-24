using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDb.DataStore.Utilities;

namespace MongoDb.DataStore.UtilitiesTests
{

    [TestClass]
    public class ConfigurationHelperTests
    {

        [TestMethod]
        public void When_MongoDbConnectionString_IsRetrieved()
        {
            var mongoDbConnectionString = ConfigurationHelper.GetConfigurationValue("MongoDbConnectionString");
            Console.WriteLine("Retrieved Connection String Value: {0}", mongoDbConnectionString);
            Assert.AreEqual("mongodb://localhost:27017", mongoDbConnectionString);
        }

        [TestMethod]
        public void When_MongoDbDatabaseName_IsRetrieved()
        {
            var mongoDbDatabaseName = ConfigurationHelper.GetConfigurationValue("MongoDbDatabaseName");
            Console.WriteLine("Retrieved Database Name Value: {0}", mongoDbDatabaseName);
            Assert.AreEqual("designpatternsstore", mongoDbDatabaseName);
        }

        [TestMethod]
        public void When_MongoDbDatabaseName1_IsRetrieved()
        {
            var mongoDbDatabaseName1 = ConfigurationHelper.GetConfigurationValue("MongoDbDatabaseName1");
            Console.WriteLine("Retrieved Database Name Value: {0}", mongoDbDatabaseName1);
            Assert.AreEqual(string.Empty, mongoDbDatabaseName1);
        }
    }

}
