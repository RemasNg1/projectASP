using Microsoft.EntityFrameworkCore;
using SatrAspProject.Models;
namespace SatrAspProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
        
        public DbSet<ProductModel> Products { get; set; }


       

    }



}
