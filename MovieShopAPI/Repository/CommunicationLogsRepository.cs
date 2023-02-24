using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;
using MovieShopApplication.Models;

namespace MovieShopApplication.Repository
{
    public class CommunicationLogsRepository : RepositoryBase<CommunicationLogs>,ICommunicationLogsRepository
    {
        public CommunicationLogsRepository(MovieShopContext movieShopContext) :base(movieShopContext)
        {

        }
    }
}
