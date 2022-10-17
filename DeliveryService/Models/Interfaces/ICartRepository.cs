using System.Collections.Generic;

namespace DeliveryService.Models.Interfaces
{
    public interface ICartRepository
    {
        void AddProductToCart(int productId);
        void RemoveProductFromCart(int productId);
    }
}
