using System;
using System.Collections.Generic;
using Builder.BuildVehicles.Infrastructure;
using Builder.BuildVehicles.VehicleParts;

namespace Builder.BuildVehicles.Product
{

    public class Vehicle
    {
        #region Variables.
        private readonly string _vehicleType;
        private readonly Dictionary<string, Part> _parts =  new Dictionary<string, Part>();
        #endregion

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        #region Indexer
        public Part this[string partName]
        {
            get { return _parts[partName]; }
            set { _parts[partName] = value; }
        }
        #endregion

        #region Methods
        public void DisplayVehicle()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame  : {0}", _parts[PartNames.Frame].Name);
            Console.WriteLine(" Enginee  : {0}", (_parts[PartNames.Engine] as Engine)?.Speed);
            Console.WriteLine(" Doors  : {0}", (_parts[PartNames.Doors] as Doors)?.NumberOfItems);
            Console.WriteLine(" Wheels  : {0}", (_parts[PartNames.Wheels] as Wheels)?.NumberOfItems);
        }
        #endregion
    }

}
