using static System.Console;
using AbstractFactory.SampleApp.AbstractProduct;

namespace AbstractFactory.SampleApp.Product
{

    public class Wolf : ICarnivore
    {
        #region Methods
        public void Eat(IHerbivore herbivore)
        {
            WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
        }
        #endregion
    }

}