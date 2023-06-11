using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class DealershipDBContext : DbContext
    {

        public DealershipDBContext()
        {

        }
        public DealershipDBContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if (!OptionsBuilder.IsConfigured)
            {
                OptionsBuilder.UseSqlServer("Server=DESKTOP-IU1LH1E;Database=DealershipDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
            base.OnConfiguring(OptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}