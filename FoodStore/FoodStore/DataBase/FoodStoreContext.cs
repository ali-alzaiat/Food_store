using FoodStore.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodStore.DataBase
{
    public class FoodStoreContext : DbContext
    {
        public DbSet<Products> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Store.db");
        }
    }
}
