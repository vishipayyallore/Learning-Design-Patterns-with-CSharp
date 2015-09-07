using Abstract.AnimalWorld.AbstractProduct;

namespace Abstract.AnimalWorld.AbstractFactory
{

    public abstract class AnimalsFactory
    {
        #region Methods
        public abstract Herbivore GetHerbivore();
        public abstract Carnivore GetCarnivore();
        #endregion
    }

}
