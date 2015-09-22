using System;
using Builder.BuildVehiclesV2.Infrastructure;
using Builder.BuildVehiclesV2.Product;
using Builder.BuildVehiclesV2.VehicleParts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builder.BuildVehiclesV2Tests
{

    [TestClass]
    public class VehicleTests
    {

        [TestMethod]
        public void When_Scooter_IsBuild()
        {
            var scooter = new Vehicle(VehicleType.Scooter)
            {
                [PartType.Frame] = new Frame { Id = "A100", Name = "Scooter Frame" },
                [PartType.Engine] = new Engine { Id = "A101", Name = "Scooter Enginee", Speed = "50 CC" },
                [PartType.Door] = new Doors { Id = "A102", Name = "Scooter Door", NumberOfItems = 0 },
                [PartType.Wheel] = new Wheels { Id = "A103", Name = "Scooter Wheels", NumberOfItems = 2 }
            };
            scooter.DisplayVehicle();
        }

        [TestMethod]
        public void When_MotorCycle_IsBuild()
        {
            var motorCycle = new Vehicle(VehicleType.MotorCycle)
            {
                [PartType.Frame] = new Frame { Id = "B100", Name = "MotorCycle Frame" },
                [PartType.Engine] = new Engine { Id = "B101", Name = "MotorCycle Enginee", Speed = "250 CC" },
                [PartType.Door] = new Doors { Id = "B102", Name = "MotorCycle Door", NumberOfItems = 0 },
                [PartType.Wheel] = new Wheels { Id = "B103", Name = "MotorCycle Wheels", NumberOfItems = 2 }
            };
            motorCycle.DisplayVehicle();
        }

        [TestMethod]
        public void When_Car1_IsBuild()
        {
            var car = new Vehicle(VehicleType.Car)
            {
                [PartType.Frame] = new Frame { Id = "C100", Name = "Car Frame" },
                [PartType.Engine] = new Engine { Id = "C101", Name = "Car Enginee", Speed = "2500 CC" },
                [PartType.Door] = new Doors { Id = "C102", Name = "MotorCycle Door", NumberOfItems = 2 },
                [PartType.Wheel] = new Wheels { Id = "C103", Name = "MotorCycle Wheels", NumberOfItems = 4 }
            };
            car.DisplayVehicle();
        }

        [TestMethod]
        public void When_Car2_IsBuild()
        {
            var car = new Vehicle(VehicleType.Car)
            {
                [PartType.Frame] = new Frame { Id = "C100", Name = "Car Frame" },
                [PartType.Engine] = new Engine { Id = "C101", Name = "Car Enginee", Speed = "1500 CC" },
                [PartType.Door] = new Doors { Id = "C102", Name = "MotorCycle Door", NumberOfItems = 4 },
                [PartType.Wheel] = new Wheels { Id = "C103", Name = "MotorCycle Wheels", NumberOfItems = 4 }
            };
            car.DisplayVehicle();
        }

    }

}
