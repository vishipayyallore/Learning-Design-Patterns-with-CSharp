using Builder.BuildVehicles.ConcreteBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builder.BuildVehiclesTests
{

    [TestClass]
    public class ScooterBuilderTests
    {

        [TestMethod]
        public void When_Scooter_IsBuild()
        {
            var builder = new ScooterBuilder();
            builder
                .BuildFrame()
                .BuildEngine()
                .BuildWheels()
                .BuildDoors()
                .DisplayVehicle();
        }

    }

}