
namespace OCP_Principle
{
    public class Product_wrong
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int PriceType { get; set; }


        public double GetDiscount()
        {
            if (PriceType == 1) return (Price / 100) * 5;
            if (PriceType == 2) return (Price / 100) * 10;
            if (PriceType == 3) return (Price / 100) * 15;
            return 0;
        }
    }
}
