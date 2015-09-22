using System;
using System.Collections.Generic;
using Builder.BuildVehiclesV2.Infrastructure;
using Builder.BuildVehiclesV2.VehicleParts;

namespace Builder.BuildVehiclesV2.Product
{
    public class Vehicle
    {

        #region Variables
        private readonly VehicleType _vehicleType;
        private readonly Dictionary<PartType, Part> _parts =  new Dictionary<PartType, Part>();
        #endregion


        public Vehicle(VehicleType vehicleType)
        {
            _vehicleType = vehicleType;
        }

        #region Indexers
        public Part this[PartType partType]
        {
            get { return _parts[partType]; }
            set { _parts[partType] = value; }
        }
        #endregion

        #region Methods
        public void DisplayVehicle()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame  : {0}", _parts[PartType.Frame].Name);
            Console.WriteLine(" Enginee  : {0}", (_parts[PartType.Engine] as Engine)?.Speed);
            Console.WriteLine(" Doors  : {0}", (_parts[PartType.Door] as Doors)?.NumberOfItems);
            Console.WriteLine(" Wheels  : {0}", (_parts[PartType.Wheel] as Wheels)?.NumberOfItems);
        }
        #endregion

    }
}