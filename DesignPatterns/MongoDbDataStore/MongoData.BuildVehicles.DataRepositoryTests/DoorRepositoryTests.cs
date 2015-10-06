using System;

using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoData.BuildVehicles.DataRepository;
using MongoData.DataStore.Utilities;
using MongoData.DesignPattern.DataModels;

namespace MongoData.BuildVehicles.DataRepositoryTests
{
    [TestClass]
    public class DoorRepositoryTests
    {
        [TestMethod]
        public void Add_ANew_Door()
        {
            var door = new Door
            {
                Name = NameGenerator.GenerateName(),
                NumberOfItems = 4
            };

            var doorRepository = new DoorRepository();
            doorRepository.Add(door).Wait();
            //Console.WriteLine(results);
        }

    }

}
