using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("CommunicationTypes")]
    public class CommunicationTypes
    {
        [Key]
        public Guid CommunicationTypeId { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string? CommunicationName { get; set; }
        public string? Description { get; set; }
    }
}
