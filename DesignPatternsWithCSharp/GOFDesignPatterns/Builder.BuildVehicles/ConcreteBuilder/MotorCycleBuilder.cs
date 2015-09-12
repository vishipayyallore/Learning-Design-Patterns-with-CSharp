using Builder.BuildVehicles.Builder;
using Builder.BuildVehicles.Infrastructure;
using Builder.BuildVehicles.Product;
using Builder.BuildVehicles.VehicleParts;

namespace Builder.BuildVehicles.ConcreteBuilder
{

    public class MotorCycleBuilder : VehiclesBuilder
    {
        public MotorCycleBuilder()
        {
            CurrentVehicle = new Vehicle(VehicleTypes.MotorCycle);
        }

        #region Methods
        public override VehiclesBuilder BuildFrame()
        {
            CurrentVehicle[PartNames.Frame] = new Frame {Id = "B100", Name = "MotorCycle Frame"};
            return this;
        }

        public override VehiclesBuilder BuildEngine()
        {
            CurrentVehicle[PartNames.Engine] = new Engine {Id = "B101", Name = "MotorCycle Enginee", Speed = "250 CC"};
            return this;
        }

        public override VehiclesBuilder BuildWheels()
        {
            CurrentVehicle[PartNames.Wheels] = new Wheels {Id = "B102", Name = "MotorCycle Wheels", NumberOfItems = 2};
            return this;
        }

        public override VehiclesBuilder BuildDoors()
        {
            CurrentVehicle[PartNames.Doors] = new Doors {Id = "B103", Name = "MotorCycle Door", NumberOfItems = 0};
            return this;
        }
        #endregion
    }

}