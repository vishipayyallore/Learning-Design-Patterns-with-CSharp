using Builder.BuildVehicles.ConcreteBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builder.BuildVehiclesTests
{

    [TestClass]
    public class MotorCycleBuilderTests
    {

        [TestMethod]
        public void When_MotorCycle_IsBuild()
        {
            var builder = new MotorCycleBuilder();
            builder
                .BuildFrame()
                .BuildEngine()
                .BuildWheels()
                .BuildDoors()
                .DisplayVehicle();
        }

    }

}