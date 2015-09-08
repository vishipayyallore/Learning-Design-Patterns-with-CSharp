﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.AnimalWorldV2.AbstractFactory;
using Abstract.AnimalWorldV2.Client;
using Abstract.AnimalWorldV2.ConcreteFactory;

namespace Abstract.AnimalWorldV2Consumer
{
    class AnimalWorldV2
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                var animalsWorld = new AnimalsWorld<AfricanAnimals>();
                animalsWorld
                    .ShowAnimals()
                    .RunFoodChain();

                Console.WriteLine("\n");
                var animalsWorld1 = new AnimalsWorld<AmericanAnimals>();
                animalsWorld1
                    .ShowAnimals()
                    .RunFoodChain();
            }
            catch (Exception error)
            {
                Console.WriteLine("\n\nError occured at WorldConsumer::Main(). Message: {0}", error.Message);
            }
            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }
    }

}
