﻿
namespace OCP_Principle
{
    public class ProductType2:Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 10;
        }
    }
}
