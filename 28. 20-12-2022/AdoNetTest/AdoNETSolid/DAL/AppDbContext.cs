using AdoNETSolid.Models;
using Microsoft.EntityFrameworkCore;

namespace AdoNETSolid.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CATALYST\\SQLEXPRESS;Database=BB201EFCFirst;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }
    }
}
