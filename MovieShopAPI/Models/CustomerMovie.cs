using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("CustomerMovie")]
    public class CustomerMovie
    {
        public Guid CustomerMovieId { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOfRental { get; set; }
        [Display(Name ="Return Date")]
        public DateTime ExpectedReturnDate { get; set; }

        public ICollection<Movie> Movies { get; set; }
        public ICollection<Customer> Customers  { get; set; }
    }
}
