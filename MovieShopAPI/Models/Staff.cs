using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("Staff")]
    public class Staff
    {
        public Guid StaffId { get; set; }
        [Required,StringLength(100)]
        public string? Name { get; set; }
        [Required]
        public string? Contact { get; set; }
        [Required,StringLength(100)]
        public string? Email { get; set; }
        public Shop Shop { get; set; }
    }
}
