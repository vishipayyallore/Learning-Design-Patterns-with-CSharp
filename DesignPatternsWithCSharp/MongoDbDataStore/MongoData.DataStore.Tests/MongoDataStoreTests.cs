using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;

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

        [TestMethod]
        public void When_DesignPatternDatabase_IsRetrieved()
        {
            var dataStoreInstance = MongoDataStore.DataStoreInstance;
            var designPatternDatabase = dataStoreInstance.DatabaseInstance;
            var databaseName = designPatternDatabase.DatabaseNamespace.DatabaseName;
            Console.WriteLine("Database Name: {0}", databaseName);
            Assert.AreEqual("designpatternsstore", databaseName);
        }

        [TestMethod]
        public void When_DesignPatternDatabase_Collection_IsRetrieved()
        {
            var dataStoreInstance = MongoDataStore.DataStoreInstance;
            var designPatternDatabase = dataStoreInstance.DatabaseInstance;
            var databaseName = designPatternDatabase.DatabaseNamespace.DatabaseName;
            designPatternDatabase.CreateCollectionAsync("parts").Wait();
            Console.WriteLine("Database Name: {0}", databaseName);
            var partsCollection = designPatternDatabase.GetCollection<BsonDocument>("parts");
            Console.WriteLine("Database Name: {0} {1}", databaseName, partsCollection.CollectionNamespace.CollectionName);
            Assert.AreEqual("designpatternsstore", databaseName);
        }
    }

}
