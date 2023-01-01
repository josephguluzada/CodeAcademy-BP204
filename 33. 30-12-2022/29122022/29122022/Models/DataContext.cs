using Microsoft.EntityFrameworkCore;

namespace _29122022.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PortfolioImage> PortfolioImages { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
