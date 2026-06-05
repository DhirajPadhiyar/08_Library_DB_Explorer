namespace _08_Library_DB_Explorer.Models
{
    public class IssuedBooks
    {
        public int IssuedBooksId { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
