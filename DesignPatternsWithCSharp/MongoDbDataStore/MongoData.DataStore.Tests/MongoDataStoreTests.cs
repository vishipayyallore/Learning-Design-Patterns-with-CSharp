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

    }
}
