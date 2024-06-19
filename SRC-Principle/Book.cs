
namespace SRC_Principle
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }

        //constructor
        public Book(String name, String authorName, int price)
        {
            this.Name = name;
            this.AuthorName = authorName;
            this.Price = price;
        }
    }
}
