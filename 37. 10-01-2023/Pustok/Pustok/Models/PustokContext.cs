using Microsoft.EntityFrameworkCore;

namespace Pustok.Models
{
    public class PustokContext : DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
    }
}
