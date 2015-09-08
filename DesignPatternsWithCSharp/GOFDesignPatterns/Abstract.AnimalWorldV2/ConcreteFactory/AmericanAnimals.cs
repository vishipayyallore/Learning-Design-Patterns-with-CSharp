using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.AnimalWorldV2.AbstractFactory;
using Abstract.AnimalWorldV2.AbstractProduct;
using Abstract.AnimalWorldV2.Product;

namespace Abstract.AnimalWorldV2.ConcreteFactory
{

    public class AmericanAnimals : IAnimalsFactory
    {
        #region Methods.
        public IHerbivore GetHerbivore()
        {
            return new Bison();
        }

        public ICarnivore GetCarnivore()
        {
            return new Wolf();
        }
        #endregion
    }

}
