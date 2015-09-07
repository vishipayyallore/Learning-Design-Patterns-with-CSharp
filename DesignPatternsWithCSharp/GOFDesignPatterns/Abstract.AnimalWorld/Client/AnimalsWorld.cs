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
        public string RunFoodChain()
        {
            return _carnivore.Eats(_herbivore);
        }
        #endregion
    }

}
