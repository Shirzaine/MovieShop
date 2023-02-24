using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;
using MovieShopApplication.NewFolder;

namespace MovieShopApplication.Repository
{
    public class ShopOwnerRepository : RepositoryBase<ShopOwner>, IShopOwnerRepository
    {
        public ShopOwnerRepository(MovieShopContext movieShopContext) : base(movieShopContext)
        { }
    }
}
