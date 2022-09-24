using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<UserData> Users { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<ExtraProduct> ExtraProducts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasMany(p => p.OrderEntities).WithOne
            modelBuilder.Entity<OrderProduct>().HasKey(p => new { p.OrderId, p.ProductId });
            modelBuilder.Entity<ExtraProduct>().HasKey(p => new { p.ExtraId, p.ProductId });
        }
    }
}
