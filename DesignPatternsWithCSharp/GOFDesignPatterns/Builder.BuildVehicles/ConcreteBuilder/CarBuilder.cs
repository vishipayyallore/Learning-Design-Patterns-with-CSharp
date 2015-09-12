using Builder.BuildVehicles.Builder;
using Builder.BuildVehicles.Infrastructure;
using Builder.BuildVehicles.Product;
using Builder.BuildVehicles.VehicleParts;

namespace Builder.BuildVehicles.ConcreteBuilder
{
    public class CarBuilder : VehiclesBuilder
    {

        public CarBuilder()
        {
            CurrentVehicle = new Vehicle(VehicleTypes.Car);
        }

        //TODO: Move the Parts creation to Director
        #region Methods.
        public override VehiclesBuilder BuildFrame()
        {
            CurrentVehicle[PartNames.Frame] = new Frame { Id = "C100", Name = "Car Frame" };
            return this;
        }

        public override VehiclesBuilder BuildEngine()
        {
            CurrentVehicle[PartNames.Engine] = new Engine { Id = "C101", Name = "Car Enginee", Speed = "2500 CC" };
            return this;
        }

        public override VehiclesBuilder BuildWheels()
        {
            CurrentVehicle[PartNames.Wheels] = new Wheels { Id = "C103", Name = "MotorCycle Wheels", NumberOfItems = 4 };
            return this;
        }

        public override VehiclesBuilder BuildDoors()
        {
            CurrentVehicle[PartNames.Doors] = new Doors { Id = "C102", Name = "MotorCycle Door", NumberOfItems = 2 };
            return this;
        }
        #endregion
    }

}