using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;
using MovieShopApplication.Models;

namespace MovieShopApplication.Repository
{
    public class CustomerMovieRepository : RepositoryBase<CustomerMovie>, ICustomerMovieRepository
    {
        public CustomerMovieRepository(MovieShopContext movieShopContext) : base(movieShopContext)
        {

        }
    }
}
