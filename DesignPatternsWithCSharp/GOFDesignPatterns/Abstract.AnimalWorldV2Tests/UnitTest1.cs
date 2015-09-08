using System;
using Abstract.AnimalWorldV2.AbstractProduct;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abstract.AnimalWorldV2.Product;

namespace Abstract.AnimalWorldV2Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            IAnimal wildBeest = new Wildebeest();
            Console.WriteLine(wildBeest.AnimalType);
        }

    }
}
