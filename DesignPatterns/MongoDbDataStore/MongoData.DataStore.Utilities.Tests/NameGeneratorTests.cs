using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MongoData.DataStore.Utilities.Tests
{

    [TestClass]
    public class NameGeneratorTests
    {

        [TestMethod]
        public void When_10Characters_NameIsGenerated()
        {
            for (var iCtr = 0; iCtr <= 10000; iCtr++)
            {
                const int length = 10;
                var name = NameGenerator.GenerateName(length);
                Console.WriteLine("Generated Name Value: {0}", name);
                //Assert.AreEqual(length, name.Length);
            }
        }

    }

}