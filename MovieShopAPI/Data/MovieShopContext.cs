using Microsoft.EntityFrameworkCore;
using MovieShopApplication.Models;
using MovieShopApplication.NewFolder;

namespace MovieShopApplication.Data
{
    public class MovieShopContext : DbContext
    {
    
    public MovieShopContext(DbContextOptions Options) : base(Options)
    {
    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>()
                .HasOne<Staff>(s => s.Staff)
                .WithOne(st => st.Shop)
                .HasForeignKey<Staff>(st => st.StaffId);
            modelBuilder.Entity<Staff>()
                           .HasOne<Shop>(st => st.Shop)
                           .WithOne(s => s.Staff)
                           .HasForeignKey<Shop>(s => s.ShopId);
        }

        public DbSet<ShopOwner> shopOwners { get; set; }
    public DbSet<Staff> staff { get; set; }
    public DbSet<Shop> shops { get; set; }
    public DbSet<Payment> payments { get; set; }
    public DbSet<MovieGenre> movieGenre { get; set; }
    public DbSet<Movie> movies { get; set; }
    public DbSet<Genre> genres { get; set; }
    public DbSet<Customer> customer { get; set; }
    public DbSet<CustomerMovie> customerMovie { get; set; }
    public DbSet<CommunicationLogs> communicationLogs { get; set; }
    public DbSet<CommunicationTypes> communicationTypes { get; set; }
    //public DbSet<CommonColumn> commonColumn { get; set; }
    }
   
}
