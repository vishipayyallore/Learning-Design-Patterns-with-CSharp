using Builder.BuildVehicles.Product;

namespace Builder.BuildVehicles.Builder
{

    public abstract class VehiclesBuilder
    {
        #region Variables
        protected Vehicle CurrentVehicle;
        #endregion

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