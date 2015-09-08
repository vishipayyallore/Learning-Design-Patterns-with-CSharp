namespace Abstract.AnimalWorldV2.AbstractProduct
{

    public interface IAnimal
    {
        #region Properties
        string AnimalType { get; }
        #endregion

        #region Methods
        string DescribeAnimal();
        #endregion
    }

}