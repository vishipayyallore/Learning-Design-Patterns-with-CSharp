using System;
using Abstract.AnimalWorldV2.AbstractFactory;
using Abstract.AnimalWorldV2.AbstractProduct;
using Abstract.AnimalWorldV2.ConcreteFactory;
using Abstract.AnimalWorldV2.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abstract.AnimalWorldV2Tests
{
    //TODO: Add Assertions
    [TestClass]
    public class AnimalsFactoryTest
    {
        [TestMethod]
        public void When_AfricanFactory_IsCreated_Then_ItShouldReturn_OfWildBeestNLion()
        {
            IAnimalsFactory animalsFactory = new AfricanAnimals();
            Console.WriteLine(animalsFactory.GetCarnivore().DescribeAnimal());
            Console.WriteLine(animalsFactory.GetHerbivore().DescribeAnimal());
        }

        [TestMethod]
        public void When_AmericanFactory_IsCreated_Then_ItShouldReturn_OfBisonNWolf()
        {
            IAnimalsFactory animalsFactory = new AmericanAnimals();
            Console.WriteLine(animalsFactory.GetCarnivore().DescribeAnimal());
            Console.WriteLine(animalsFactory.GetHerbivore().DescribeAnimal());
        }

    }

}