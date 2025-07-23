using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain;

namespace OnlineShop.Application
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity relationships, indexes, etc. here
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        

    }
}
