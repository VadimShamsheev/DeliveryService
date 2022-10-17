using Microsoft.AspNetCore.Mvc;
using DeliveryService.Models;
using DeliveryService.Models.Interfaces;

namespace DeliveryService.Controllers
{
    public class CartController : Controller
    {
        private ICartRepository _context;
        public CartController(ICartRepository context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public void AddToCart(int productId)
        {

        }
    }
}
