using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("Customer")]
    public class Customer
    {
    
        public int CustomerId { get; set; }
        [Required,StringLength(100)]
        [Display(Name ="Name")]
        public string? CustomerName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Contact { get; set; }
        [Required]
        public string? Address { get; set; }
    }
}
