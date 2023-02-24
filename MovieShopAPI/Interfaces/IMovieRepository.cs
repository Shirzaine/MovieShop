using MovieShopApplication.Models;

namespace MovieShopApplication.Interfaces
{
    public interface IMovieRepository : IRepositoryBase<Movie>
    {
        IEnumerable<Movie> GetMovies();
    }
}
