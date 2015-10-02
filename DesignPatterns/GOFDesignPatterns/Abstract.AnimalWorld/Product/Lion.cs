using Abstract.AnimalWorld.AbstractProduct;

namespace Abstract.AnimalWorld.Product
{

    public class Lion : Carnivore
    {
        #region Methods.
        public override string DescribeMe()
        {
            return $" I am {GetType().Name}. I live in Africa. I am a kind of {AnimalType}.";
        }
        #endregion
    }

}
