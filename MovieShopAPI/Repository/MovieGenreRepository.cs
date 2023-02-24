using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;
using MovieShopApplication.Models;

namespace MovieShopApplication.Repository
{
    public class MovieGenreRepository : RepositoryBase<MovieGenre>, IMovieGenreRepository
    {
        public MovieGenreRepository (MovieShopContext movieShopContext): base (movieShopContext)
        { }
    }
}
