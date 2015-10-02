using Builder.BuildVehicles.Builder;

namespace Builder.BuildVehicles.Director
{

    public class Shop
    {
        #region Methods.
        public Shop Construct(VehiclesBuilder vehiclesBuilder)
        {
            vehiclesBuilder
                .BuildFrame()
                .BuildEngine()
                .BuildWheels()
                .BuildDoors()
                .DisplayVehicle();
            return this;
        }
        #endregion
    }

}