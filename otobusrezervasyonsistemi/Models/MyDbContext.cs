using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace otobusrezervasyonsistemi.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityColumns();
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Buses> Buses { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<Passengers> Passengers { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<BusArmchair> BusArmchairs { get; set; }
    }
}
