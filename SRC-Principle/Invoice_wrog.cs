
namespace SRC_Principle
{
    public class Invoice_wrog
    {
        private Book book;
        private int quantity;
        private double discountRate;
        private double taxRate;
        private double total;

        public Invoice_wrog(Book book, int quantity)
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

        public void printInvoice()
        {
            Console.WriteLine(quantity + "x " + book.Name + " " + book.Price + "$");
            Console.WriteLine("Total: " + total);
        }

        public void saveToFile(String filename)
        {
            // Creates a file with given name and writes the invoice
        }
    }
}
