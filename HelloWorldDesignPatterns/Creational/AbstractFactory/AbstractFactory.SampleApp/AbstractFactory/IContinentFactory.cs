using AbstractFactory.SampleApp.AbstractProduct;

namespace AbstractFactory.SampleApp.AbstractFactory
{

    public interface IContinentFactory
    {
        #region Methods
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
        #endregion
    }

}