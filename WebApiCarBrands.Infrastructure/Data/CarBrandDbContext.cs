using Microsoft.EntityFrameworkCore;
using WebApiCarBrands.Domain.Entities;

namespace WebApiCarBrands.Infrastructure.Data
{
    public class CarBrandDbContext(DbContextOptions<CarBrandDbContext> options) : DbContext(options)
    {
        public DbSet<CarBrand> CarBrands => Set<CarBrand>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CarBrand>().HasData(
                new CarBrand { Id = 1, Name = "Toyota", Description = "A reliable and popular car brand", Year = "1937", Country = "Japan" },
                new CarBrand { Id = 2, Name = "Mercedes-Benz", Description = "A luxury car brand with elegant designs", Year = "1926", Country = "Germany" },
                new CarBrand { Id = 3, Name = "Ford", Description = "An innovative car brand known for the Model T", Year = "1903", Country = "USA" },
                new CarBrand { Id = 4, Name = "Ferrari", Description = "A sports car brand known for its speed and performance", Year = "1939", Country = "Italy" },
                new CarBrand { Id = 5, Name = "Tesla", Description = "An electric car brand with cutting-edge technology", Year = "2003", Country = "USA" }
            );
        }
    }
}
