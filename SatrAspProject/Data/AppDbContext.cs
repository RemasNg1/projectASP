using Microsoft.EntityFrameworkCore;
using SatrAspProject.Models;
namespace SatrAspProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
        
        public DbSet<ProductModel> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name="Phone",  Price=666.2f });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name="Laptop", Price=100.2f });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name="TV", Price=345.2f });



        }

    }



}
