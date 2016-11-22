using AbstractFactory.SampleApp.AbstractFactory;
using AbstractFactory.SampleApp.AbstractProduct;

namespace AbstractFactory.SampleApp.Client
{

    public class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
    {
        #region Variables.
        private readonly IHerbivore _herbivore;
        private readonly ICarnivore _carnivore;

        #endregion

        public AnimalWorld()
        {
            var animalFactory = new T();

            _herbivore = animalFactory.CreateHerbivore();
            _carnivore = animalFactory.CreateCarnivore();
        } 

        #region Methods
        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
        #endregion
    }

}