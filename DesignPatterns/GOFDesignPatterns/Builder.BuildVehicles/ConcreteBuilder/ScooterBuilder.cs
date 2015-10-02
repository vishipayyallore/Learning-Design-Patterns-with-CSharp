using Builder.BuildVehicles.Builder;
using Builder.BuildVehicles.Infrastructure;
using Builder.BuildVehicles.Product;
using Builder.BuildVehicles.VehicleParts;

namespace Builder.BuildVehicles.ConcreteBuilder
{
    public class ScooterBuilder : VehiclesBuilder
    {

        public ScooterBuilder()
        {
            CurrentVehicle = new Vehicle(VehicleTypes.Scooter);
        }

        #region Methods.
        public override VehiclesBuilder BuildFrame()
        {
            CurrentVehicle[PartNames.Frame] = new Frame { Id = "A100", Name = "Scooter Frame" };
            return this;
        }

        public override VehiclesBuilder BuildEngine()
        {
            CurrentVehicle[PartNames.Engine] = new Engine { Id = "A101", Name = "Scooter Enginee", Speed = "50 CC" };
            return this;
        }

        public override VehiclesBuilder BuildWheels()
        {
            CurrentVehicle[PartNames.Wheels] = new Wheels {Id = "A103", Name = "Scooter Wheels", NumberOfItems = 2};
            return this;
        }

        public override VehiclesBuilder BuildDoors()
        {
            CurrentVehicle[PartNames.Doors] = new Doors { Id = "A102", Name = "Scooter Door", NumberOfItems = 0 };
            return this;
        }
        #endregion
    }
}