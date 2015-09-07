namespace Abstract.AnimalWorld.AbstractProduct
{

    public abstract class Herbivore
    {
        #region Properties.
        public string AnimalType => GetType().Name;
        #endregion

        #region Abstract Methods
        public abstract string DescribeMe();
        #endregion
    }

}
