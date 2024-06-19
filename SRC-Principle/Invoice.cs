
namespace SRC_Principle
{
    public class Invoice
    {
        public int quantity { get; set; }
        public double total { get; set; }
        public int Price { get; set; }

        private Book book;

        public Invoice(Book book, int quantity)
        {
            this.book = book;
            this.quantity = quantity;
            this.total = this.calculateTotal();
        }

        public double calculateTotal()
        {
            double priceWithTaxes = (book.Price * this.quantity);

            return priceWithTaxes;
        }
    }
}
