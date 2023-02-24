using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("Movie")]
    public class Movie
    {
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal RentalFee { get; set; }
        public decimal DefaulterFee { get; set; }
        public decimal Rating { get; set; }
        public string? CountryOfOrigin { get; set; }
        public int Rented { get; set; }
        public int IsPaid { get; set; }
        
        
    }
}
