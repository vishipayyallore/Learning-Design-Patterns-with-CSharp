using Builder.BuildVehicles.Builder;

namespace Builder.BuildVehicles.Director
{

    public class Shop
    {
        #region Methods.
        public void Construct(VehiclesBuilder vehiclesBuilder)
        {
            vehiclesBuilder
                .BuildFrame()
                .BuildEngine()
                .BuildWheels()
                .BuildDoors()
                .DisplayVehicle();
        }
        #endregion
    }

}