using System.ComponentModel.DataAnnotations;

namespace CETBookStore.Data
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)] //data annotation
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int PageNumber { get; set; }
        public DateTime PublishDate { get; set; } //'DateOnly' kullandım fakat hata aldım => DateTime kullanıyorum. 

        public int? PublisherId; // '?' işareti = nullable.
        public virtual Publisher? Publisher { get; set; }

        public int CategoryId;
        public virtual Category? Category { get; set; }

    }

    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book>? Books { get; set; }
    }
    //public class Category
    //{
    //    public int Id { get; set; }
    //    [MaxLength(30)]
    //    public string Name { get; set; }
    //    public virtual List<Book>? Books { get; set; }
    //}
}
