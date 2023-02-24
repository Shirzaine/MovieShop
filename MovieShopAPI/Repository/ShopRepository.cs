using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;
using MovieShopApplication.Models;

namespace MovieShopApplication.Repository
{
    public class ShopRepository : RepositoryBase<Shop>, IShopRepository
    {
        public ShopRepository (MovieShopContext movieShopContext) : base(movieShopContext)
        { }
    }
}
