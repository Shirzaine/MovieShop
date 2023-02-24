using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("Shop")]
    public class Shop
    {
        public Guid ShopId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int ShopOwnerId { get; set; }
       public Staff Staff { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
