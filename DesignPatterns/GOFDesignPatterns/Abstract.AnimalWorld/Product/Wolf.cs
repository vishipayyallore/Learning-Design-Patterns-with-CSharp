﻿using Abstract.AnimalWorld.AbstractProduct;

namespace Abstract.AnimalWorld.Product
{
    public class Wolf : Carnivore
    {
        #region Methods.
        public override string DescribeMe()
        {
            return $" I am {GetType().Name}. I live in America. I am a kind of {AnimalType}.";
        }
        #endregion
    }
}
