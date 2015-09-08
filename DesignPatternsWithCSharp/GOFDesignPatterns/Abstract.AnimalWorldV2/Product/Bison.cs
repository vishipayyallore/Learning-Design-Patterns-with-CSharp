using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.AnimalWorldV2.AbstractProduct;

namespace Abstract.AnimalWorldV2.Product
{

    public class Bison : IHerbivore
    {
        #region Properties
        public string AnimalType => GetType().GetInterface("IHerbivore", false).Name;
        #endregion

        #region Methods.
        public string DescribeAnimal()
        {
            return $" I am {GetType().Name}. I live in America. I am a kind of {AnimalType}.";
        }

        string IHerbivore.Eats()
        {
            //TODO: replace this code with MongoDB
            return $" I eat 2 Kgs of Green OR Dry Grass.";
        }
        #endregion
    }

}
