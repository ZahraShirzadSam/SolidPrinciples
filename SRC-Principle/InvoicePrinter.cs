
namespace SRC_Principle
{
    public class InvoicePrinter
    {
        private Invoice invoice;
        private Book book;

        public InvoicePrinter(Invoice invoice, Book book)
        {
            this.invoice = invoice;
            this.book = book;

        }

        public void printInvoice()
        {
            Console.WriteLine(invoice.quantity + "x " + book.Name + " " + book.Price + "$");
            Console.WriteLine("Total: " + invoice.total);
        }
    }
}
