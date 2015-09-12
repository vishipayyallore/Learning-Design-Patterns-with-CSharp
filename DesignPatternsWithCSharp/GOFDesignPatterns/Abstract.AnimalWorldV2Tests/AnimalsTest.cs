using System;
using Abstract.AnimalWorldV2.AbstractProduct;
using Abstract.AnimalWorldV2.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abstract.AnimalWorldV2Tests
{
    
    //TODO: Add Assertions
    [TestClass]
    public class AnimalsTest
    {

        [TestMethod]
        public void When_WildBeest_IsCreated_Then_ItShouldBe_OfIHerbivoreKind()
        {
            IHerbivore animal = new Wildebeest();
            Console.WriteLine(animal.AnimalType);
            Console.WriteLine(animal.DescribeAnimal());
            Console.WriteLine(animal.Eats());
        }

        [TestMethod]
        public void When_Bison_IsCreated_Then_ItShouldBe_OfIHerbivoreKind()
        {
            IHerbivore animal = new Bison();
            Console.WriteLine(animal.AnimalType);
            Console.WriteLine(animal.DescribeAnimal());
            Console.WriteLine(animal.Eats());
        }

        [TestMethod]
        public void When_Lion_IsCreated_Then_ItShouldBe_OfICarnivoreKind()
        {
            IHerbivore herbivoreAnimal = new Wildebeest();
            ICarnivore animal = new Lion();
            Console.WriteLine(animal.AnimalType);
            Console.WriteLine(animal.DescribeAnimal());
            Console.WriteLine(animal.Eats(herbivoreAnimal));
        }

        [TestMethod]
        public void When_Wolf_IsCreated_Then_ItShouldBe_OfICarnivoreKind()
        {
            IHerbivore herbivoreAnimal = new Bison();
            ICarnivore animal = new Wolf();
            Console.WriteLine(animal.AnimalType);
            Console.WriteLine(animal.DescribeAnimal());
            Console.WriteLine(animal.Eats(herbivoreAnimal));
        }

    }

}
