namespace MovieShopApplication.Interfaces
{
    public interface IRepositoryWrapper
    {
        IStaffRepository Staff { get; }
        IShopOwnerRepository ShopOwner { get; }
        IShopRepository Shop { get; }
        IMovieGenreRepository MovieGenre { get; }
        IMovieRepository Movie { get; }
        IGenreRepository Genre { get; }
        ICustomerMovieRepository CustomerMovie { get; }
        ICommunicationLogsRepository CommunicationLogs { get; }
        void Save();
    }
}
