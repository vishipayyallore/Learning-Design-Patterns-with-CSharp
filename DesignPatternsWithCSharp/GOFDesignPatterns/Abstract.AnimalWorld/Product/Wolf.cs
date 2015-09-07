using Abstract.AnimalWorld.AbstractProduct;

namespace Abstract.AnimalWorld.Product
{
    public class Wolf : Carnivore
    {
        #region Methods.
        public override string DescribeMe()
        {
            return $" I am {GetType().Name} live in America. I am a {base.GetType().Name}";
        }
        #endregion
    }
}
