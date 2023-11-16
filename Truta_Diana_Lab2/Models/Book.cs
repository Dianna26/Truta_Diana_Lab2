using System.ComponentModel.DataAnnotations;

namespace Truta_Diana_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
