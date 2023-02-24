using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;
using MovieShopApplication.Models;

namespace MovieShopApplication.Repository
{
    public class StaffRepository : RepositoryBase<Staff>, IStaffRepository   
    {
        public StaffRepository(MovieShopContext movieShopContext)
            :base(movieShopContext)
        {

        }
    }
}
