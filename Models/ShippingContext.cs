using Microsoft.EntityFrameworkCore;

namespace helloLogistic.Models
{
    public class ShippingContext : DbContext
    {
        public DbSet<Box> Boxes { get; set; }        
        public DbSet<Part> Parts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Shipping.db");
    }
}