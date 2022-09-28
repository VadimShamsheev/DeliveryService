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
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CartProduct> OrderProducts { get; set; }
        public DbSet<ExtraProduct> ExtraProducts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasMany(p => p.OrderEntities).WithOne
            //modelBuilder.Entity<ExtraProduct>().HasKey(p => new { p.ExtraId, p.ProductId });
            modelBuilder.Entity<ExtraProduct>().Property(p => p.ExtraCount).HasDefaultValue(1);
        }
    }
}
