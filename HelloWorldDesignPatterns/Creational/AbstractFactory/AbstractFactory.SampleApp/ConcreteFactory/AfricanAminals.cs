using AbstractFactory.SampleApp.AbstractFactory;
using AbstractFactory.SampleApp.AbstractProduct;
using AbstractFactory.SampleApp.Product;

namespace AbstractFactory.SampleApp.ConcreteFactory
{

    public class AfricanAminals : IContinentFactory
    {
        #region Methods
        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
        #endregion
    }

}