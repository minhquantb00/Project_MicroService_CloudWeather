using CloudWeather.Temperature.Entities;
using Microsoft.EntityFrameworkCore;

namespace CloudWeather.Temperature.DataContext
{
    public class TempeDbContext : DbContext
    {
        public DbSet<Temperature.Entities.Temperature> Temperatures { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
                optionsBuilder.UseSqlServer("server = QUANMOVIT\\SQLEXPRESS; database = Cloud_Temperature; integrated security = sspi; Encrypt = true; TrustServerCertificate = true");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SnakeCaseIdentityTableNames(modelBuilder);
        }

        private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Temperature.Entities.Temperature>(b =>
            {
                b.ToTable("temperature");
            });
        }
    }
}
