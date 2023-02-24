using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("MovieGenre")]
    public class MovieGenre
    {
        public int MovieGenreId { get; set; }
        public int GenreId { get; set; }
        public int MovieId { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
