using System;
using Abstract.AnimalWorldV2.AbstractFactory;
using Abstract.AnimalWorldV2.AbstractProduct;

namespace Abstract.AnimalWorldV2.Client
{

    public class AnimalsWorld<T> : IAnimalsWorld where T: IAnimalsFactory, new ()
    {

        #region Variables.
        private readonly IHerbivore _herbivoreAnimal;
        private readonly ICarnivore _carnivoreAnimal;

        #endregion

        public  AnimalsWorld()
        {
            var animalsFactory = new T();
            _herbivoreAnimal = animalsFactory.GetHerbivore();
            _carnivoreAnimal = animalsFactory.GetCarnivore();
        }

        #region Methods.
        public IAnimalsWorld ShowAnimals()
        {
            Console.WriteLine(_herbivoreAnimal.DescribeAnimal());
            Console.WriteLine(_carnivoreAnimal.DescribeAnimal());
            return this;
        }

        public IAnimalsWorld RunFoodChain()
        {
            Console.WriteLine(_carnivoreAnimal.Eats(_herbivoreAnimal));
            return this;
        }
        #endregion
    }

}