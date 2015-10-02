namespace Abstract.AnimalWorldV2.AbstractProduct
{

    public interface ICarnivore : IAnimal
    {
        #region
        string Eats(IHerbivore herbivore);
        #endregion
    }

}