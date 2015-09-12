using Builder.BuildVehicles.ConcreteBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builder.BuildVehiclesTests
{

    [TestClass]
    public class CarBuilderTests
    {

        [TestMethod]
        public void When_Car_IsBuild()
        {
            var builder = new CarBuilder();
            builder
                .BuildFrame()
                .BuildEngine()
                .BuildWheels()
                .BuildDoors()
                .DisplayVehicle();
        }

    }

}