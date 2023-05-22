using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Resturnat.Core.Models;

namespace Resturant.Infrastructure.Context
{
    public class ResturantDbContext : DbContext
    {
        public ResturantDbContext() : base()
        {
        }
        public ResturantDbContext(DbContextOptions<ResturantDbContext> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Chef> Chef { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = config.GetConnectionString("ResturantDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
