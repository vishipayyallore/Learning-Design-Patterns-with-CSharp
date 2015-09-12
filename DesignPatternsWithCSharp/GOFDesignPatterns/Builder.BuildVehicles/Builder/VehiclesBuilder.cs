using Builder.BuildVehicles.Product;

namespace Builder.BuildVehicles.Builder
{

    public abstract class VehiclesBuilder
    {
        #region Variables
        protected Vehicle CurrentVehicle;
        #endregion

        #region Methods
        public abstract VehiclesBuilder BuildFrame();
        public abstract VehiclesBuilder BuildEngine();
        public abstract VehiclesBuilder BuildWheels();
        public abstract VehiclesBuilder BuildDoors();
        #endregion
    }

}