namespace Abstract.AnimalWorld.AbstractProduct
{

    public abstract class Carnivore
    {
        #region Properties.
        public string AnimalType => GetType().Name;
        #endregion

        #region Methods
        public string Eats(Herbivore herbivore)
        {
            return $"{GetType().Name} eats {herbivore.GetType().Name}";
        }
        #endregion

        #region Abstract Methods
        public abstract string DescribeMe();
        #endregion
    }

}
