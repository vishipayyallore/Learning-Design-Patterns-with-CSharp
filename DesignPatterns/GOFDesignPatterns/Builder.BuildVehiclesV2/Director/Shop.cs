using System;
using Builder.BuildVehiclesV2.Builder;

namespace Builder.BuildVehiclesV2.Director
{

    public class Shop
    {

        #region Methods.
        public Shop Construct(VehiclesBuilder vehiclesBuilder)
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Construction");
            Console.WriteLine("---------------------------");
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