using System;
using System.Globalization;
using AbstractFactory.SampleApp.Client;
using AbstractFactory.SampleApp.ConcreteFactory;
using static System.Console;

namespace AbstractFactory.SampleApp
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            const string dateTimeFormat = @"MM / dd / yyyy HH: mm: ss.fff";
            WriteLine("Start -> {0}\n", DateTime.Now.ToString(dateTimeFormat, CultureInfo.InvariantCulture));

            var africaAnimals = new AnimalWorld<AfricanAminals>();
            africaAnimals.RunFoodChain();

            var americalAnimals = new AnimalWorld<AmericanAnimals>();
            americalAnimals.RunFoodChain();

            WriteLine("\nEnd -> {0}", DateTime.Now.ToString(dateTimeFormat, CultureInfo.InvariantCulture));
            WriteLine("\n\nPress any key ....");
            ReadKey();
        }
    }
}
