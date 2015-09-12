using Builder.BuildVehicles.ConcreteBuilder;
using Builder.BuildVehicles.Director;
using Builder.BuildVehicles.Infrastructure;
using Builder.BuildVehicles.Product;
using Builder.BuildVehicles.VehicleParts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builder.BuildVehiclesTests
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