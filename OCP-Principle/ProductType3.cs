
namespace OCP_Principle
{
    public class ProductType3:Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 10;
        }
    }
}
