using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.AnimalWorldV2.AbstractProduct;

namespace Abstract.AnimalWorldV2.Product
{

    public class Wildebeest : IHerbivore
    {

        public string AnimalType
        {
            get {  return GetType().GetInterface("IHerbivore", false).Name; }
        }
            

        public string DescribeAnimal()
        {
            return $" I am {GetType().Name}. I live in America. I am a kind of {AnimalType}.";
        }

        string IHerbivore.Eats()
        {
            return $" I eat 2 Kgs of Green Grass.";
        }
    }

}
