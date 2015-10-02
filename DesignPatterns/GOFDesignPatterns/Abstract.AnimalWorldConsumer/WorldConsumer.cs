using System;
using Abstract.AnimalWorld.AbstractFactory;
using Abstract.AnimalWorld.Client;
using Abstract.AnimalWorld.ConcreteFactory;

namespace Abstract.AnimalWorldConsumer
{

    public class WorldConsumer
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            try
            {
                AnimalsFactory animalsFactory = new AfricanAnimals();
                ShowAnimalWorld(animalsFactory);

                Console.WriteLine("\n");
                animalsFactory = new AmericanAnimals();
                ShowAnimalWorld(animalsFactory);
            }
            catch (Exception error)
            {
                Console.WriteLine("\n\nError occured at WorldConsumer::Main(). Message: {0}", error.Message);
            }
            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

        private static void ShowAnimalWorld(AnimalsFactory animalsFactory)
        {
            Console.WriteLine("Animals World.");
            var animalsWorld = new AnimalsWorld(animalsFactory);
            animalsWorld
                .ShowAnimals()
                .RunFoodChain();
        }

    }

}
