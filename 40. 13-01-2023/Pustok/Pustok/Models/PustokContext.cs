﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pustok.Models
{
    public class PustokContext : IdentityDbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
    }
}
