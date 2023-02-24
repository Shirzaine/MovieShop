using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int GenreId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required,StringLength(200)]

        public string? Description { get; set; }
       public virtual ICollection<Movie> Movies { get; set; }
    }
}
