using Abstract.AnimalWorldV2.AbstractProduct;

namespace Abstract.AnimalWorldV2.AbstractFactory
{

    public interface IAnimalsFactory
    {
        #region Methods.
        IHerbivore GetHerbivore();

        ICarnivore GetCarnivore();
        #endregion
    }

}