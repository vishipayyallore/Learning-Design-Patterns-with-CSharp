using System;
using Builder.BuildVehiclesV2.ConcreteBuilder;
using Builder.BuildVehiclesV2.Director;

namespace Builder.BuildVehiclesV2Consumer
{
    public class BuildVehiclesV2
    {
        static void Main()
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
