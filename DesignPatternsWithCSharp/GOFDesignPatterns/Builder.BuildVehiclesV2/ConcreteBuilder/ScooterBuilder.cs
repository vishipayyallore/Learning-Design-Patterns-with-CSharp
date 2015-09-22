using Builder.BuildVehiclesV2.Builder;
using Builder.BuildVehiclesV2.Infrastructure;
using Builder.BuildVehiclesV2.VehicleParts;

namespace Builder.BuildVehiclesV2.ConcreteBuilder
{
    public class ScooterBuilder : VehiclesBuilder
    {

        public ScooterBuilder():base(VehicleType.Scooter)
        {
        }

        #region Methods.
        public override VehiclesBuilder BuildFrame()
        {
            DisplayLog("Building Scooter\'s Frame");
            CurrentVehicle[PartType.Frame] = new Frame { Id = "A100", Name = "Scooter Frame" };
            return this;
        }

        public override VehiclesBuilder BuildEngine()
        {
            DisplayLog("Building Scooter\'s Engine");
            CurrentVehicle[PartType.Engine] = new Engine { Id = "A101", Name = "Scooter Engine", Speed = "50 CC" };
            return this;
        }

        public override VehiclesBuilder BuildWheels()
        {
            DisplayLog("Building Scooter\'s Wheels");
            CurrentVehicle[PartType.Wheel] = new Wheels {Id = "A103", Name = "Scooter Wheels", NumberOfItems = 2};
            return this;
        }

        public override VehiclesBuilder BuildDoors()
        {
            DisplayLog("Building Scooter\'s Doors");
            CurrentVehicle[PartType.Door] = new Doors { Id = "A102", Name = "Scooter Doors", NumberOfItems = 0 };
            return this;
        }
        #endregion
    }
}