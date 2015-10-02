using System;
using Abstract.AnimalWorld.AbstractFactory;
using Abstract.AnimalWorld.AbstractProduct;

namespace Abstract.AnimalWorld.Client
{

    public class AnimalsWorld
    {
        #region Variables.
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;
        #endregion

        public AnimalsWorld(AnimalsFactory animalsFactory)
        {
            _herbivore = animalsFactory.GetHerbivore();
            _carnivore = animalsFactory.GetCarnivore();
        }

        #region Methods

        public AnimalsWorld ShowAnimals()
        {
            Console.WriteLine(_herbivore.DescribeMe());
            Console.WriteLine(_carnivore.DescribeMe());
            return this;
        }

        public AnimalsWorld RunFoodChain()
        {
            Console.WriteLine(_carnivore.Eats(_herbivore));
            return this;
        }
        #endregion
    }

}
