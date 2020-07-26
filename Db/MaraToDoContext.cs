using MaraToDoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MaraToDoApi.Db
{
    public class MaraToDoContext : DbContext
    {
        public MaraToDoContext(DbContextOptions<MaraToDoContext> options)
            : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Apple" });
        }
    }
}