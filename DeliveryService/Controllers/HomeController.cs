using DeliveryService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryService.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _repo;

        public HomeController(IProductRepository repo)
        {
            _repo = repo;
        }

        public ViewResult Index()
        {
            return View(_repo.Products);
        }
        [Authorize]
        public ViewResult ProductDetails(int id)
        {
            return View(_repo.GetProductById(id));
        }
    }
}
