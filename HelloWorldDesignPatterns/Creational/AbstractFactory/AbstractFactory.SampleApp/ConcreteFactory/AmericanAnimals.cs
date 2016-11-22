using AbstractFactory.SampleApp.AbstractFactory;
using AbstractFactory.SampleApp.AbstractProduct;
using AbstractFactory.SampleApp.Product;

namespace AbstractFactory.SampleApp.ConcreteFactory
{

    public class AmericanAnimals : IContinentFactory
    {
        #region
        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }
        #endregion
    }

}