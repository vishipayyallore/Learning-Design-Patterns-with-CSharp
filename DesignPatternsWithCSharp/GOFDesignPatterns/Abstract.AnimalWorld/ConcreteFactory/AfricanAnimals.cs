using Abstract.AnimalWorld.AbstractFactory;
using Abstract.AnimalWorld.AbstractProduct;
using Abstract.AnimalWorld.Product;

namespace Abstract.AnimalWorld.ConcreteFactory
{

    public class AfricanAnimals : AnimalsFactory
    {
        #region Methods.
        public override Herbivore GetHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore GetCarnivore()
        {
            return new Lion();
        }
        #endregion
    }

}
