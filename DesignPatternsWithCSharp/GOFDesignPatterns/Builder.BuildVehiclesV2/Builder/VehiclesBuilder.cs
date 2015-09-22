using Builder.BuildVehiclesV2.Infrastructure;
using Builder.BuildVehiclesV2.Product;

namespace Builder.BuildVehiclesV2.Builder
{

    public abstract class VehiclesBuilder
    {
        #region Variables
        protected Vehicle CurrentVehicle;
        #endregion

        protected VehiclesBuilder(VehicleType vehicleType)
        {
            CurrentVehicle = new Vehicle(vehicleType);
        }

        #region Methods
        public VehiclesBuilder DisplayVehicle()
        {
            CurrentVehicle.DisplayVehicle();
            return this;
        }
        #endregion

        #region Abstract Methods
        public abstract VehiclesBuilder BuildFrame();
        public abstract VehiclesBuilder BuildEngine();
        public abstract VehiclesBuilder BuildWheels();
        public abstract VehiclesBuilder BuildDoors();
        #endregion
    }

}