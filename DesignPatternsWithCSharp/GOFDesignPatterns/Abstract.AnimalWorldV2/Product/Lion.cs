using Abstract.AnimalWorldV2.AbstractProduct;

namespace Abstract.AnimalWorldV2.Product
{
    public sealed class Lion : ICarnivore
    {
        #region Properties
        public string AnimalType => GetType().GetInterface("ICarnivore", false).Name;
        #endregion

        #region
        public string DescribeAnimal()
        {
            return $" I am {GetType().Name}. I live in Africa. I am a kind of {AnimalType}.";
        }

        string ICarnivore.Eats(IHerbivore herbivore)
        {
            //TODO: replace this code with MongoDB
            return $"{GetType().Name} eats {herbivore.GetType().Name}";
        }
        #endregion
    }
}
