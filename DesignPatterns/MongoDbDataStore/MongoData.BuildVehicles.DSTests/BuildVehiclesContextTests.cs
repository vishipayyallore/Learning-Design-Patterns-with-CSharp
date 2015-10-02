using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoData.BuildVehicles.DataStore;
using MongoData.DesignPattern.DataModels;

namespace MongoData.BuildVehicles.DSTests
{
    [TestClass]
    public class BuildVehiclesContextTests
    {
        [TestMethod]
        public void WriteASingleDoorDocument()
        {

            var door = new Door
            {
                Name = "Simple Door",
                NumberOfItems = 4
            };

            var buildVehiclesContext = new BuildVehiclesContext();
            buildVehiclesContext.Doors.InsertOneAsync(door).Wait();
        }
    }
}
