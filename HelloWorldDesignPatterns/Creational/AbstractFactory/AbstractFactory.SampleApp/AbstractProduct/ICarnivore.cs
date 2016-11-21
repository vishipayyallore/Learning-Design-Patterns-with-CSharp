namespace AbstractFactory.SampleApp.AbstractProduct
{

    public interface ICarnivore
    {
        #region Methods
        void Eat(IHerbivore herbivore);
        #endregion
    }

}