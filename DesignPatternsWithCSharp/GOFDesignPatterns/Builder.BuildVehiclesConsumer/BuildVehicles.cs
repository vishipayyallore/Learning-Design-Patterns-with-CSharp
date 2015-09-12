using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.BuildVehicles.ConcreteBuilder;
using Builder.BuildVehicles.Director;

namespace Builder.BuildVehiclesConsumer
{
    public class BuildVehicles
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                var shop = new Shop();
                shop
                    .Construct(new ScooterBuilder())
                    .Construct(new MotorCycleBuilder())
                    .Construct(new CarBuilder());
            }
            catch (Exception error)
            {
                Console.WriteLine("\n\nError occured at BuildVehicles::Main(). Message: {0}", error.Message);
            }
            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }

}
