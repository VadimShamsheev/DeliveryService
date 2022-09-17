using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasMany(p => p.OrderEntities).WithOne
            modelBuilder.Entity<OrderProduct>().HasKey(p => new { p.OrderId, p.ProductId });
        }
    }
}
