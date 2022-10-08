using System.Collections.Generic;
using System.Linq;

namespace DeliveryService.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
