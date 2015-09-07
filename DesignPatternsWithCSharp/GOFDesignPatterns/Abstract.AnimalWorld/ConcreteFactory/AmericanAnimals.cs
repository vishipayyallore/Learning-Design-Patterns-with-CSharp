using Abstract.AnimalWorld.AbstractFactory;
using Abstract.AnimalWorld.AbstractProduct;
using Abstract.AnimalWorld.Product;

namespace Abstract.AnimalWorld.ConcreteFactory
{

    public class AmericanAnimals : AnimalsFactory
    {
        #region Methods
        public override Herbivore GetHerbivore()
        {
            return new Bison();
        }

        public override Carnivore GetCarnivore()
        {
            return new Wolf();
        }
        #endregion
    }

}
