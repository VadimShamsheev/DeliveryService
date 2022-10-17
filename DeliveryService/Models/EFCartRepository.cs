using DeliveryService.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryService.Models
{
    public class EFCartRepository : ICartRepository
    {
        private ApplicationContext _context;
        public EFCartRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddProductToCart(int productId)
        {
            CartProduct product = new CartProduct
            {
                ProductId = productId,
                
            };
        }

        public void RemoveProductFromCart(int productId)
        {
            throw new System.NotImplementedException();
        }
    }
}
