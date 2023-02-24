using Microsoft.EntityFrameworkCore;
using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;
using MovieShopApplication.Models;

namespace MovieShopApplication.Repository
{
    public class MovieRepository: RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopContext movieShopContext) : base(movieShopContext)
        { }
        public IEnumerable<Movie> GetMovies()
        {
            return FindAll().OrderBy(m => m.MovieId).ToList();
        }








    }
}
