using Builder.BuildVehicles.Infrastructure;
using Builder.BuildVehicles.Product;
using Builder.BuildVehicles.VehicleParts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builder.BuildVehiclesTests
{

    [TestClass]
    public class VehicleTests
    {

        [TestMethod]
        public void When_Scooter_IsBuild()
        {
            var scooter = new Vehicle(VehicleTypes.Scooter)
            {
                [PartNames.Frame] = new Frame {Id = "A100", Name = "Scooter Frame" },
                [PartNames.Engine] = new Engine { Id = "A101", Name = "Scooter Enginee", Speed = "50 CC" },
                [PartNames.Doors] = new Doors { Id = "A102", Name = "Scooter Door", NumberOfItems = 0 },
                [PartNames.Wheels] = new Wheels { Id = "A103", Name = "Scooter Wheels", NumberOfItems = 2}
            };
            scooter.DisplayVehicle();
        }

        [TestMethod]
        public void When_MotorCycle_IsBuild()
        {
            var motorCycle = new Vehicle(VehicleTypes.MotorCycle)
            {
                [PartNames.Frame] = new Frame { Id = "B100", Name = "MotorCycle Frame" },
                [PartNames.Engine] = new Engine { Id = "B101", Name = "MotorCycle Enginee", Speed = "250 CC" },
                [PartNames.Doors] = new Doors { Id = "B102", Name = "MotorCycle Door", NumberOfItems = 0 },
                [PartNames.Wheels] = new Wheels { Id = "B103", Name = "MotorCycle Wheels", NumberOfItems = 2 }
            };
            motorCycle.DisplayVehicle();
        }

        [TestMethod]
        public void When_Car1_IsBuild()
        {
            var car = new Vehicle(VehicleTypes.MotorCycle)
            {
                [PartNames.Frame] = new Frame { Id = "C100", Name = "Car Frame" },
                [PartNames.Engine] = new Engine { Id = "C101", Name = "Car Enginee", Speed = "2500 CC" },
                [PartNames.Doors] = new Doors { Id = "C102", Name = "MotorCycle Door", NumberOfItems = 2 },
                [PartNames.Wheels] = new Wheels { Id = "C103", Name = "MotorCycle Wheels", NumberOfItems = 4 }
            };
            car.DisplayVehicle();
        }

        [TestMethod]
        public void When_Car2_IsBuild()
        {
            var car = new Vehicle(VehicleTypes.MotorCycle)
            {
                [PartNames.Frame] = new Frame { Id = "C100", Name = "Car Frame" },
                [PartNames.Engine] = new Engine { Id = "C101", Name = "Car Enginee", Speed = "1500 CC" },
                [PartNames.Doors] = new Doors { Id = "C102", Name = "MotorCycle Door", NumberOfItems = 4 },
                [PartNames.Wheels] = new Wheels { Id = "C103", Name = "MotorCycle Wheels", NumberOfItems = 4 }
            };
            car.DisplayVehicle();
        }

    }

}
