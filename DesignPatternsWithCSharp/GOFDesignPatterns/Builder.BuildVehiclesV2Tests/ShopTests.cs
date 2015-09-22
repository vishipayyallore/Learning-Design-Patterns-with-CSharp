using Builder.BuildVehiclesV2.ConcreteBuilder;
using Builder.BuildVehiclesV2.Director;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builder.BuildVehiclesV2Tests
{

    [TestClass]
    public class ShopTests
    {
        [TestMethod]
        public void When_Scooter_IsBuild()
        {
            var shop = new Shop();
            shop.Construct(new ScooterBuilder());
        }

        [TestMethod]
        public void When_MotorCycle_IsBuild()
        {
            var shop = new Shop();
            shop.Construct(new MotorCycleBuilder());
        }

        [TestMethod]
        public void When_Car1_IsBuild()
        {
            var shop = new Shop();
            shop.Construct(new CarBuilder());
        }
    }

}