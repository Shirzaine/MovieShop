using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;

namespace MovieShopApplication.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MovieShopContext _movieShopContext;
        private IStaffRepository _staff;
        private IShopOwnerRepository _shopOwner;
        private IShopRepository _shop;
        private IMovieGenreRepository _movieGenre;
        private IMovieRepository _movie;
        private IGenreRepository _genre;
        private ICustomerMovieRepository _customerMovie;
        private ICommunicationLogsRepository _communicationLogs;
        public IStaffRepository Staff
        {
            get
            {
                if (_staff == null)
                {
                    _staff = new StaffRepository(_movieShopContext);
                }
                return _staff;
            }
        }
        public IShopOwnerRepository Account
        {
            get
            {
                if (_shopOwner == null)
                {
                    _shopOwner = new ShopOwnerRepository(_movieShopContext);
                }
                return _shopOwner;
            }
        }

        public IShopRepository Shop
        {
            get
            {
                if (_shop == null)
                {
                    _shop = new ShopRepository(_movieShopContext);
                }
                return _shop;
            }
        }
        public IMovieGenreRepository MovieGenre
        {
            get
            {
                if (_movieGenre == null)
                {
                    _movieGenre = new MovieGenreRepository(_movieShopContext);
                }
                return _movieGenre;
            }
        }

        public IMovieRepository Movie
        {
            get
            {
                if (_movie == null)
                {
                    _movie = new MovieRepository(_movieShopContext);
                }
                return _movie;
            }
        }

        public IGenreRepository Genre
        {
            get
            {
                if (_genre == null)
                {
                    _genre = new GenreRepository(_movieShopContext);
                }
                return _genre;
            }
        }
        public ICustomerMovieRepository CustomerMovie
        {
            get
            {
                if (_customerMovie == null)
                {
                    _customerMovie = new CustomerMovieRepository(_movieShopContext);
                }
                return _customerMovie;
            }
        }

        public ICommunicationLogsRepository CommunicationLogs
        {
            get
            {
                if (_communicationLogs == null)
                {
                    _communicationLogs = new CommunicationLogsRepository(_movieShopContext);
                }
                return _communicationLogs;
            }
        }

        public IShopOwnerRepository ShopOwner => throw new NotImplementedException();

        public RepositoryWrapper(MovieShopContext movieShopContext)
        {
            _movieShopContext = movieShopContext;
        }
        public void Save()
        {
            _movieShopContext.SaveChanges();
        }
    }
}

