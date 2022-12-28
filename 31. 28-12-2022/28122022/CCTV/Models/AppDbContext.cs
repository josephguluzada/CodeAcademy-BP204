using Microsoft.EntityFrameworkCore;

namespace CCTV.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
