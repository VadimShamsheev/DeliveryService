using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryService.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationContext _context;
        public IQueryable<Product> Products => _context.Products;

        public EFProductRepository(ApplicationContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Product> GetProductsByCategory(int categoryId) =>
            _context.Products.Where(p => p.Category == categoryId).ToList();

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Where(p => p.Id.Equals(id)).Include(p => p.CategoryEntity).FirstOrDefault();
        }

        public void UpdateProduct(Product product)
        {
            Product prod = _context.Products.Where(p => p.Equals(product)).FirstOrDefault();
            prod.Name = product.Name;
            prod.Description = product.Description;
            prod.Category = product.Category;
            prod.Price = product.Price;
            _context.SaveChanges();
        }
    }
}
