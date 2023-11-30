using Microsoft.EntityFrameworkCore;

namespace CloudWeather.Report.DataContext
{
    public class ReportDbContext : DbContext
    {
        public DbSet<Report.Entities.WeatherReport> Reports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server = QUANMOVIT\\SQLEXPRESS; database = Cloud_Report; integrated security = sspi; Encrypt = true; TrustServerCertificate = true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SnakeCaseIdentityTableNames(modelBuilder);
        }

        private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Report.Entities.WeatherReport>(b =>
            {
                b.ToTable("weatherReport");
            });
        }
    }
}
