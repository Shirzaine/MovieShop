using MovieShopApplication.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.NewFolder
{
    [Table("ShopOwner")]
    public class ShopOwner
    {
        public int ShopOwnerId { get; set; }
        [Required,StringLength(100)]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required,StringLength(100)]
        [Display(Name ="Last Name")]
        public string? LastName { get; set; }
        [Required,StringLength (100)]
        public string? Email { get; set; }
        [Required]
        public string? Contact { get; set; }

        public ICollection<Shop> Shops { get; set; }
    }
}
