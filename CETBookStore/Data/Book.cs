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
        [Display(Name = "Page Number")]
        public int PageNumber { get; set; }
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; } //'DateOnly' kullandım fakat hata aldım => DateTime kullanıyorum. 

        public int? PublisherId; // '?' işareti = nullable.
        public virtual Publisher? Publisher { get; set; }

        public int CategoryId;
        public virtual Category? Category { get; set; }

    }

    public class UserInformation
    {
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Display(Name = "User Adress")]
        public string UserAdress { get; set; }
        [Display(Name = "Credit Card Info")]
        public string CreditCard { get; set; }
    }

    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book>? Books { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public virtual List<Book>? Books { get; set; } = new List<Book>();
    }
}
