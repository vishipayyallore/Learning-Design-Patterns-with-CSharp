using Abstract.AnimalWorldV2.Client;
using Abstract.AnimalWorldV2.ConcreteFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abstract.AnimalWorldV2Tests
{

    //TODO: Add Assertions
    [TestClass]
    public class AnimalsWorldTest
    {

        [TestMethod]
        public void When_AfrianFactory_IsCreated_Then_ItShould_ShowAnimals()
        {
            var animalsWorld = new AnimalsWorld<AfricanAnimals>();
            animalsWorld
                .ShowAnimals()
                .RunFoodChain();
        }

        [TestMethod]
        public void When_AmericanFactory_IsCreated_Then_ItShould_ShowAnimals()
        {
            var animalsWorld = new AnimalsWorld<AmericanAnimals>();
            animalsWorld
                .ShowAnimals()
                .RunFoodChain();
        }

    }
}