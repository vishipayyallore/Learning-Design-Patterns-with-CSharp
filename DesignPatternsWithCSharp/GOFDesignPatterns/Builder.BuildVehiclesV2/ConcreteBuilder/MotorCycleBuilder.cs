using Builder.BuildVehiclesV2.Builder;
using Builder.BuildVehiclesV2.Infrastructure;
using Builder.BuildVehiclesV2.VehicleParts;

namespace Builder.BuildVehiclesV2.ConcreteBuilder
{

    public class MotorCycleBuilder : VehiclesBuilder
    {

        public MotorCycleBuilder(): base(VehicleType.MotorCycle)
        {
        }

        #region Methods
        public override VehiclesBuilder BuildFrame()
        {
            DisplayLog("Building MotorCycle\'s Frame");
            CurrentVehicle[PartType.Frame] = new Frame {Id = "B100", Name = "MotorCycle Frame"};
            return this;
        }

        public override VehiclesBuilder BuildEngine()
        {
            DisplayLog("Building MotorCycle\'s Engine");
            CurrentVehicle[PartType.Engine] = new Engine {Id = "B101", Name = "MotorCycle Engine", Speed = "250 CC"};
            return this;
        }

        public override VehiclesBuilder BuildWheels()
        {
            DisplayLog("Building MotorCycle\'s Wheels");
            CurrentVehicle[PartType.Wheel] = new Wheels {Id = "B102", Name = "MotorCycle Wheels", NumberOfItems = 2};
            return this;
        }

        public override VehiclesBuilder BuildDoors()
        {
            DisplayLog("Building MotorCycle\'s Doors");
            CurrentVehicle[PartType.Door] = new Doors {Id = "B103", Name = "MotorCycle Door", NumberOfItems = 0};
            return this;
        }
        #endregion
    }

}