using Abstract.AnimalWorld.AbstractProduct;

namespace Abstract.AnimalWorld.Product
{

    public class Wildebeest : Herbivore
    {
        #region Methods.
        public override string DescribeMe()
        {
            return $" I am {GetType().Name} live in Africa. I am a {base.GetType().Name}";
        }
        #endregion
    }

}
