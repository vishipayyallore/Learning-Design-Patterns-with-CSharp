using Abstract.AnimalWorld.AbstractProduct;

namespace Abstract.AnimalWorld.Product
{

    public class Bison : Herbivore
    {
        #region Methods
        public override string DescribeMe()
        {
            return $" I am {GetType().Name} live in America. I am a {base.GetType().Name}";
        }
        #endregion
    }

}
