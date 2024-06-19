namespace OCP_Principle
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int PriceType { get; set; }


        public virtual double GetDiscount()
        {
            return 0;
        }
    }
}
