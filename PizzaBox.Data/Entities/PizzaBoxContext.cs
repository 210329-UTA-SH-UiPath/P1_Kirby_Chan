using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Data.Entities
{
    class PizzaBoxContext : DbContext
    {
        public PizzaBoxContext()
        {

        }

        public PizzaBoxContext(DbContextOptions<PizzaBoxContext> options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Topping> Toppings { get; set; }
    }
}
