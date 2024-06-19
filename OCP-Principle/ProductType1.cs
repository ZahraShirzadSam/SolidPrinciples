
namespace OCP_Principle
{
    public class ProductType1 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 5;
        }
    }
}
