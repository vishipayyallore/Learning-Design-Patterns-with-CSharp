using Builder.BuildVehiclesV2.Builder;
using Builder.BuildVehiclesV2.Infrastructure;
using Builder.BuildVehiclesV2.VehicleParts;

namespace Builder.BuildVehiclesV2.ConcreteBuilder
{
    public class CarBuilder : VehiclesBuilder
    {

        public CarBuilder() : base(VehicleType.Car)
        {
        }

        #region Methods.
        public override VehiclesBuilder BuildFrame()
        {
            CurrentVehicle[PartType.Frame] = new Frame { Id = "C100", Name = "Car Frame" };
            return this;
        }

        public override VehiclesBuilder BuildEngine()
        {
            CurrentVehicle[PartType.Engine] = new Engine { Id = "C101", Name = "Car Enginee", Speed = "2500 CC" };
            return this;
        }

        public override VehiclesBuilder BuildWheels()
        {
            CurrentVehicle[PartType.Wheel] = new Wheels { Id = "C103", Name = "Car Wheels", NumberOfItems = 4 };
            return this;
        }

        public override VehiclesBuilder BuildDoors()
        {
            CurrentVehicle[PartType.Door] = new Doors { Id = "C102", Name = "Car Door", NumberOfItems = 2 };
            return this;
        }
        #endregion
    }
}