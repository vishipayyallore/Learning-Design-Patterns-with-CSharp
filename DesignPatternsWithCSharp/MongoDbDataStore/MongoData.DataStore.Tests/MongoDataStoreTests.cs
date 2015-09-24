using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MongoData.DataStore.Tests
{

    [TestClass]
    public class MongoDataStoreTests
    {

        [TestMethod]
        public void When_DataStoreInstance_Created()
        {
            var dataStoreInstance = MongoDataStore.DataStoreInstance;
            var className = dataStoreInstance.GetType().Name;
            Console.WriteLine("Class Name: {0}", className);
            Assert.AreEqual("MongoDataStore", className);
        }

        [TestMethod]
        public void When_DataStoreClient_IsRetrieved()
        {
            var dataStoreInstance = MongoDataStore.DataStoreInstance;
            var datastoreClient = dataStoreInstance.MongoDataStoreClient;
            var serverName = datastoreClient.Settings.Server.ToString();
            Console.WriteLine("Server Name: {0}", serverName);
            Assert.AreEqual("localhost:27017", serverName);
        }

    }

}
