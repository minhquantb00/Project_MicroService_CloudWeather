using CloudWeather.Precipitation.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CloudWeather.Precipitation.DataContext
{
    public class PrecipDbContext : DbContext
    {

        public DbSet<Precipitation.DataAccess.Precipitation> Precipitations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
                optionsBuilder.UseSqlServer("server = QUANMOVIT\\SQLEXPRESS; database = Cloud_Precipitation; integrated security = sspi; Encrypt = true; TrustServerCertificate = true");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SnakeCaseIdentityTableNames(modelBuilder);
        }

        private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Precipitation.DataAccess.Precipitation>(b =>
            {
                b.ToTable("precipitation");
            });
        }
    }
}
