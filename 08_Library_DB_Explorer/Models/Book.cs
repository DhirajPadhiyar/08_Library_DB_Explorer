namespace _08_Library_DB_Explorer.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int PublicationYear { get; set; }
        public decimal Price { get; set; }
    }
}
